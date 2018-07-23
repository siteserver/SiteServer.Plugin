using System;

namespace SiteServer.Plugin
{
    /// <summary>
    /// 插件日志实体接口。
    /// 对应数据库中的siteserver_Log表。
    /// </summary>
    public interface ILogInfo
    {
        /// <summary>
        /// 自增长主键。
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// 管理员账号。
        /// </summary>
        string UserName { get; set; }

        /// <summary>
        /// Ip地址。
        /// </summary>
        string IpAddress { get; set; }

        /// <summary>
        /// 添加时间。
        /// </summary>
        DateTime AddDate { get; set; }

        /// <summary>
        /// 动作。
        /// </summary>
        string Action { get; set; }

        /// <summary>
        /// 描述。
        /// </summary>
        string Summary { get; set; }
    }
}
