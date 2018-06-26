using System;
using System.Web;

namespace SiteServer.Plugin
{
    public interface IPluginApi
    {
        string GetPluginPath(string relatedPath = "");

        string GetPluginUrl(string relatedUrl = "");

        string PluginApiUrl { get; }

        [Obsolete]
        string GetPluginApiUrl(string action = "", string id = "");

        T GetPlugin<T>(string pluginId) where T : PluginBase;

        IRequest AuthRequest(HttpRequest httpRequest);
    }
}
