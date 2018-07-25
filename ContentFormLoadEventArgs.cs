using System;

namespace SiteServer.Plugin
{
    /// <summary>
    /// 为内容编辑（新增）页面的载入事件提供数据。
    /// </summary>
    public class ContentFormLoadEventArgs : EventArgs
    {
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
        /// 如果内容Id为0，则表示当前载入的页面为内容添加页面，否则当前载入的页面为内容编辑页面。
        /// </summary>
        public int ContentId { get; }

        /// <summary>
        /// 表单数据。
        /// </summary>
        public IAttributes Form { get; }

        /// <summary>
        /// 内容属性名称，代表内容编辑（新增）页面中的内容字段名称。
        /// </summary>
        public string AttributeName { get; }

        /// <summary>
        /// 内容属性Html标签，内容属性在编辑（新增）页面中的Html标签。
        /// </summary>
        public string AttributeHtml { get; }
    }
}