using System;

namespace SiteServer.Plugin.Features
{
    public interface IMenu : IPlugin
    {
        Menu PluginMenu { get; }

        Func<int, Menu> SiteMenu { get; }
    }
}
