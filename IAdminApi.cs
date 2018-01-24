namespace SiteServer.Plugin
{
    public interface IAdminApi
    {
        bool IsAdminNameExists(string adminName);

        string AdminName { get; }

        bool IsPluginAuthorized { get; }

        bool IsSiteAuthorized(int siteId);

        bool HasSitePermissions(int siteId, params string[] sitePermissions);

        bool HasChannelPermissions(int siteId, int channelId, params string[] channelPermissions);
    }
}
