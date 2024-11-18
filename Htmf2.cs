namespace HtmfExample;

public class Htmf2
{
    private List<Element2> Elements = [];
    private Stack<Element2> elementStack = new();
    private string ApiUrl = string.Empty;

    public Htmf2(string? apiUrl = null)
    {
        ApiUrl = apiUrl ?? "";
    }

    private Htmf2 Element(string tag, string innerText = "")
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

    public Htmf2 Get(string url)
    {
        if (elementStack.Count != 0)
        {
            Element2 element = elementStack.Peek();
            element.Attributes["hf-get"] = ApiUrl + url;
            element.Attributes["hf-trigger"] = "click";
        }
        return this;
    }

    public Htmf2 Put(string url)
    {
        if (elementStack.Count != 0)
        {
            Element2 element = elementStack.Peek();
            element.Attributes["hf-put"] = ApiUrl + url;
            element.Attributes["hf-trigger"] = "click";
        }
        return this;
    }

    public Htmf2 Delete(string url)
    {
        if (elementStack.Count != 0)
        {
            Element2 element = elementStack.Peek();
            element.Attributes["hf-delete"] = ApiUrl + url;
            element.Attributes["hf-trigger"] = "click";
        }
        return this;
    }

    public Htmf2 Css(string cssClass)
    {
        if (elementStack.Count != 0)
        {
            elementStack.Peek().Attributes["class"] = cssClass;
        }
        return this;
    }

    public Htmf2 Text(string innerText)
    {
        if (elementStack.Count != 0)
        {
            elementStack.Peek().InnerText = innerText;
        }
        return this;
    }

    public Htmf2 H1(string content)
    {
        return Element("h1", content);
    }

    public Htmf2 Div(string content)
    {
        return Element("div", content);
    }

    public Htmf2 H1(Func<Htmf2, Htmf2> nestedBuilderFunc)
    {
        return ElementWithNestedBuilder("h1", nestedBuilderFunc);
    }

    public Htmf2 Div(Func<Htmf2, Htmf2> nestedBuilderFunc)
    {
        return ElementWithNestedBuilder("div", nestedBuilderFunc);
    }

    private Htmf2 ElementWithNestedBuilder(string tag, Func<Htmf2, Htmf2> nestedBuilderFunc)
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
        return string.Join("", Elements.Select(BuildElement));
    }

    private static string BuildElement(Element2 element)
    {
        var attributes = string.Join(" ", element.Attributes.Select(a => $"{a.Key}=\"{a.Value}\""));
        var children = string.Join("", element.Children.Select(BuildElement));
        return $"<{element.Tag}{(string.IsNullOrEmpty(attributes) ? "" : " " + attributes)}>{element.InnerText}{children}</{element.Tag}>";
    }
}

public record Element2()
{
    public required string Tag { get; set; }
    public string InnerText { get; set; } = string.Empty;
    public List<Element2> Children { get; set; } = [];
    public Dictionary<string, string> Attributes { get; set; } = [];
}
