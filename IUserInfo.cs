using System;

namespace SiteServer.Plugin
{
    /// <summary>
    /// 用户实体接口。
    /// </summary>
    public interface IUserInfo
    {
        /// <summary>
        /// 用户Id。
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// 用户名。
        /// </summary>
        string UserName { get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        DateTime CreateDate { get; set; }

        /// <summary>
        /// 最后一次重设密码时间。
        /// </summary>
        DateTime LastResetPasswordDate { get; set; }

        /// <summary>
        /// 最后活动时间。
        /// </summary>
        DateTime LastActivityDate { get; set; }

        /// <summary>
        /// 登录次数。
        /// </summary>
        int CountOfLogin { get; set; }

        /// <summary>
        /// 连续登录失败次数。
        /// </summary>
        int CountOfFailedLogin { get; set; }

        /// <summary>
        /// 投稿次数。
        /// </summary>
        int CountOfWriting { get; set; }

        /// <summary>
        /// 是否已审核用户。
        /// </summary>
        bool IsChecked { get; set; }

        /// <summary>
        /// 是否被锁定。
        /// </summary>
        bool IsLockedOut { get; set; }

        /// <summary>
        /// 用户姓名。
        /// </summary>
        string DisplayName { get; set; }

        /// <summary>
        /// 邮箱。
        /// </summary>
        string Email { get; set; }

        /// <summary>
        /// 手机号。
        /// </summary>
        string Mobile { get; set; }

        /// <summary>
        /// 头像图片路径。
        /// </summary>
        string AvatarUrl { get; set; }

        /// <summary>
        /// 组织。
        /// </summary>
        string Organization { get; set; }

        /// <summary>
        /// 部门。
        /// </summary>
        string Department { get; set; }

        /// <summary>
        /// 职位。
        /// </summary>
        string Position { get; set; }

        /// <summary>
        /// 性别。
        /// </summary>
        string Gender { get; set; }

        /// <summary>
        /// 出生日期。
        /// </summary>
        string Birthday { get; set; }

        /// <summary>
        /// 毕业院校。
        /// </summary>
        string Education { get; set; }

        /// <summary>
        /// 学历。
        /// </summary>
        string Graduation { get; set; }

        /// <summary>
        /// 地址。
        /// </summary>
        string Address { get; set; }

        /// <summary>
        /// 微信。
        /// </summary>
        string WeiXin { get; set; }

        /// <summary>
        /// QQ。
        /// </summary>
        string Qq { get; set; }

        /// <summary>
        /// 微博。
        /// </summary>
        string WeiBo { get; set; }

        /// <summary>
        /// 兴趣。
        /// </summary>
        string Interests { get; set; }

        /// <summary>
        /// 签名。
        /// </summary>
        string Signature { get; set; }
    }
}
