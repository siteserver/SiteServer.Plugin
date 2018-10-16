namespace SiteServer.Plugin
{
    /// <summary>
    /// 封装插件上下文相关信息
    /// </summary>
    public static class PluginContext
    {
        private static IEnvironment _environment;
        private static IApiCollection _apiCollection;

        /// <param name="environment">环境变量接口。</param>
        /// <param name="apiCollection">API类集合接口。</param>
        public static void Initialize(IEnvironment environment, IApiCollection apiCollection)
        {
            if (_environment == null)
            {
                _environment = environment;
            }

            if (_apiCollection == null)
            {
                _apiCollection = apiCollection;
            }
        }

        /// <summary>
        /// 系统使用的数据库类型。
        /// </summary>
        public static DatabaseType DatabaseType => _environment.DatabaseType;

        /// <summary>
        /// 系统使用的数据库连接字符串。
        /// </summary>
        public static string ConnectionString => _environment.ConnectionString;

        /// <summary>
        /// 系统后台文件夹名称，默认为SiteServer。
        /// </summary>
        public static string AdminDirectory => _environment.AdminDirectory;

        /// <summary>
        /// 网站根目录文件夹地址。
        /// </summary>
        public static string PhysicalApplicationPath => _environment.PhysicalApplicationPath;

        /// <summary>
        /// 获取插件Url访问请求IRequest。
        /// 当存在对插件的HTTP访问请求时（REST Api访问、aspx页面访问等），返回IRequest实例；否则返回 null。
        /// </summary>
        public static IRequest Request => _environment.Request;

        /// <summary>
        /// 管理员及权限Api接口。
        /// </summary>
        public static IAdminApi AdminApi => _apiCollection.AdminApi;

        /// <summary>
        /// 插件及系统配置Api接口。
        /// </summary>
        public static IConfigApi ConfigApi => _apiCollection.ConfigApi;

        /// <summary>
        /// 内容Api接口。
        /// </summary>
        public static IContentApi ContentApi => _apiCollection.ContentApi;

        /// <summary>
        /// 数据库操作Api接口。
        /// </summary>
        public static IDatabaseApi DatabaseApi => _apiCollection.DatabaseApi;

        /// <summary>
        /// 栏目Api接口。
        /// </summary>
        public static IChannelApi ChannelApi => _apiCollection.ChannelApi;

        /// <summary>
        /// STL解析Api接口。
        /// </summary>
        public static IParseApi ParseApi => _apiCollection.ParseApi;

        /// <summary>
        /// 插件Api接口。
        /// </summary>
        public static IPluginApi PluginApi => _apiCollection.PluginApi;

        /// <summary>
        /// 站点Api接口。
        /// </summary>
        public static ISiteApi SiteApi => _apiCollection.SiteApi;

        /// <summary>
        /// 用户Api接口。
        /// </summary>
        public static IUserApi UserApi => _apiCollection.UserApi;

        /// <summary>
        /// 工具类Api接口。
        /// </summary>
        public static IUtilsApi UtilsApi => _apiCollection.UtilsApi;
    }
}
