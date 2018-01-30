using System;
using System.Collections.Generic;

namespace SiteServer.Plugin
{
    public abstract class PluginBase : IPlugin
    {
        protected PluginBase()
        {

        }

        protected PluginBase(IMetadata metadata, IEnvironment environment, IApiCollection apiCollection)
        {
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

            DatabaseType = environment.DatabaseType;
            ConnectionString = environment.ConnectionString;
            AdminDirectory = environment.AdminDirectory;
            PhysicalApplicationPath = environment.PhysicalApplicationPath;

            AdminApi = apiCollection.AdminApi;
            ConfigApi = apiCollection.ConfigApi;
            ContentApi = apiCollection.ContentApi;
            DataApi = apiCollection.DataApi;
            FilesApi = apiCollection.FilesApi;
            ChannelApi = apiCollection.ChannelApi;
            ParseApi = apiCollection.ParseApi;
            PluginApi = apiCollection.PluginApi;
            SiteApi = apiCollection.SiteApi;
            UserApi = apiCollection.UserApi;
        }

        public abstract void Startup(IService service);

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

        public DatabaseType DatabaseType { get; }
        public string ConnectionString { get; }
        public string AdminDirectory { get; }
        public string PhysicalApplicationPath { get; }

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
