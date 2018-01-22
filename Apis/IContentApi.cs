using System.Collections.Generic;

namespace SiteServer.Plugin.Apis
{
    public interface IContentApi
    {
        IContentInfo NewInstance();

        IContentInfo GetContentInfo(int siteId, int channelId, int contentId);

        List<IContentInfo> GetContentInfoList(int siteId, int channelId, string whereString,
            string orderString, int limit, int offset);

        List<int> GetContentIdList(int siteId, int channelId);

        int GetCount(int siteId, int channelId, string whereString);

        string GetContentValue(int siteId, int channelId, int contentId, string attributeName);

        string GetTableName(int siteId, int channelId);

        List<TableColumn> GetTableColumns(int siteId, int channelId);

        int Insert(int siteId, int channelId, IContentInfo contentInfo);

        void Update(int siteId, int channelId, IContentInfo contentInfo);

        void Delete(int siteId, int channelId, int contentId);
    }
}
