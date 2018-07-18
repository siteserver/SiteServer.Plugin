namespace SiteServer.Plugin
{
    /// <summary>
    /// 管理员及权限Api接口
    /// </summary>
    public interface IAdminApi
    {
        /// <summary>
        /// 查看管理员是否存在。
        /// </summary>
        /// <param name="adminName">管理员用户名。</param>
        /// <returns>
        /// 如果存在，则为true；否则为false。
        /// </returns>
        bool IsAdminNameExists(string adminName);

        /// <summary>
        /// 表示当前登录系统的管理员用户名。
        /// 此字段为只读。
        /// </summary>
        string AdminName { get; }

        /// <summary>
        /// 表示当前管理员是否有指定的系统权限。
        /// </summary>
        /// <param name="systemPermissions">
        /// 一个数组，其中包含需要判断的系统权限。
        /// 如果需要判断管理员是否有插件管理权限，可将插件Id作为参数传入。
        /// </param>
        /// <returns>
        /// 如果拥有指定的系统权限（任意一个），则为true；否则为false。
        /// </returns>
        bool HasSystemPermissions(params string[] systemPermissions);

        /// <summary>
        /// 表示当前管理员是否有指定的站点权限
        /// </summary>
        /// <param name="siteId">站点Id。</param>
        /// <param name="sitePermissions">
        /// 一个数组，其中包含需要判断的站点权限。
        /// 如果需要判断管理员是否有对应站点的插件管理权限，可将插件Id作为参数传入。
        /// </param>
        /// <returns>
        /// 如果拥有指定的站点权限（任意一个），则为true；否则为false。
        /// </returns>
        bool HasSitePermissions(int siteId, params string[] sitePermissions);

        /// <summary>
        /// 表示当前管理员是否有指定的栏目权限。
        /// </summary>
        /// <param name="siteId">站点Id。</param>
        /// <param name="channelId">栏目Id。</param>
        /// <param name="channelPermissions">
        /// 一个数组，其中包含需要判断的栏目权限。
        /// </param>
        /// <returns>
        /// 如果拥有指定的栏目权限（任意一个），则为true；否则为false。
        /// </returns>
        bool HasChannelPermissions(int siteId, int channelId, params string[] channelPermissions);
    }
}
