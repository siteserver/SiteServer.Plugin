using System;
using System.Collections.Generic;

namespace SiteServer.Plugin
{
    /// <summary>
    /// 用户Api接口
    /// </summary>
    public interface IUserApi
    {
        /// <summary>初始化 <see cref="T:SiteServer.Plugin.IUserInfo" /> 类的新实例。</summary>
        /// <returns>
        /// 返回用户对象实例。
        /// </returns>
        IUserInfo NewInstance();

        /// <summary>
        /// 通过用户Id获取用户对象实例
        /// </summary>
        /// <param name="userId">用户Id</param>
        /// <returns>
        /// 如果用户Id不存在，则返回 null，否则返回指定的用户对象实例。
        /// </returns>
        IUserInfo GetUserInfoByUserId(int userId);

        /// <summary>
        /// 通过用户名获取用户对象实例
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <returns>
        /// 如果用户名不存在，则返回 null，否则返回指定的用户对象实例。
        /// </returns>
        IUserInfo GetUserInfoByUserName(string userName);

        /// <summary>
        /// 通过用户邮箱获取用户对象实例
        /// </summary>
        /// <param name="email">用户邮箱</param>
        /// <returns>
        /// 如果用户邮箱不存在，则返回 null，否则返回指定的用户对象实例。
        /// </returns>
        IUserInfo GetUserInfoByEmail(string email);

        /// <summary>
        /// 通过用户手机获取用户对象实例
        /// </summary>
        /// <param name="mobile">用户手机</param>
        /// <returns>
        /// 如果用户手机不存在，则返回 null，否则返回指定的用户对象实例。
        /// </returns>
        IUserInfo GetUserInfoByMobile(string mobile);

        /// <summary>
        /// 通过用户账号获取用户对象实例
        /// </summary>
        /// <param name="account">用户名、用户邮箱或者用户手机均可作为用户账号</param>
        /// <returns>
        /// 如果用户名、用户邮箱或者用户手机均不存在，则返回 null，否则返回指定的用户对象实例。
        /// </returns>
        IUserInfo GetUserInfoByAccount(string account);

        bool IsUserNameExists(string userName);

        bool IsEmailExists(string email);

        bool IsMobileExists(string mobile);

        bool Insert(IUserInfo userInfo, string password, out string errorMessage);

        bool Validate(string account, string password, out string userName, out string errorMessage);

        void UpdateLastActivityDateAndCountOfFailedLogin(string userName);

        void UpdateLastActivityDateAndCountOfLogin(string userName);

        bool ChangePassword(string userName, string password, out string errorMessage);

        void Update(IUserInfo userInfo);

        bool IsPasswordCorrect(string password, out string errorMessage);

        void AddLog(string userName, string action, string summary);

        List<ILogInfo> GetLogs(string userName, int totalNum, string action = "");
    }
}
