using System;
using System.Text;

namespace SiteServer.Plugin
{
    public class ParseEventArgs : EventArgs
    {
        public ParseEventArgs(int siteId, int channelId, int contentId, TemplateType templateType, int templateId, string filePath, StringBuilder contentBuilder)
        {
            SiteId = siteId;
            ChannelId = channelId;
            ContentId = contentId;
            TemplateType = templateType;
            TemplateId = templateId;
            FilePath = filePath;
            ContentBuilder = contentBuilder;
        }

        public int SiteId { get; private set; }

        public int ChannelId { get; private set; }

        public int ContentId { get; private set; }

        public TemplateType TemplateType { get; private set; }

        public int TemplateId { get; private set; }

        public string FilePath { get; private set; }

        public StringBuilder ContentBuilder { get; private set; }
    }
}
