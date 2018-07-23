using System.Web;

namespace SiteServer.Plugin
{
    /// <summary>
    /// 插件Api接口。
    /// </summary>
    public interface IPluginApi
    {
        string GetPluginPath(string relatedPath = "");

        string GetPluginUrl(string relatedUrl = "");

        string PluginApiUrl { get; }

        T GetPlugin<T>(string pluginId) where T : PluginBase;

        IRequest AuthRequest(HttpRequest httpRequest);
    }
}
