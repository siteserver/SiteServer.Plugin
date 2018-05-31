using System.Collections.Generic;
using System.Collections.Specialized;

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

        NameValueCollection StlAttributes { get; }

        string StlOuterHtml { get; }

        string StlInnerHtml { get; }

        Dictionary<string, object> StlItems { get; }

        bool IsStlElement { get; }
    }
}
