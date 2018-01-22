namespace SiteServer.Plugin.Apis
{
    public interface IConfigApi
    {
        bool SetConfig(int siteId, string name, object config);

        bool SetConfig(int siteId, object config);

        T GetConfig<T>(int siteId, string name = "");

        bool RemoveConfig(int siteId, string name = "");

        ISystemConfigInfo SystemConfigInfo { get; }
    }
}
