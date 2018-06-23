using System.Collections.Generic;
using System.Collections.Specialized;

namespace SiteServer.Plugin
{
    public interface IContentContext
    {
        int SiteId { get; }

        int ChannelId { get; }

        int ContentId { get; }
    }
}
