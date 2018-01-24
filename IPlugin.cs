namespace SiteServer.Plugin
{
    public interface IPlugin
    {
        /// <summary>
        /// 激活插件，执行初始化
        /// </summary>
        void Startup(IContext context, IService service);
    }
}
