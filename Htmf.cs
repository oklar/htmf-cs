using System.Linq.Expressions;

namespace HtmfExample;

public class Htmf
{
    private List<Element> Elements = [];
    private Element? CurrentElement = null;
    private string? CurrentTemplateId = null;
    private Element? CurrentTemplateElement = null;
    private bool IsPage = false;
    private string PageTitle = string.Empty;
    private List<string> Scripts = [];

    public Htmf() { }

    private Htmf Element(string tag, string innerText = "")
    {
        var element = new Element
        {
            Tag = tag,
            Children = new List<Element>(),
            Attributes = new Dictionary<string, string>(),
            InnerText = innerText,
            Events = new List<string>(),
            IsTemplate = false,
        };

        if (CurrentElement != null)
        {
            CurrentElement.Children.Add(element);
        }
        else
        {
            Elements.Add(element);
        }

        CurrentElement = element;
        return this;
    }

    public Htmf Script(string source)
    {
        Scripts.Add(source);
        return this;
    }

    public Htmf Page(string title = "")
    {
        IsPage = true; 
        PageTitle = title;
        return this;
    }

    public Htmf H1(string innerText = "")
    {
        Element("h1", innerText);
        return this;
    }

    public Htmf H2(string innerText = "")
    {
        Element("h2", innerText);
        return this;
    }

    public Htmf Div(string innerText = "")
    {
        Element("div", innerText);
        return this;
    }

    public Htmf Button(string innerText = "")
    {
        Element("button", innerText);
        return this;
    }

    public Htmf Div<T>(Expression<Func<T, object>> property)
    {
        if (!string.IsNullOrEmpty(CurrentTemplateId) && CurrentTemplateElement == null)
        {
            Template(CurrentTemplateId);
        }

        Element("div");
        CurrentElement!.Attributes["hf-prop"] = PropertyName(property);

        return this;
    }

    public Htmf Css(string classes)
    {
        if (CurrentElement is not null)
        {
            CurrentElement.Attributes["class"] = classes;
        }

        return this;
    }

    public Htmf Id(string id)
    {
        if (CurrentElement is not null)
        {
            CurrentElement.Attributes["id"] = id;
        }
        return this;
    }

    public Htmf Text(string innerText)
    {
        if (CurrentElement is not null)
        {
            CurrentElement.InnerText = innerText;
        }
        return this;
    }

    public Htmf Get(string url)
    {
        if (CurrentElement is not null)
        {
            string templateId = RandomId();
            CurrentTemplateId = templateId;
            CurrentElement.Events.Add($"onclick=\"fetchData('{url}', '{templateId}')\"");
        }
        return this;
    }

    public Htmf Put(string url)
    {
        if (CurrentElement is not null)
        {
            string templateId = RandomId();
            CurrentTemplateId = templateId;
            CurrentElement.Events.Add($"onclick=\"putData('{url}', '{templateId}')\"");
        }
        return this;
    }

    public Htmf Template(string templateId)
    {
        Element("template").Id(templateId);
        CurrentElement!.IsTemplate = true;
        CurrentTemplateElement = CurrentElement;
        return this;
    }

    public Htmf Target(string templateId)
    {
        if (CurrentElement is not null)
        {
            CurrentElement.Attributes["hf-target-id"] = templateId;
        }
        return this;
    }

    public Htmf Close()
    {
        if (CurrentElement is null) return this;

        var parent = FindParent(CurrentElement);
        if (parent != null)
        {
            CurrentElement = parent;
        }
        else
        {
            CurrentElement = null;
        }

        return this;
    }

    public Htmf CloseAll()
    {
        CurrentElement = null;
        return this;
    }

    private Element? FindParent(Element child)
    {
        Func<Element, Element, Element> findInTree = null;
        findInTree = (element, target) =>
        {
            foreach (var el in element.Children)
            {
                if (el == target)
                {
                    return element;
                }

                var found = findInTree(el, target);
                if (found != null) return found;
            }

            return null;
        };

        foreach (var el in Elements)
        {
            var parent = findInTree(el, child);
            if (parent != null)
            {
                return parent;
            }
        }

        return null;
    }

    public Htmf H1End()
    {
        return Close();
    }

    public Htmf _H2()
    {
        return Close();
    }

    public Htmf _Div()
    {
        return Close();
    }

    public Htmf _Button()
    {
        return Close();
    }

    public string Render()
    {
        if (IsPage)
        {
            var startPage = "<!DOCTYPE html><html lang=\"en\"><head><meta charset=\"UTF-8\"><meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">" 
                + RenderScripts() + "<title>" + PageTitle + "</title></head><body>";
            var endPage = "</body></html>\r\n";
            return startPage + string.Join("", Elements.Select(element => RenderElement(element))) + endPage;
        }

        return string.Join("", Elements.Select(element => RenderElement(element))) + RenderScripts();
    }

    private string RenderScripts()
    {
        return string.Join("", Scripts.Select(script => RenderElement(new Element() { Tag = "script", Attributes = new Dictionary<string, string>() { { "src", script } } })));
    }

    public string RenderElement(Element element)
    {
        var attrString = string.Join(" ", element.Attributes.Select(attr => $"{attr.Key}=\"{attr.Value}\""));
        var eventString = string.Join(" ", element.Events);

        var openTag = $"<{element.Tag}{(string.IsNullOrEmpty(attrString) ? "" : " " + attrString)}{(string.IsNullOrEmpty(eventString) ? "" : " " + eventString)}>";
        var closeTag = $"</{element.Tag}>";

        string childrenHtmlString = "";

        if (element.Children != null)
        {
            childrenHtmlString = string.Join("", element.Children.Select(child => RenderElement(child)));
        }

        return $"{openTag}{element.InnerText}{childrenHtmlString}{closeTag}";
    }

    private static string RandomId()
    {
        return $"id-{Guid.NewGuid()}";
    }

    //public void UpdateTemplate(string templateId, IEnumerable<object> data)
    //{
    //    var templateElement = document.GetElementById(templateId);
    //    var template = templates[templateId];

    //    string result = string.Join("", data.Select(item => template(item)));
    //    templateElement.InnerHtml = result;
    //}

    private static string PropertyName<T>(Expression<Func<T, object>> property)
    {
        return ((MemberExpression)property.Body).Member.Name;
    }
}

public record Element()
{
    public required string Tag { get; set; }
    public string InnerText { get; set; } = "";
    public bool IsTemplate { get; set; } = false;
    public List<Element> Children { get; set; } = [];
    public Dictionary<string, string> Attributes { get; set; } = [];
    public List<string> Events { get; set; } = [];
}
