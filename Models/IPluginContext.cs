using SiteServer.Plugin.Apis;

namespace SiteServer.Plugin.Models
{
    public interface IPluginContext
    {
        IPluginEnvironment Environment { get; }

        IPluginMetadata Metadata { get; }

        IAdminApi AdminApi { get; }

        IConfigApi ConfigApi { get; }

        IContentApi ContentApi { get; }

        IDataApi DataApi { get; }

        IFilesApi FilesApi { get; }

        INodeApi NodeApi { get; }

        IParseApi ParseApi { get; }

        IPaymentApi PaymentApi { get; }

        IPublishmentSystemApi PublishmentSystemApi { get; }

        ISmsApi SmsApi { get; }

        IUserApi UserApi { get; }
    }
}
