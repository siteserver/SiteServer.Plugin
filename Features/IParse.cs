using System;
using System.Collections.Generic;

namespace SiteServer.Plugin.Features
{
    public interface IParse: IPlugin
    {
        Dictionary<string, Func<IParseContext, string>> ElementsToParse { get; }
    }
}
