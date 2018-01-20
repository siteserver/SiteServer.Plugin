using System;

namespace SiteServer.Plugin
{
    public interface ILogInfo
    {
        int Id { get; set; }

        string UserName { get; set; }

        string IpAddress { get; set; }

        DateTime AddDate { get; set; }

        string Action { get; set; }

        string Summary { get; set; }
    }
}
