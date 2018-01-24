using System.Collections.Generic;

namespace SiteServer.Plugin
{
    public interface IChannelApi
    {
        IChannelInfo NewInstance(int siteId);

        IChannelInfo GetChannelInfo(int siteId, int channelId);

        List<int> GetChannelIdList(int siteId, string adminName);

        List<int> GetChannelIdList(int siteId);

        List<int> GetChannelIdList(int siteId, int parentId);

        int Insert(int siteId, IChannelInfo channelInfo);
    }
}
