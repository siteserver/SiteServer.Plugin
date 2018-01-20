using System.Collections.Generic;

namespace SiteServer.Plugin.Features
{
    public interface IContentModel : IPlugin
    {
        string ContentTableName { get; }

        List<TableColumn> ContentTableColumns { get; }
    }
}
