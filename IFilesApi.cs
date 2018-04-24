using System.Collections.Generic;

namespace SiteServer.Plugin
{
    public interface IFilesApi
    {
        void MoveFiles(int sourceSiteId, int targetSiteId, List<string> relatedUrls);

        void AddWaterMark(int siteId, string filePath);

        string GetUploadFilePath(int siteId, string fileName);

        string GetTemporaryFilesPath(string relatedPath);

        string GetSitePath(int siteId, string virtualPath);

        string GetSiteUrl(int siteId);

        string GetSiteUrl(int siteId, string relatedUrl);

        string GetSiteUrlByFilePath(string filePath);

        string GetChannelUrl(int siteId, int channelId);

        string GetContentUrl(int siteId, int channelId, int contentId);

        string GetRootUrl(string relatedUrl);

        string GetAdminDirectoryUrl(string relatedUrl);

        void CreateZip(string zipFilePath, string directoryPath);

        void ExtractZip(string zipFilePath, string directoryPath);
    }
}
