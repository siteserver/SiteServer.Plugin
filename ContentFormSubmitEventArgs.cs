using System;

namespace SiteServer.Plugin
{
    /// <summary>
    /// 为内容编辑（新增）页面的提交事件提供数据。
    /// </summary>
    public class ContentFormSubmitEventArgs : EventArgs
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
        /// 即将保存至数据库的内容对象，可以从表单数据 <see cref="T:SiteServer.Plugin.IAttributes" /> 中获取属性值并设置到内容对象中。
        /// </summary>
        public IContentInfo ContentInfo { get; }
    }
}