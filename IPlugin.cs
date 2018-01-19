using SiteServer.Plugin.Models;
using System;

namespace SiteServer.Plugin
{
    public interface IPlugin
    {
        /// <summary>
        /// 激活插件，执行初始化
        /// </summary>
        Action<IPluginContext> PluginActive { get; }

        /// <summary>
        /// 卸载插件
        /// </summary>
        Action<IPluginContext> PluginUninstall { get; }
    }
}
