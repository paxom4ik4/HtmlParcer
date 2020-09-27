using AngleSharp.Html.Dom;

namespace HParser.Core
{
    interface IParser<T> where T : class
    {
        T Parse(IHtmlDocument document);
    }
}
