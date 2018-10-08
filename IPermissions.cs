using System;
using System.Collections.Generic;

namespace SiteServer.Plugin
{
    /// <summary>
    /// 登录账号的权限。
    /// </summary>
    public interface IPermissions
    {
        List<int> GetSiteIdList();

        List<int> ChannelIdList { get; }

        bool HasSystemPermissions(params string[] permissions);

        bool HasSitePermissions(int siteId, params string[] permissions);

        bool HasChannelPermissions(int siteId, int channelId, params string[] permissions);
    }
}