using System;

namespace SiteServer.Plugin
{
    public class ContentTranslateEventArgs : EventArgs
    {
        public ContentTranslateEventArgs(int siteId, int channelId, int contentId, int targetSiteId, int targetChannelId, int targetContentId)
        {
            SiteId = siteId;
            ChannelId = channelId;
            ContentId = contentId;
            TargetSiteId = targetSiteId;
            TargetChannelId = targetChannelId;
            TargetContentId = targetContentId;
        }

        public int SiteId { get; private set; }

        public int ChannelId { get; private set; }

        public int ContentId { get; private set; }

        public int TargetSiteId { get; private set; }

        public int TargetChannelId { get; private set; }

        public int TargetContentId { get; private set; }
    }
}
