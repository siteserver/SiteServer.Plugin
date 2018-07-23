using System.Collections.Generic;
using System.Collections.Specialized;

namespace SiteServer.Plugin
{
    /// <summary>
    /// STL解析上下文。
    /// </summary>
    public interface IParseContext
    {
        /// <summary>
        /// 站点Id。
        /// </summary>
        int SiteId { get; }

        /// <summary>
        /// 栏目Id。
        /// </summary>
        int ChannelId { get; }

        /// <summary>
        /// 内容Id。
        /// </summary>
        int ContentId { get; }

        /// <summary>
        /// 内容实体。
        /// </summary>
        IContentInfo ContentInfo { get; }

        /// <summary>
        /// 模板类型。
        /// </summary>
        TemplateType TemplateType { get; }

        /// <summary>
        /// 模板Id。
        /// </summary>
        int TemplateId { get; }

        /// <summary>
        /// 生成的Html页面中包含在head标签内的代码。
        /// </summary>
        SortedDictionary<string, string> HeadCodes { get; }

        /// <summary>
        /// 生成的Html页面中包含在body标签内的代码。
        /// </summary>
        SortedDictionary<string, string> BodyCodes { get; }

        /// <summary>
        /// 生成的Html页面中包含在页面最底部的代码。
        /// </summary>
        SortedDictionary<string, string> FootCodes { get; }

        /// <summary>
        /// 当前解析的STL标签的属性键值集合。
        /// </summary>
        NameValueCollection StlAttributes { get; }

        /// <summary>
        /// 当前解析的STL标签的完整代码，而不仅限于标签内部的内容。
        /// </summary>
        string StlOuterHtml { get; }

        /// <summary>
        /// 当前解析的STL标签内部的内容。
        /// </summary>
        string StlInnerHtml { get; }

        /// <summary>
        /// 判断当前解析的STL标签是STL元素还是STL实体，如果是元素，则返回true；如果是实体，则返回false。
        /// </summary>
        bool IsStlElement { get; }
    }
}