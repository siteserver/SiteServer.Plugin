using System;
using System.Text;

namespace SiteServer.Plugin
{
    public class ContentFormLoadEventArgs : EventArgs
    {
        public ContentFormLoadEventArgs(int siteId, int channelId, string attributeName, IAttributes form, StringBuilder htmlBuilder)
        {
            SiteId = siteId;
            ChannelId = channelId;
            AttributeName = attributeName;
            Form = form;
            HtmlBuilder = htmlBuilder;
        }

        public int SiteId { get; private set; }

        public int ChannelId { get; private set; }

        public string AttributeName { get; private set; }

        public IAttributes Form { get; private set; }

        public StringBuilder HtmlBuilder { get; private set; }
    }
}
