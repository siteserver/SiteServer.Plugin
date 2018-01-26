using System;
using System.Collections.Specialized;

namespace SiteServer.Plugin
{
    public class ContentFormSubmitEventArgs : EventArgs
    {
        public ContentFormSubmitEventArgs(int siteId, int channelId, IContentInfo contentInfo, NameValueCollection form)
        {
            SiteId = siteId;
            ChannelId = channelId;
            ContentInfo = contentInfo;
            Form = form;
        }

        public int SiteId { get; private set; }

        public int ChannelId { get; private set; }

        public IContentInfo ContentInfo { get; private set; }

        public NameValueCollection Form { get; private set; }
    }
}
