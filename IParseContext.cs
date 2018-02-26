using System.Collections.Generic;

namespace SiteServer.Plugin
{
    public interface IParseContext
    {
        int SiteId { get; }

        int ChannelId { get; }

        int ContentId { get; }

        IContentInfo ContentInfo { get; }

        TemplateType TemplateType { get; }

        int TemplateId { get; }

        SortedDictionary<string, string> StlPageHead { get; }

        SortedDictionary<string, string> StlPageBody { get; }

        SortedDictionary<string, string> StlPageFoot { get; }

        Dictionary<string, string> StlAttributes { get; }

        string StlInnerXml { get; }

        Dictionary<string, object> StlItems { get; }

        bool IsStlEntity { get; }
    }
}
