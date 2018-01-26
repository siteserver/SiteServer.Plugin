using System;

namespace SiteServer.Plugin
{
    public class ContentFormSubmitEventArgs : EventArgs
    {
        public ContentFormSubmitEventArgs(int siteId, int channelId, IContentInfo contentInfo, IAttributes form)
        {
            SiteId = siteId;
            ChannelId = channelId;
            ContentInfo = contentInfo;
            Form = form;
        }

        public int SiteId { get; private set; }

        public int ChannelId { get; private set; }

        public IContentInfo ContentInfo { get; private set; }

        public IAttributes Form { get; private set; }
    }
}
