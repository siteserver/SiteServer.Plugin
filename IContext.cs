using SiteServer.Plugin.Apis;

namespace SiteServer.Plugin
{
    public interface IContext
    {
        IEnvironment Environment { get; }

        IMetadata Metadata { get; }

        IAdminApi AdminApi { get; }

        IConfigApi ConfigApi { get; }

        IContentApi ContentApi { get; }

        IDataApi DataApi { get; }

        IFilesApi FilesApi { get; }

        IChannelApi ChannelApi { get; }

        IParseApi ParseApi { get; }

        IPaymentApi PaymentApi { get; }

        ISiteApi SiteApi { get; }

        ISmsApi SmsApi { get; }

        IUserApi UserApi { get; }
    }
}
