using System.Collections.Generic;

namespace SiteServer.Plugin
{
    /// <summary>
    /// 文件及路径Api接口。
    /// </summary>
    public interface IFilesApi
    {
        /// <summary>
        /// 跨站转移文件。
        /// </summary>
        /// <param name="sourceSiteId">原站点Id。</param>
        /// <param name="targetSiteId">转移到站点Id。</param>
        /// <param name="relatedUrls">包含所有需要转移的文件的相对地址列表。</param>
        void MoveFiles(int sourceSiteId, int targetSiteId, List<string> relatedUrls);

        /// <summary>
        /// 根据后台设置为图片添加水印。
        /// </summary>
        /// <param name="siteId">站点Id。</param>
        /// <param name="imagePath">图片文件的地址。</param>
        void AddWaterMark(int siteId, string imagePath);

        /// <summary>
        /// 根据后台设置获取指定文件名的上传路径。
        /// </summary>
        /// <param name="siteId">站点Id。</param>
        /// <param name="fileName">需要上传的文件名称。</param>
        /// <returns>需要上传文件的地址。</returns>
        string GetUploadFilePath(int siteId, string fileName);

        /// <summary>
        /// 获取系统临时文件夹的绝对路径。
        /// </summary>
        /// <param name="relatedPath">相对路径。</param>
        /// <returns>系统临时文件夹的绝对路径。</returns>
        string GetTemporaryFilesPath(string relatedPath);

        /// <summary>
        /// 获取站点文件的绝对路径。
        /// </summary>
        /// <param name="siteId">站点Id。</param>
        /// <param name="virtualPath">相对路径。</param>
        /// <returns>指定站点的文件绝对路径。</returns>
        string GetSitePath(int siteId, string virtualPath);

        /// <summary>
        /// 获取站点访问Url地址。
        /// </summary>
        /// <param name="siteId">站点Id。</param>
        /// <returns>站点访问Url地址。</returns>
        string GetSiteUrl(int siteId);

        /// <summary>
        /// 获取站点访问Url地址。
        /// </summary>
        /// <param name="siteId">站点Id。</param>
        /// <param name="virtualPath">相对路径。</param>
        /// <returns>站点访问Url地址。</returns>
        string GetSiteUrl(int siteId, string virtualPath);

        /// <summary>
        /// 根据文件的绝对地址计算此文件的访问Url地址。
        /// </summary>
        /// <param name="filePath">文件的绝对路径。</param>
        /// <returns>此文件的访问Url地址。</returns>
        string GetSiteUrlByFilePath(string filePath);

        /// <summary>
        /// 获取栏目Url访问地址。
        /// </summary>
        /// <param name="siteId">站点Id。</param>
        /// <param name="channelId">栏目Id。</param>
        /// <returns>栏目Url访问地址。</returns>
        string GetChannelUrl(int siteId, int channelId);

        /// <summary>
        /// 获取内容Url访问地址。
        /// </summary>
        /// <param name="siteId">站点Id。</param>
        /// <param name="channelId">栏目Id。</param>
        /// <param name="contentId">内容Id。</param>
        /// <returns>内容Url访问地址。</returns>
        string GetContentUrl(int siteId, int channelId, int contentId);

        /// <summary>
        /// 获取系统根目录访问Url地址。
        /// </summary>
        /// <param name="relatedUrl">相对地址。</param>
        /// <returns>系统根目录访问Url地址。</returns>
        string GetRootUrl(string relatedUrl);

        /// <summary>
        /// 获取管理后台文件访问Url地址。
        /// </summary>
        /// <param name="relatedUrl">相对地址。</param>
        /// <returns>管理后台文件访问Url地址。</returns>
        string GetAdminDirectoryUrl(string relatedUrl);

        /// <summary>
        /// 压缩文件夹。
        /// </summary>
        /// <param name="zipFilePath">压缩后的zip文件绝对地址。</param>
        /// <param name="directoryPath">需要压缩的文件夹绝对地址。</param>
        void CreateZip(string zipFilePath, string directoryPath);

        /// <summary>
        /// 解压缩文件夹。
        /// </summary>
        /// <param name="zipFilePath">需要解压缩的zip文件绝对地址。</param>
        /// <param name="directoryPath">解压缩后的文件夹绝对地址。</param>
        void ExtractZip(string zipFilePath, string directoryPath);
    }
}