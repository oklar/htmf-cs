using System;
using System.Linq.Expressions;

namespace HtmfExample;


public class HtmfTemplate<T>
{
    public Htmf FromBuilder { get; }
    public Element2 TemplateElementRef { get; private set; }
    public string Id { get; } = RandomId();

    public HtmfTemplate(Htmf htmf, Func<HtmfTemplate<T>, HtmfTemplate<T>> nestedBuilderFunc)
    {
        FromBuilder = htmf;
        ElementWithNestedBuilder("template", nestedBuilderFunc);
    }

    private HtmfTemplate<T> ElementWithNestedBuilder(string tag, Func<HtmfTemplate<T>, HtmfTemplate<T>> nestedBuilderFunc)
    {
        var element = new Element2
        {
            Tag = tag,
            Children = new List<Element2>(), // Initialize Children
            Attributes = new Dictionary<string, string>(),
            InnerText = string.Empty,
        };

        if (tag == "template")
        {
            TemplateElementRef = element;
        }

        FromBuilder.AddElement(element);
        FromBuilder.PushElement(element);

        // Temporarily store and switch context to the new element's children
        var currentElements = FromBuilder.GetElements();
        FromBuilder.SetElements(element.Children);

        // Apply the nested builder function
        nestedBuilderFunc(this);

        // Restore the original context
        FromBuilder.SetElements(currentElements);
        FromBuilder.PopElement();

        return this;
    }

    public HtmfTemplate<T> DeleteT(Expression<Func<T, object>> property)
    {
        (string[] FormatStrings, string[] PropertyNames) = PropertyName(property);
        FromBuilder.SetAttribute("hf-prop-action", string.Join(";", PropertyNames));
        FromBuilder.Delete(string.Join("", FormatStrings));
        return this;
    }

    public HtmfTemplate<T> TextT(Expression<Func<T, object>> property)
    {
        (string[] FormatStrings, string[] PropertyNames) = PropertyName(property);

        FromBuilder.SetAttribute("hf-prop", string.Join(";", PropertyNames));
        FromBuilder.Text(string.Join("", FormatStrings));
        return this;
    }

    public HtmfTemplate<T> Div(Func<HtmfTemplate<T>, HtmfTemplate<T>> nestedBuilderFunc)
    {
        return ElementWithNestedBuilder("div", nestedBuilderFunc);
    }

    public HtmfTemplate<T> H1(Func<HtmfTemplate<T>, HtmfTemplate<T>> nestedBuilderFunc)
    {
        return ElementWithNestedBuilder("h1", nestedBuilderFunc);
    }

    public HtmfTemplate<T> DivT(Expression<Func<T, object>> property)
    {
        return TemplateElement("div", property);
    }
    
    public HtmfTemplate<T> ButtonT(Expression<Func<T, object>> property)
    {
        return TemplateElement("button", property);
    }

    public HtmfTemplate<T> H1T(Expression<Func<T, object>> property)
    {
        return TemplateElement("h1", property);
    }
    
    public HtmfTemplate<T> H2T(Expression<Func<T, object>> property)
    {
        return TemplateElement("h2", property);
    }
    
    private HtmfTemplate<T> TemplateElement(string tag, Expression<Func<T, object>> property)
    {
        FromBuilder.Element(tag);
        (string[] FormatStrings, string[] PropertyNames) = PropertyName(property);

        Element2 element = FromBuilder.PeekElement();
        element.Attributes["hf-prop"] = string.Join(";", PropertyNames);
        element.InnerText = string.Join("", FormatStrings);

        return this;
    }
    
    private static (string[] FormatStrings, string[] PropertyNames) PropertyName<U>(Expression<Func<U, object>> property)
    {
        Expression body = property.Body;

        if (body is UnaryExpression unaryExpression)
        {
            return (new string[] { }, new string[] { GetFullPropertyPath((MemberExpression)unaryExpression.Operand) });
        }

        if (body is MemberExpression memberExpression)
        {
            return (new string[] { }, new string[] { GetFullPropertyPath(memberExpression) });
        }

        if (body is MethodCallExpression methodCallExpression)
        {
            var formatStrings = new List<string>();
            var propertyNames = new List<string>();

            foreach (var argument in methodCallExpression.Arguments)
            {
                if (argument is MemberExpression memberExpressionLoop)
                {
                    propertyNames.Add(GetFullPropertyPath(memberExpressionLoop));
                }
                else if (argument is ConstantExpression constantExpression)
                {
                    formatStrings.Add(constantExpression.Value?.ToString() ?? string.Empty);
                }
                else if (argument is UnaryExpression unaryExpressionLoop)
                {
                    propertyNames.Add(GetFullPropertyPath((MemberExpression)unaryExpressionLoop.Operand));
                }
                else
                {
                    throw new ArgumentException("Unsupported expression type.", nameof(property));
                }
            }

            return (formatStrings.ToArray(), propertyNames.ToArray());
        }

        throw new ArgumentException("Unsupported expression type.", nameof(property));
    }
    
    private static string GetFullPropertyPath(MemberExpression expression)
    {
        var path = new List<string> { expression.Member.Name };
        while (expression.Expression is MemberExpression parentExpression)
        {
            path.Add(parentExpression.Member.Name);
            expression = parentExpression;
        }
        path.Reverse();
        return string.Join(".", path);
    }
    
    private static string RandomId()
    {
        return $"id-{Guid.NewGuid()}";
    }
    
    public string Build()
    {
        return FromBuilder.Build();
    }
    
    public HtmfTemplate<T> Class(string cssClass)
    {
        FromBuilder.Class(cssClass);
        return this;
    }
    
    public HtmfTemplate<T> Css(params string[] mwClasses)
    {
        FromBuilder.Css(mwClasses);
        return this;
    }
    
    public HtmfTemplate<T> Delete(string url)
    {
        FromBuilder.Delete(url);
        return this;
    }
    
    public HtmfTemplate<T> Get(string url)
    {
        FromBuilder.Get(url);
        return this;
    }
    
    public HtmfTemplate<T> Put(string url)
    {
        FromBuilder.Put(url);
        return this;
    }
    
    public HtmfTemplate<T> Target(string templateId)
    {
        FromBuilder.Target(templateId);
        return this;
    }
    
    public HtmfTemplate<T> TargetSelf()
    {
        FromBuilder.Target(Id);
        return this;
    }
    
    public HtmfTemplate<T> Div(string innerText)
    {
        FromBuilder.Div(innerText);
        return this;
    }
    
    public HtmfTemplate<T> Button(string innerText)
    {
        FromBuilder.Button(innerText);
        return this;
    }
    
    public HtmfTemplate<T> H1(string innerText)
    {
        FromBuilder.H1(innerText);
        return this;
    }
    
    public HtmfTemplate<T> H2(string innerText)
    {
        FromBuilder.H2(innerText);
        return this;
    }
    
    public HtmfTemplate<T> Text(string innerText)
    {
        FromBuilder.Text(innerText);
        return this;
    }
}

public class Htmf
{
    private bool IsPage = false;
    private string PageTitle = string.Empty;
    protected List<Element2> Elements = [];
    protected Stack<Element2> elementStack = new();
    public string ApiUrl = "";
    private Dictionary<string, string> cssClasses = [];

    public Htmf(string? apiUrl = null)
    {
        ApiUrl = apiUrl ?? "";
    }

    public Htmf Page(string title = "")
    {
        IsPage = true;
        PageTitle = title;
        return this;
    }

    public Htmf Element(string tag, string innerText = "")
    {
        var element = new Element2
        {
            Tag = tag,
            Children = [],
            Attributes = [],
            InnerText = innerText,
        };

        Elements.Add(element);
        elementStack.Push(element);

        return this;
    }

    public Htmf CreateTemplate<T>(Func<HtmfTemplate<T>, HtmfTemplate<T>> nestedBuilderFunc, Func<string, string> templateIdFunc)
    {
        var htmfTemplate = new HtmfTemplate<T>(this, nestedBuilderFunc);
        templateIdFunc(htmfTemplate.Id);
        return this;
    }

    public Htmf CreateTemplate<T>(List<T> list, Func<HtmfTemplate<T>, HtmfTemplate<T>> nestedBuilderFunc, Func<string, string> templateIdFunc)
    {
        var htmfTemplate = new HtmfTemplate<T>(this, nestedBuilderFunc);
        var templateId = htmfTemplate.Id;

        var templateElement = htmfTemplate.TemplateElementRef;
        templateElement.Attributes["id"] = templateId;

        templateIdFunc(templateId);

        var originalChildren = new List<Element2>(templateElement.Children);
        foreach (var item in list)
        {
            bool isFirstElement = true;

            foreach (var child in originalChildren)
            {
                Element2 newChild = ProcessElementRecursive(child, item, ref isFirstElement);

                AddElement(newChild);
            }
        }

        return this;
    }

    private Element2 ProcessElementRecursive<T>(Element2 templateChild, T item, ref bool isFirstElement)
    {
        var itemElement = new Element2
        {
            Tag = templateChild.Tag,
            Children = [],
            Attributes = new Dictionary<string, string>(templateChild.Attributes),
            InnerText = templateChild.InnerText,
        };

        if (isFirstElement)
        {
            itemElement.Attributes["hf-id"] = item?.GetType().GetProperty("Id")?.GetValue(item)?.ToString() ?? string.Empty;
            isFirstElement = false;
        }

        if (itemElement.Attributes.TryGetValue("hf-prop", out var propValue))
        {
            var props = propValue.Split(";");
            for (int i = 0; i < props.Length; i++)
            {
                var propParts = props[i].Split(".");
                object? value = item;
                foreach (var part in propParts)
                {
                    value = value?.GetType().GetProperty(part)?.GetValue(value);
                }
                itemElement.InnerText = itemElement.InnerText.Replace($"{{{i}}}", value?.ToString() ?? string.Empty);
            }
        }

        if (itemElement.Attributes.TryGetValue("hf-prop-action", out var propActionValue))
        {
            var props = propActionValue.Split(";");
            for (int i = 0; i < props.Length; i++)
            {
                var propParts = props[i].Split(".");
                object? value = item;
                foreach (var part in propParts)
                {
                    value = value?.GetType().GetProperty(part)?.GetValue(value);
                }

                List<KeyValuePair<string, string>> attributes = itemElement.Attributes
                    .Where(prop =>
                        prop.Key == "hf-delete" ||
                        prop.Key == "hf-put" ||
                        prop.Key == "hf-patch" ||
                        prop.Key == "hf-post" ||
                        prop.Key == "hf-get"
                    ).ToList();

                foreach (KeyValuePair<string, string> prop in attributes)
                {
                    itemElement.Attributes[prop.Key] = prop.Value.Replace($"{{{i}}}", value?.ToString() ?? string.Empty);
                }
            }
        }

        foreach (var child in templateChild.Children)
        {
            var newChild = ProcessElementRecursive(child, item, ref isFirstElement);
            itemElement.Children.Add(newChild);
        }

        return itemElement;
    }

    public Htmf Navigate(string url)
    {
        if (elementStack.Count != 0)
        {
            Element2 element = elementStack.Peek();
            element.Attributes["hf-nav"] = ApiUrl + url;
            element.Attributes["hf-trigger"] = "click";
        }
        return this;
    }

    public Htmf Href(string href)
    {
        if (elementStack.Count != 0)
        {
            Element2 element = elementStack.Peek();
            element.Attributes["href"] = href.StartsWith("http") ? href : ApiUrl + href;
        }
        return this;
    }

    public Htmf Target(string templateId)
    {
        if (elementStack.Count != 0)
        {
            Element2 element = elementStack.Peek();
            element.Attributes["hf-target"] = templateId;
        }
        return this;
    }

    public Htmf Get(string url)
    {
        if (elementStack.Count != 0)
        {
            Element2 element = elementStack.Peek();
            element.Attributes["hf-get"] = ApiUrl + url;
            element.Attributes["hf-trigger"] = "click";
        }
        return this;
    }

    public Htmf Put(string url)
    {
        if (elementStack.Count != 0)
        {
            Element2 element = elementStack.Peek();
            element.Attributes["hf-put"] = ApiUrl + url;
            element.Attributes["hf-trigger"] = "click";
        }
        return this;
    }

    public Htmf Delete(string url)
    {
        if (elementStack.Count != 0)
        {
            Element2 element = elementStack.Peek();
            element.Attributes["hf-delete"] = ApiUrl + url;
            element.Attributes["hf-trigger"] = "click";
        }
        return this;
    }

    public Htmf Class(string cssClass)
    {
        if (elementStack.Count != 0)
        {
            elementStack.Peek().Attributes["class"] = cssClass;
        }
        return this;
    }

    public Htmf Css(params string[] mwClasses)
    {
        List<string> classes = [];
        foreach (string cssClass in mwClasses)
        {
            string className = cssClass.Split("{").First().Replace(".", "");
            cssClasses[className] = cssClass;
            classes.Add(className);
        }

        if (elementStack.Count != 0)
        {
            elementStack.Peek().Attributes["class"] = string.Join(" ", classes);
        }
        return this;
    }

    public Htmf SetAttribute(string attribute, string value)
    {
        if (elementStack.Count != 0)
        {
            elementStack.Peek().Attributes[attribute] = value;
        }
        return this;
    }

    public Htmf Text(string innerText)
    {
        if (elementStack.Count != 0)
        {
            elementStack.Peek().InnerText = innerText;
        }
        return this;
    }
    public Htmf Button(string innerText)
    {
        return Element("button", innerText);
    }

    public Htmf H1(string innerText)
    {
        return Element("h1", innerText);
    }

    public Htmf H2(string innerText)
    {
        return Element("h2", innerText);
    }

    public Htmf Div(string innerText)
    {
        return Element("div", innerText);
    }
    public Htmf Button(Func<Htmf, Htmf> nestedBuilderFunc)
    {
        return ElementWithNestedBuilder("button", nestedBuilderFunc);
    }
    public Htmf H1(Func<Htmf, Htmf> nestedBuilderFunc)
    {
        return ElementWithNestedBuilder("h1", nestedBuilderFunc);
    }

    public Htmf H2(Func<Htmf, Htmf> nestedBuilderFunc)
    {
        return ElementWithNestedBuilder("h2", nestedBuilderFunc);
    }

    public Htmf Div(Func<Htmf, Htmf> nestedBuilderFunc)
    {
        return ElementWithNestedBuilder("div", nestedBuilderFunc);
    }

    protected Htmf ElementWithNestedBuilder(string tag, Func<Htmf, Htmf> nestedBuilderFunc)
    {
        var element = new Element2
        {
            Tag = tag,
            Children = [],
            Attributes = [],
            InnerText = string.Empty,
        };

        Elements.Add(element);
        elementStack.Push(element);

        // Temporarily store the current elements list
        List<Element2> currentElements = Elements;

        // Point Elements to the children of the new element
        Elements = element.Children;

        // Apply the nested builder function
        nestedBuilderFunc(this);

        // Restore the original elements list
        Elements = currentElements;

        // Pop the current element from the stack
        elementStack.Pop();

        return this;
    }

    public string Build()
    {
        if (IsPage)
        {
            var startPage = "<!DOCTYPE html><html lang=\"en\"><head><meta charset=\"UTF-8\"><meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">"
                /*+ RenderScripts()*/ + "<title>" + PageTitle + "</title>" + BuildCss() + "</head><body>";
            var endPage = "</body></html>\r\n";
            return startPage + string.Join("", Elements.Select(BuildElement)) + GetHtmfScripts() + endPage;
        }

        return BuildCss() + string.Join("", Elements.Select(BuildElement));// + RenderScripts();
    }

    public string GetHtmfScripts()
    {
        return "<script src=\"htmf.js\"></script>";
    }

    private string BuildCss()
    {
        return "<style>" + MicroWind.Preflight + " " + string.Join("", cssClasses.Select(c => c.Value)) + "</style>";
    }

    private static string BuildElement(Element2 element)
    {
        var attributes = string.Join(" ", element.Attributes.Select(a => $"{a.Key}=\"{a.Value}\""));
        var children = string.Join("", element.Children.Select(BuildElement));
        return $"<{element.Tag}{(string.IsNullOrEmpty(attributes) ? "" : " " + attributes)}>{element.InnerText}{children}</{element.Tag}>";
    }

    public void AddElement(Element2 element)
    {
        Elements.Add(element);
    }

    public void PushElement(Element2 element)
    {
        elementStack.Push(element);
    }

    public void PopElement()
    {
        elementStack.Pop();
    }

    public Element2 PeekElement()
    {
        return elementStack.Peek();
    }

    public List<Element2> GetElements()
    {
        return Elements;
    }

    public void SetElements(List<Element2> elements)
    {
        Elements = elements;
    }
}

public record Element2
{
    public required string Tag { get; set; }
    public string InnerText { get; set; } = string.Empty;
    public List<Element2> Children { get; set; } = [];
    public Dictionary<string, string> Attributes { get; set; } = [];
}
