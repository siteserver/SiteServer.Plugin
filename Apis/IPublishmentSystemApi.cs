using System.Collections.Generic;

namespace SiteServer.Plugin.Apis
{
    public interface IPublishmentSystemApi
    {
        int GetPublishmentSystemIdByFilePath(string path);

        string GetPublishmentSystemPath(int publishmentSystemId);

        List<int> GetPublishmentSystemIds();

        ISiteInfo GetPublishmentSystemInfo(int publishmentSystemId);

        List<ISiteInfo> GetPublishmentSystemInfoList(string adminName);
    }
}
