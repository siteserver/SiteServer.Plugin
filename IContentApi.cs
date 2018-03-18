using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;

namespace SiteServer.Plugin
{
    public interface IContentApi
    {
        IContentInfo NewInstance();

        IContentInfo Parse(object dataItem);

        IContentInfo Parse(IDataReader rdr);

        IContentInfo Parse(NameValueCollection attributes);

        IContentInfo Parse(string str);

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
