using System;
using System.Collections.Generic;
using System.Text;

namespace SiteServer.Plugin
{
    public class ParseEventArgs : EventArgs
    {
        public ParseEventArgs(int siteId, int channelId, int contentId, TemplateType templateType, int templateId, string filePath, SortedDictionary<string, string> headCodes, SortedDictionary<string, string> bodyCodes, SortedDictionary<string, string> footCodes, StringBuilder contentBuilder)
        {
            SiteId = siteId;
            ChannelId = channelId;
            ContentId = contentId;
            TemplateType = templateType;
            TemplateId = templateId;
            FilePath = filePath;
            HeadCodes = headCodes;
            BodyCodes = bodyCodes;
            FootCodes = footCodes;
            ContentBuilder = contentBuilder;
        }

        public int SiteId { get; private set; }

        public int ChannelId { get; private set; }

        public int ContentId { get; private set; }

        public TemplateType TemplateType { get; private set; }

        public int TemplateId { get; private set; }

        public string FilePath { get; private set; }

        public SortedDictionary<string, string> HeadCodes { get; private set; }

        public SortedDictionary<string, string> BodyCodes { get; private set; }

        public SortedDictionary<string, string> FootCodes { get; private set; }

        public StringBuilder ContentBuilder { get; private set; }
    }
}
