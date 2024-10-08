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
    private string ApiUrl = string.Empty;
    private string Style = string.Empty;

    public Htmf(string? apiUrl = null)
    {
        ApiUrl = apiUrl ?? "";
    }

    private Htmf Element(string tag, string innerText = "")
    {
        var element = new Element
        {
            Tag = tag,
            Children = new List<Element>(),
            Attributes = new Dictionary<string, string>(),
            InnerText = innerText,
            Events = new List<string>(),
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

    public Htmf ScriptHead(string source)
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

    public Htmf Span(string innerText = "")
    {
        Element("span", innerText);
        return this;
    }

    public Htmf A(string innerText = "")
    {
        Element("a", innerText);
        return this;
    }

    public Htmf Template(string innerText = "")
    {
        Element("template", innerText);
        CurrentTemplateElement = CurrentElement;
        return this;
    }

    public Htmf Div<T>(Expression<Func<T, object>> property)
    {
        return TemplateElement<T>("div", property);
    }

    public Htmf Span<T>(Expression<Func<T, object>> property)
    {
        return TemplateElement<T>("span", property);
    }

    public Htmf Navigate(string url)
    {
        if (CurrentElement is not null)
        {
            CurrentElement.Attributes["hf-nav"] = ApiUrl + url;
            CurrentElement.Attributes["hf-trigger"] = "click";
        }

        return this;
    }

    public Htmf Href(string href)
    {
        if (CurrentElement is not null)
        {
            CurrentElement.Attributes["href"] = href;
        }

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

            if (CurrentElement.Tag == "template")
            {
                CurrentTemplateId = id;
            }
        }
        return this;
    }

    public Htmf ResourceId(string resourceId)
    {
        if (CurrentElement is not null)
        {
            CurrentElement.Attributes["hf-id"] = resourceId;
        }
        return this;
    }

    public Htmf ResourceId<T>(Expression<Func<T, object>> property)
    {
        if (CurrentElement is not null)
        {
            if (CurrentElement.Tag == "template")
            {
                return this; // todo: cannot be used on a template element as it is hidden from the dom
            }
            (string[] FormatStrings, string[] PropertyNames) = PropertyName(property);

            CurrentElement.Attributes["hf-prop-resource-id"] = string.Join(";", PropertyNames);
            CurrentElement.Attributes["hf-id"] = string.Join("", FormatStrings);
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
            CurrentElement.Attributes["hf-get"] = ApiUrl + url;
            CurrentElement.Attributes["hf-trigger"] = "click";
        }
        return this;
    }

    public Htmf Put(string url)
    {
        if (CurrentElement is not null)
        {
            CurrentElement.Attributes["hf-put"] = ApiUrl + url;
            CurrentElement.Attributes["hf-trigger"] = "click";
        }
        return this;
    }

    public Htmf Delete(string url)
    {
        if (CurrentElement is not null)
        {
            CurrentElement.Attributes["hf-delete"] = ApiUrl + url;
            CurrentElement.Attributes["hf-trigger"] = "click";
        }
        return this;
    }

    public Htmf Delete<T>(Expression<Func<T, object>> property)
    {
        if (CurrentElement is not null)
        {
            if (CurrentElement.Tag == "template")
            {
                return this; // todo: cannot be used on a template element as it is hidden from the dom
            }

            (string[] FormatStrings, string[] PropertyNames) = PropertyName(property);

            CurrentElement.Attributes["hf-prop-action"] = string.Join(";", PropertyNames);
            CurrentElement.Attributes["hf-delete"] = ApiUrl + string.Join("", FormatStrings);
            CurrentElement.Attributes["hf-trigger"] = "click";
        }

        return this;
    }

   

    public Htmf Target(string templateId)
    {
        if (CurrentElement is not null)
        {
            CurrentElement.Attributes["hf-target"] = templateId;
        }
        return this;
    }

    public Htmf Close()
    {
        if (CurrentElement is null) {
            CurrentTemplateId = null;
            return this;
        };

        if (CurrentElement.Tag == "template")
        {
            CurrentTemplateId = null;
        }

        CurrentElement = FindParent(CurrentElement);

        return this;
    }

    public Htmf CloseAll()
    {
        CurrentElement = null;
        CurrentTemplateId = null;
        return this;
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

    public Htmf _Template() 
    { 
        return Close(); 
    }

    public string Render()
    {
        if (IsPage)
        {
            var startPage = "<!DOCTYPE html><html lang=\"en\"><head><meta charset=\"UTF-8\"><meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">" 
                + RenderScripts() + "<title>" + PageTitle + "</title>" + Style + "</head><body>";
            var endPage = "</body></html>\r\n";
            return startPage + string.Join("", Elements.Select(element => RenderElement(element))) + GetHtmfScripts() + endPage;
        }

        return string.Join("", Elements.Select(element => RenderElement(element))) + RenderScripts();
    }

    public string GetHtmfScripts()
    {
        return "<script src=\"htmf.js\"></script>";
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

    private Element? FindParent(Element child)
    {
        // todo: improve by setting a reference parent in element
        Func<Element, Element, Element> findInTree = null;
        findInTree = (element, target) =>
        {
            foreach (Element el in element.Children)
            {
                if (el == target)
                {
                    return element;
                }

                Element found = findInTree(el, target);
                if (found != null) return found;
            }

            return null;
        };

        foreach (Element el in Elements)
        {
            Element parent = findInTree(el, child);
            if (parent != null)
            {
                return parent;
            }
        }

        return null;
    }

    private Htmf TemplateElement<T>(string tag, Expression<Func<T, object>> property)
    {
        if (string.IsNullOrEmpty(CurrentTemplateId))
        {
            Template();
        }

        Element(tag);
        (string[] FormatStrings, string[] PropertyNames) = PropertyName(property);


        CurrentElement!.Attributes["hf-prop"] = string.Join(";", PropertyNames);
        Text(string.Join("", FormatStrings));

        return this;
    }

    private static string RandomId()
    {
        return $"id-{Guid.NewGuid()}";
    }

    private static (string[] FormatStrings, string[] PropertyNames) PropertyName<T>(Expression<Func<T, object>> property)
    {
        Expression body = property.Body;

        if (body is UnaryExpression unaryExpression)
        {
            return ([], [GetFullPropertyPath((MemberExpression)unaryExpression.Operand)]);
        }

        if (body is MemberExpression memberExpression)
        {
            return ([], [GetFullPropertyPath(memberExpression)]);
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

    public Htmf TailwindStyle()
    {
        Style =
            "<style>" +
            "/* ! tailwindcss v3.4.5 | MIT License | https://tailwindcss.com */*,::after,::before{box-sizing:border-box;border-width:0;border-style:solid;border-color:#e5e7eb}::after,::before{--tw-content:''}:host,html{line-height:1.5;-webkit-text-size-adjust:100%;-moz-tab-size:4;tab-size:4;font-family:ui-sans-serif, system-ui, sans-serif, \"Apple Color Emoji\", \"Segoe UI Emoji\", \"Segoe UI Symbol\", \"Noto Color Emoji\";font-feature-settings:normal;font-variation-settings:normal;-webkit-tap-highlight-color:transparent}body{margin:0;line-height:inherit}hr{height:0;color:inherit;border-top-width:1px}abbr:where([title]){-webkit-text-decoration:underline dotted;text-decoration:underline dotted}h1,h2,h3,h4,h5,h6{font-size:inherit;font-weight:inherit}a{color:inherit;text-decoration:inherit}b,strong{font-weight:bolder}code,kbd,pre,samp{font-family:ui-monospace, SFMono-Regular, Menlo, Monaco, Consolas, \"Liberation Mono\", \"Courier New\", monospace;font-feature-settings:normal;font-variation-settings:normal;font-size:1em}small{font-size:80%}sub,sup{font-size:75%;line-height:0;position:relative;vertical-align:baseline}sub{bottom:-.25em}sup{top:-.5em}table{text-indent:0;border-color:inherit;border-collapse:collapse}button,input,optgroup,select,textarea{font-family:inherit;font-feature-settings:inherit;font-variation-settings:inherit;font-size:100%;font-weight:inherit;line-height:inherit;letter-spacing:inherit;color:inherit;margin:0;padding:0}button,select{text-transform:none}button,input:where([type=button]),input:where([type=reset]),input:where([type=submit]){-webkit-appearance:button;background-color:transparent;background-image:none}:-moz-focusring{outline:auto}:-moz-ui-invalid{box-shadow:none}progress{vertical-align:baseline}::-webkit-inner-spin-button,::-webkit-outer-spin-button{height:auto}[type=search]{-webkit-appearance:textfield;outline-offset:-2px}::-webkit-search-decoration{-webkit-appearance:none}::-webkit-file-upload-button{-webkit-appearance:button;font:inherit}summary{display:list-item}blockquote,dd,dl,figure,h1,h2,h3,h4,h5,h6,hr,p,pre{margin:0}fieldset{margin:0;padding:0}legend{padding:0}menu,ol,ul{list-style:none;margin:0;padding:0}dialog{padding:0}textarea{resize:vertical}input::placeholder,textarea::placeholder{opacity:1;color:#9ca3af}[role=button],button{cursor:pointer}:disabled{cursor:default}audio,canvas,embed,iframe,img,object,svg,video{display:block;vertical-align:middle}img,video{max-width:100%;height:auto}[hidden]{display:none}*, ::before, ::after{--tw-border-spacing-x:0;--tw-border-spacing-y:0;--tw-translate-x:0;--tw-translate-y:0;--tw-rotate:0;--tw-skew-x:0;--tw-skew-y:0;--tw-scale-x:1;--tw-scale-y:1;--tw-pan-x: ;--tw-pan-y: ;--tw-pinch-zoom: ;--tw-scroll-snap-strictness:proximity;--tw-gradient-from-position: ;--tw-gradient-via-position: ;--tw-gradient-to-position: ;--tw-ordinal: ;--tw-slashed-zero: ;--tw-numeric-figure: ;--tw-numeric-spacing: ;--tw-numeric-fraction: ;--tw-ring-inset: ;--tw-ring-offset-width:0px;--tw-ring-offset-color:#fff;--tw-ring-color:rgb(59 130 246 / 0.5);--tw-ring-offset-shadow:0 0 #0000;--tw-ring-shadow:0 0 #0000;--tw-shadow:0 0 #0000;--tw-shadow-colored:0 0 #0000;--tw-blur: ;--tw-brightness: ;--tw-contrast: ;--tw-grayscale: ;--tw-hue-rotate: ;--tw-invert: ;--tw-saturate: ;--tw-sepia: ;--tw-drop-shadow: ;--tw-backdrop-blur: ;--tw-backdrop-brightness: ;--tw-backdrop-contrast: ;--tw-backdrop-grayscale: ;--tw-backdrop-hue-rotate: ;--tw-backdrop-invert: ;--tw-backdrop-opacity: ;--tw-backdrop-saturate: ;--tw-backdrop-sepia: ;--tw-contain-size: ;--tw-contain-layout: ;--tw-contain-paint: ;--tw-contain-style: }::backdrop{--tw-border-spacing-x:0;--tw-border-spacing-y:0;--tw-translate-x:0;--tw-translate-y:0;--tw-rotate:0;--tw-skew-x:0;--tw-skew-y:0;--tw-scale-x:1;--tw-scale-y:1;--tw-pan-x: ;--tw-pan-y: ;--tw-pinch-zoom: ;--tw-scroll-snap-strictness:proximity;--tw-gradient-from-position: ;--tw-gradient-via-position: ;--tw-gradient-to-position: ;--tw-ordinal: ;--tw-slashed-zero: ;--tw-numeric-figure: ;--tw-numeric-spacing: ;--tw-numeric-fraction: ;--tw-ring-inset: ;--tw-ring-offset-width:0px;--tw-ring-offset-color:#fff;--tw-ring-color:rgb(59 130 246 / 0.5);--tw-ring-offset-shadow:0 0 #0000;--tw-ring-shadow:0 0 #0000;--tw-shadow:0 0 #0000;--tw-shadow-colored:0 0 #0000;--tw-blur: ;--tw-brightness: ;--tw-contrast: ;--tw-grayscale: ;--tw-hue-rotate: ;--tw-invert: ;--tw-saturate: ;--tw-sepia: ;--tw-drop-shadow: ;--tw-backdrop-blur: ;--tw-backdrop-brightness: ;--tw-backdrop-contrast: ;--tw-backdrop-grayscale: ;--tw-backdrop-hue-rotate: ;--tw-backdrop-invert: ;--tw-backdrop-opacity: ;--tw-backdrop-saturate: ;--tw-backdrop-sepia: ;--tw-contain-size: ;--tw-contain-layout: ;--tw-contain-paint: ;--tw-contain-style: }.flex{display:flex}.h-64{height:16rem}.h-full{height:100%}.w-full{width:100%}.flex-row{flex-direction:row}.justify-center{justify-content:center}.space-x-64 > :not([hidden]) ~ :not([hidden]){--tw-space-x-reverse:0;margin-right:calc(16rem * var(--tw-space-x-reverse));margin-left:calc(16rem * calc(1 - var(--tw-space-x-reverse)))}.rounded{border-radius:0.25rem}.bg-blue-500{--tw-bg-opacity:1;background-color:rgb(59 130 246 / var(--tw-bg-opacity))}.bg-gray-300{--tw-bg-opacity:1;background-color:rgb(209 213 219 / var(--tw-bg-opacity))}.bg-red-500{--tw-bg-opacity:1;background-color:rgb(239 68 68 / var(--tw-bg-opacity))}.px-4{padding-left:1rem;padding-right:1rem}.py-2{padding-top:0.5rem;padding-bottom:0.5rem}.font-bold{font-weight:700}.text-blue-500{--tw-text-opacity:1;color:rgb(59 130 246 / var(--tw-text-opacity))}.text-green-500{--tw-text-opacity:1;color:rgb(34 197 94 / var(--tw-text-opacity))}.text-white{--tw-text-opacity:1;color:rgb(255 255 255 / var(--tw-text-opacity))}.hover\\:bg-blue-700:hover{--tw-bg-opacity:1;background-color:rgb(29 78 216 / var(--tw-bg-opacity))}.hover\\:bg-red-700:hover{--tw-bg-opacity:1;background-color:rgb(185 28 28 / var(--tw-bg-opacity))}" +
            "</style>";

        return this;
    }
}

public record Element()
{
    public required string Tag { get; set; }
    public string InnerText { get; set; } = string.Empty;
    public List<Element> Children { get; set; } = [];
    public Dictionary<string, string> Attributes { get; set; } = [];
    public List<string> Events { get; set; } = [];
}
