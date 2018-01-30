namespace SiteServer.Plugin
{
    public interface IApiCollection
    {
        IAdminApi AdminApi { get; }

        IConfigApi ConfigApi { get; }

        IContentApi ContentApi { get; }

        IDataApi DataApi { get; }

        IFilesApi FilesApi { get; }

        IChannelApi ChannelApi { get; }

        IParseApi ParseApi { get; }

        IPluginApi PluginApi { get; }

        ISiteApi SiteApi { get; }

        IUserApi UserApi { get; }
    }
}
