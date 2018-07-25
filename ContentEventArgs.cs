using System;

namespace SiteServer.Plugin
{
    /// <summary>
    /// 为内容操作事件提供数据
    /// </summary>
    public class ContentEventArgs : EventArgs
    {
        /// <summary>
        /// 内容的站点Id。
        /// </summary>
        public int SiteId { get; }

        /// <summary>
        /// 内容的栏目Id。
        /// </summary>
        public int ChannelId { get; }

        /// <summary>
        /// 内容Id。
        /// </summary>
        public int ContentId { get; }
    }
}