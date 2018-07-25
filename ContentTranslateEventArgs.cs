using System;

namespace SiteServer.Plugin
{
    /// <summary>
    /// 为内容转移事件提供数据
    /// </summary>
    public class ContentTranslateEventArgs : EventArgs
    {
        /// <summary>
        /// 原始内容的站点Id。
        /// </summary>
        public int SiteId { get; }

        /// <summary>
        /// 原始内容的栏目Id。
        /// </summary>
        public int ChannelId { get; }

        /// <summary>
        /// 原始内容的Id。
        /// </summary>
        public int ContentId { get; }

        /// <summary>
        /// 转移后内容的站点Id。
        /// </summary>
        public int TargetSiteId { get; }

        /// <summary>
        /// 转移后内容的栏目Id。
        /// </summary>
        public int TargetChannelId { get; }

        /// <summary>
        /// 转移后内容的Id。
        /// </summary>
        public int TargetContentId { get; }
    }
}