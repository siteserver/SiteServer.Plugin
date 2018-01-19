using System;
using SiteServer.Plugin.Models;

namespace SiteServer.Plugin.Features
{
    public interface IRender: IPlugin
    {
        Func<IPluginRenderContext, string> Render { get; }
    }
}
