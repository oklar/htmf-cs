using System.Linq.Expressions;
using System.Xml.Linq;

namespace HtmfExample;

public class HtmfTemplate<T>
{
    public Htmf2 FromBuilder { get; }
    public Element2 TemplateElementRef { get; private set; }
    public string Id { get; } = RandomId();

    public HtmfTemplate(Htmf2 htmf, Func<HtmfTemplate<T>, HtmfTemplate<T>> nestedBuilderFunc)
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

    public HtmfTemplate<T> H1T(Expression<Func<T, object>> property)
    {
        return TemplateElement("h1", property);
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

    public HtmfTemplate<T> Css(string cssClass)
    {
        FromBuilder.Css(cssClass);
        return this;
    }

    public HtmfTemplate<T> Delete(string url)
    {
        FromBuilder.Delete(url);
        return this;
    }

    public HtmfTemplate<T> Div(string innerText)
    {
        FromBuilder.Div(innerText);
        return this;
    }

    public HtmfTemplate<T> Get(string url)
    {
        FromBuilder.Get(url);
        return this;
    }

    public HtmfTemplate<T> H1(string innerText)
    {
        FromBuilder.H1(innerText);
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

    public HtmfTemplate<T> Text(string innerText)
    {
        FromBuilder.Text(innerText);
        return this;
    }
}

public class Htmf2 : IHtmf2
{
    protected List<Element2> Elements = [];
    protected Stack<Element2> elementStack = new();
    public string ApiUrl = "";

    public Htmf2(string? apiUrl = null)
    {
        ApiUrl = apiUrl ?? "";
    }

    public Htmf2 Element(string tag, string innerText = "")
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

    public Htmf2 CreateTemplate<T>(Func<HtmfTemplate<T>, HtmfTemplate<T>> nestedBuilderFunc)
    {
        _ = new HtmfTemplate<T>(this, nestedBuilderFunc);
        return this;
    }

    public Htmf2 CreateTemplate<T>(List<T> list, Func<HtmfTemplate<T>, HtmfTemplate<T>> nestedBuilderFunc)
    {
        var htmfTemplate = new HtmfTemplate<T>(this, nestedBuilderFunc);

        var templateElement = htmfTemplate.TemplateElementRef;

        // Use a copy of the children for safe iteration
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

        foreach (var child in templateChild.Children)
        {
            var newChild = ProcessElementRecursive(child, item, ref isFirstElement);
            itemElement.Children.Add(newChild);
        }

        return itemElement;
    }


    public Htmf2 Target(string templateId)
    {
        if (elementStack.Count != 0)
        {
            Element2 element = elementStack.Peek();
            element.Attributes["hf-target"] = templateId;
        }
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

    public Htmf2 SetAttribute(string attribute, string value)
    {
        if (elementStack.Count != 0)
        {
            elementStack.Peek().Attributes[attribute] = value;
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

    public Htmf2 H1(string innerText)
    {
        return Element("h1", innerText);
    }

    public Htmf2 Div(string innerText)
    {
        return Element("div", innerText);
    }

    public Htmf2 H1(Func<Htmf2, Htmf2> nestedBuilderFunc)
    {
        return ElementWithNestedBuilder("h1", nestedBuilderFunc);
    }

    public Htmf2 Div(Func<Htmf2, Htmf2> nestedBuilderFunc)
    {
        return ElementWithNestedBuilder("div", nestedBuilderFunc);
    }

    protected Htmf2 ElementWithNestedBuilder(string tag, Func<Htmf2, Htmf2> nestedBuilderFunc)
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
