using System;

namespace SiteServer.Plugin.Features
{
    public interface IRender: IPlugin
    {
        Func<IRenderContext, string> Render { get; }
    }
}
