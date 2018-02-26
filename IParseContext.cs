using System.Collections.Generic;

namespace SiteServer.Plugin
{
    public interface IParseContext
    {
        SortedDictionary<string, string> HeadCodes { get; }

        SortedDictionary<string, string> BodyCodes { get; }

        SortedDictionary<string, string> FootCodes { get; }

        Dictionary<string, string> StlElementAttributes { get; }

        string StlElementInnerXml { get; }

        int SiteId { get; }

        int ChannelId { get; }

        int ContentId { get; }

        IContentInfo ContentInfo { get; }

        TemplateType TemplateType { get; }

        int TemplateId { get; }

        Dictionary<string, object> Items { get; }

        bool IsStlEntity { get; }
    }
}
