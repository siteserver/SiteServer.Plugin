namespace SiteServer.Plugin
{
    public interface IPlugin: IMetadata, IEnvironment, IApiCollection
    {
        /// <summary>
        /// 激活插件，执行初始化
        /// </summary>
        void Startup(IService service);
    }
}
