using System;

namespace SiteServer.Plugin
{
    public class ContentEventArgs : EventArgs
    {
        public ContentEventArgs(int siteId, int channelId, int contentId)
        {
            SiteId = siteId;
            ChannelId = channelId;
            ContentId = contentId;
        }

        public int SiteId { get; private set; }

        public int ChannelId { get; private set; }

        public int ContentId { get; private set; }
    }
}
