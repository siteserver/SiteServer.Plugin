using System.Collections.Generic;

namespace SiteServer.Plugin.Apis
{
    public interface ISiteApi
    {
        int GetSiteIdByFilePath(string path);

        string GetSitePath(int siteId);

        List<int> GetSiteIdList();

        ISiteInfo GetSiteInfo(int siteId);

        List<ISiteInfo> GetSiteInfoList(string adminName);
    }
}
