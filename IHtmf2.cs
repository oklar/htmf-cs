
namespace HtmfExample;

public interface IHtmf2
{
    string Build();
    Htmf2 Css(string cssClass);
    Htmf2 Delete(string url);
    Htmf2 Div(string innerText);
    Htmf2 Get(string url);
    Htmf2 H1(string innerText);
    Htmf2 Put(string url);
    Htmf2 Target(string templateId);
    Htmf2 Text(string innerText);
}