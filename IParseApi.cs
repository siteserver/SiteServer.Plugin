using System.Collections.Generic;

namespace SiteServer.Plugin
{
    /// <summary>
    /// STL解析Api接口。
    /// </summary>
    public interface IParseApi
    {
        Dictionary<string, string> GetStlElements(string html, List<string> stlElementNames);

        string Parse(string html, IParseContext context);

        string ParseAttributeValue(string attributeValue, IParseContext context);

        string GetCurrentUrl(IParseContext context);
    }
}