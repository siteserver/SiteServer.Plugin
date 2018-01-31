using System;

namespace SiteServer.Plugin
{
    public class ContentFormLoadEventArgs : EventArgs
    {
        public ContentFormLoadEventArgs(int siteId, int channelId, string attributeName, IAttributes form)
        {
            SiteId = siteId;
            ChannelId = channelId;
            AttributeName = attributeName;
            Form = form;
        }

        public int SiteId { get; private set; }

        public int ChannelId { get; private set; }

        public string AttributeName { get; private set; }

        public IAttributes Form { get; private set; }
    }
}
