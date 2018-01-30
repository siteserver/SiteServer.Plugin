using System;
using System.Collections.Generic;

namespace SiteServer.Plugin
{
    public abstract class PluginBase : IPlugin
    {
        protected PluginBase(IEnvironment environment, IMetadata metadata, IAdminApi adminApi, IConfigApi configApi,
            IContentApi contentApi, IDataApi dataApi, IFilesApi filesApi, IChannelApi channelApi, IParseApi parseApi,
            IPluginApi pluginApi, ISiteApi siteApi, IUserApi userApi)
        {
            DatabaseType = environment.DatabaseType;
            ConnectionString = environment.ConnectionString;
            AdminDirectory = environment.AdminDirectory;
            PhysicalApplicationPath = environment.PhysicalApplicationPath;

            Id = metadata.Id;
            Version = metadata.Version;
            IconUrl = metadata.IconUrl;
            ProjectUrl = metadata.ProjectUrl;
            LicenseUrl = metadata.LicenseUrl;
            Copyright = metadata.Copyright;
            Description = metadata.Description;
            ReleaseNotes = metadata.ReleaseNotes;
            RequireLicenseAcceptance = metadata.RequireLicenseAcceptance;
            Summary = metadata.Summary;
            Title = metadata.Title;
            Tags = metadata.Tags;
            Authors = metadata.Authors;
            Owners = metadata.Owners;
            Language = metadata.Language;

            AdminApi = adminApi;
            ConfigApi = configApi;
            ContentApi = contentApi;
            DataApi = dataApi;
            FilesApi = filesApi;
            ChannelApi = channelApi;
            ParseApi = parseApi;
            PluginApi = pluginApi;
            SiteApi = siteApi;
            UserApi = userApi;
        }

        public abstract void Startup(IService service);

        public DatabaseType DatabaseType { get; }
        public string ConnectionString { get; }
        public string AdminDirectory { get; }
        public string PhysicalApplicationPath { get; }
        public string Id { get; }
        public string Version { get; }
        public Uri IconUrl { get; }
        public Uri ProjectUrl { get; }
        public Uri LicenseUrl { get; }
        public string Copyright { get; }
        public string Description { get; }
        public string ReleaseNotes { get; }
        public bool RequireLicenseAcceptance { get; }
        public string Summary { get; }
        public string Title { get; }
        public string Tags { get; }
        public List<string> Authors { get; }
        public string Owners { get; }
        public string Language { get; }

        public IAdminApi AdminApi { get; }
        public IConfigApi ConfigApi { get; }
        public IContentApi ContentApi { get; }
        public IDataApi DataApi { get; }
        public IFilesApi FilesApi { get; }
        public IChannelApi ChannelApi { get; }
        public IParseApi ParseApi { get; }
        public IPluginApi PluginApi { get; }
        public ISiteApi SiteApi { get; }
        public IUserApi UserApi { get; }
    }
}
