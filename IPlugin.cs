namespace SiteServer.Plugin
{
    public interface IPlugin: IEnvironment, IMetadata
    {
        /// <summary>
        /// 激活插件，执行初始化
        /// </summary>
        void Startup(IService service);

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
