namespace SiteServer.Plugin
{
    public sealed class PluginContext: IEnvironment, IApiCollection
    {
        public static PluginContext Current { get; internal set; }

        private readonly IEnvironment _environment;
        private readonly IApiCollection _apiCollection;

        /// <param name="environment">环境变量接口。</param>
        /// <param name="apiCollection">API类集合接口。</param>
        public PluginContext(IEnvironment environment, IApiCollection apiCollection)
        {
            _environment = environment;
            _apiCollection = apiCollection;
        }

        /// <summary>
        /// 系统使用的数据库类型。
        /// </summary>
        public DatabaseType DatabaseType => _environment.DatabaseType;

        /// <summary>
        /// 系统使用的数据库连接字符串。
        /// </summary>
        public string ConnectionString => _environment.ConnectionString;

        /// <summary>
        /// 系统后台文件夹名称，默认为SiteServer。
        /// </summary>
        public string AdminDirectory => _environment.AdminDirectory;

        /// <summary>
        /// 网站根目录文件夹地址。
        /// </summary>
        public string PhysicalApplicationPath => _environment.PhysicalApplicationPath;

        /// <summary>
        /// 获取插件Url访问请求IRequest。
        /// 当存在对插件的HTTP访问请求时（REST Api访问、aspx页面访问等），返回IRequest实例；否则返回 null。
        /// </summary>
        public IRequest Request => _environment.Request;

        /// <summary>
        /// 管理员及权限Api接口。
        /// </summary>
        public IAdminApi AdminApi => _apiCollection.AdminApi;

        /// <summary>
        /// 插件及系统配置Api接口。
        /// </summary>
        public IConfigApi ConfigApi => _apiCollection.ConfigApi;

        /// <summary>
        /// 内容Api接口。
        /// </summary>
        public IContentApi ContentApi => _apiCollection.ContentApi;

        /// <summary>
        /// 数据库操作Api接口。
        /// </summary>
        public IDatabaseApi DatabaseApi => _apiCollection.DatabaseApi;

        /// <summary>
        /// 栏目Api接口。
        /// </summary>
        public IChannelApi ChannelApi => _apiCollection.ChannelApi;

        /// <summary>
        /// STL解析Api接口。
        /// </summary>
        public IParseApi ParseApi => _apiCollection.ParseApi;

        /// <summary>
        /// 插件Api接口。
        /// </summary>
        public IPluginApi PluginApi => _apiCollection.PluginApi;

        /// <summary>
        /// 站点Api接口。
        /// </summary>
        public ISiteApi SiteApi => _apiCollection.SiteApi;

        /// <summary>
        /// 用户Api接口。
        /// </summary>
        public IUserApi UserApi => _apiCollection.UserApi;

        /// <summary>
        /// 工具类Api接口。
        /// </summary>
        public IUtilsApi UtilsApi => _apiCollection.UtilsApi;
    }
}
