namespace SiteServer.Plugin
{
    /// <summary>
    /// 插件运行环境接口。
    /// </summary>
    public interface IEnvironment
    {
        /// <summary>
        /// 系统使用的数据库类型。
        /// </summary>
        DatabaseType DatabaseType { get; }

        /// <summary>
        /// 系统使用的数据库连接字符串。
        /// </summary>
        string ConnectionString { get; }

        /// <summary>
        /// 系统后台文件夹名称，默认为SiteServer。
        /// </summary>
        string AdminDirectory { get; }

        /// <summary>
        /// 网站根目录文件夹地址。
        /// </summary>
        string PhysicalApplicationPath { get; }

        /// <summary>
        /// 获取插件Url访问请求IRequest。
        /// 当存在对插件的HTTP访问请求时（REST Api访问、aspx页面访问等），返回IRequest实例；否则返回 null。
        /// </summary>
        IRequest Request { get; }
    }
}
