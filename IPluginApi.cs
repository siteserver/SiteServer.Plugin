namespace SiteServer.Plugin
{
    public interface IPluginApi
    {
        string PluginPath(string relatedPath = "");

        string GetPluginUrl(string relatedUrl = "");

        string GetPluginApiUrl(string action = "", string id = "");

        T GetPlugin<T>(string pluginId) where T : IPlugin;
    }
}
