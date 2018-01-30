using System;
using System.Collections.Generic;

namespace SiteServer.Plugin
{
    public abstract class PluginBase : PluginInitialize, IMetadata, IEnvironment, IApiCollection
    {
        public sealed override void Initialize(IMetadata metadata, IEnvironment environment, IApiCollection apiCollection, PluginBase instance)
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

            Instance = instance;
        }

        public abstract void Startup(IService service);

        public static PluginBase Instance { get; private set; }

        public string Id { get; private set; }
        public string Version { get; private set; }
        public Uri IconUrl { get; private set; }
        public Uri ProjectUrl { get; private set; }
        public Uri LicenseUrl { get; private set; }
        public string Copyright { get; private set; }
        public string Description { get; private set; }
        public string ReleaseNotes { get; private set; }
        public bool RequireLicenseAcceptance { get; private set; }
        public string Summary { get; private set; }
        public string Title { get; private set; }
        public string Tags { get; private set; }
        public List<string> Authors { get; private set; }
        public string Owners { get; private set; }
        public string Language { get; private set; }

        public DatabaseType DatabaseType { get; private set; }
        public string ConnectionString { get; private set; }
        public string AdminDirectory { get; private set; }
        public string PhysicalApplicationPath { get; private set; }

        public IAdminApi AdminApi { get; private set; }
        public IConfigApi ConfigApi { get; private set; }
        public IContentApi ContentApi { get; private set; }
        public IDataApi DataApi { get; private set; }
        public IFilesApi FilesApi { get; private set; }
        public IChannelApi ChannelApi { get; private set; }
        public IParseApi ParseApi { get; private set; }
        public IPluginApi PluginApi { get; private set; }
        public ISiteApi SiteApi { get; private set; }
        public IUserApi UserApi { get; private set; }
    }
}
