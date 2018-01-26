using System;
using System.Text;

namespace SiteServer.Plugin
{
    public class ContentFormLoadEventArgs : EventArgs
    {
        public ContentFormLoadEventArgs(int siteId, int channelId, int contentId, string attributeName, IContentInfo contentInfo, StringBuilder htmlBuilder)
        {
            SiteId = siteId;
            ChannelId = channelId;
            ContentId = contentId;
            AttributeName = attributeName;
            ContentInfo = contentInfo;
            HtmlBuilder = htmlBuilder;
        }

        public int SiteId { get; private set; }

        public int ChannelId { get; private set; }

        public int ContentId { get; private set; }

        public string AttributeName { get; private set; }

        public IContentInfo ContentInfo { get; private set; }

        public StringBuilder HtmlBuilder { get; private set; }
    }
}
