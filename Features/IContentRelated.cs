using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Web.UI.WebControls;
using SiteServer.Plugin.Models;

namespace SiteServer.Plugin.Features
{
    public interface IContentRelated: IPlugin
    {
        List<HyperLink> ContentLinks { get; }

        Action<int, int, int> ContentAddCompleted { get; }

        Action<int, int, int, int, int, int> ContentTranslateCompleted { get; }

        Action<int, int, int> ContentDeleteCompleted { get; }

        Dictionary<string, Func<int, int, IAttributes, string>> ContentFormCustomized { get; }

        Action<int, int, IContentInfo, NameValueCollection> ContentFormSubmited { get; }
    }
}
