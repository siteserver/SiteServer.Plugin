using System.Collections.Generic;

namespace SiteServer.Plugin
{
    public interface IParseApi
    {
        Dictionary<string, string> GetStlElements(string innerXml, List<string> stlElementNames);

        string ParseInnerXml(string innerXml, IParseContext context);

        string ParseAttributeValue(string attributeValue, IParseContext context);

        string HtmlToXml(string html);

        string XmlToHtml(string xml);

        string GetCurrentUrl(IParseContext context);
    }
}
