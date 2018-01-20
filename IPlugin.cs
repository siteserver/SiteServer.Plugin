using System;

namespace SiteServer.Plugin
{
    public interface IPlugin
    {
        /// <summary>
        /// 激活插件，执行初始化
        /// </summary>
        Action<IContext> PluginActive { get; }

        /// <summary>
        /// 卸载插件
        /// </summary>
        Action<IContext> PluginUninstall { get; }
    }
}
