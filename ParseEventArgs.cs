using System;
using System.Collections.Generic;
using System.Text;

namespace SiteServer.Plugin
{
    /// <summary>
    /// 为STL解析事件提供数据。
    /// </summary>
    public class ParseEventArgs : EventArgs
    {
        /// <summary>
        /// 默认构造函数。
        /// </summary>
        public ParseEventArgs()
        {
        }

        /// <summary>
        /// 站点Id。
        /// </summary>
        public int SiteId { get; }

        /// <summary>
        /// 栏目Id。
        /// </summary>
        public int ChannelId { get; }

        /// <summary>
        /// 内容Id。
        /// </summary>
        public int ContentId { get; }

        /// <summary>
        /// 内容实体。
        /// </summary>
        IContentInfo ContentInfo { get; }

        /// <summary>
        /// 模板类型。
        /// </summary>
        public TemplateType TemplateType { get; }

        /// <summary>
        /// 模板Id。
        /// </summary>
        public int TemplateId { get; }

        /// <summary>
        /// 生成页面的绝对路径。
        /// </summary>
        public string FilePath { get; }

        /// <summary>
        /// 生成的Html页面中包含在head标签内的代码。
        /// </summary>
        public SortedDictionary<string, string> HeadCodes { get; }

        /// <summary>
        /// 生成的Html页面中包含在body标签内的代码。
        /// </summary>
        public SortedDictionary<string, string> BodyCodes { get; }

        /// <summary>
        /// 生成的Html页面中包含在页面最底部的代码。
        /// </summary>
        public SortedDictionary<string, string> FootCodes { get; }

        /// <summary>
        /// 生成的Html页面代码。
        /// </summary>
        public StringBuilder ContentBuilder { get; }
    }
}