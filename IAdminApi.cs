using System;

namespace SiteServer.Plugin
{
    /// <summary>
    /// 管理员及权限Api接口
    /// </summary>
    public interface IAdminApi
    {
        /// <summary>
        /// 通过管理员Id获取管理员对象实例。
        /// </summary>
        /// <param name="userId">管理员Id。</param>
        /// <returns>
        /// 如果管理员Id不存在，则返回 null，否则返回指定的管理员对象实例。
        /// </returns>
        IAdministratorInfo GetAdminInfoByUserId(int userId);

        /// <summary>
        /// 通过用户名获取管理员对象实例。
        /// </summary>
        /// <param name="userName">用户名。</param>
        /// <returns>
        /// 如果用户名不存在，则返回 null，否则返回指定的管理员对象实例。
        /// </returns>
        IAdministratorInfo GetAdminInfoByUserName(string userName);

        /// <summary>
        /// 通过管理员邮箱获取管理员对象实例。
        /// </summary>
        /// <param name="email">用户邮箱。</param>
        /// <returns>
        /// 如果管理员邮箱不存在，则返回 null，否则返回指定的管理员对象实例。
        /// </returns>
        IAdministratorInfo GetAdminInfoByEmail(string email);

        /// <summary>
        /// 通过管理员手机获取管理员对象实例。
        /// </summary>
        /// <param name="mobile">用户手机。</param>
        /// <returns>
        /// 如果管理员手机不存在，则返回 null，否则返回指定的管理员对象实例。
        /// </returns>
        IAdministratorInfo GetAdminInfoByMobile(string mobile);

        /// <summary>
        /// 通过管理员账号获取用户对象实例。
        /// </summary>
        /// <param name="account">用户名、管理员邮箱或者管理员手机均可作为管理员账号。</param>
        /// <returns>
        /// 如果用户名、管理员邮箱或者管理员手机均不存在，则返回 null，否则返回指定的管理员对象实例。
        /// </returns>
        IAdministratorInfo GetAdminInfoByAccount(string account);

        /// <summary>
        /// 判断用户名是否存在。
        /// </summary>
        /// <param name="userName">用户名。</param>
        /// <returns>如果用户名存在，则返回 true，否则返回 false。</returns>
        bool IsUserNameExists(string userName);

        /// <summary>
        /// 判断管理员邮箱是否存在。
        /// </summary>
        /// <param name="email">管理员邮箱。</param>
        /// <returns>如果管理员邮箱存在，则返回 true，否则返回 false。</returns>
        bool IsEmailExists(string email);

        /// <summary>
        /// 判断管理员手机是否存在。
        /// </summary>
        /// <param name="mobile">管理员手机。</param>
        /// <returns>如果管理员手机存在，则返回 true，否则返回 false。</returns>
        bool IsMobileExists(string mobile);

        /// <summary>
        /// 表示当前登录系统的管理员Id。
        /// 此字段为只读。
        /// </summary>
        int AdminId { get; }

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

        /// <summary>
        /// 获取Access Token字符串。
        /// </summary>
        /// <param name="userId">用户Id。</param>
        /// <param name="userName">用户名。</param>
        /// <param name="expiresAt">Access Token 到期时间。</param>
        /// <returns>返回此用户的Access Token。</returns>
        string GetAccessToken(int userId, string userName, DateTime expiresAt);

        /// <summary>
        /// 解析Access Token字符串。
        /// </summary>
        /// <param name="accessToken">用户Access Token。</param>
        /// <returns>存储于用户Token中的用户名。</returns>
        IAccessToken ParseAccessToken(string accessToken);
    }
}
