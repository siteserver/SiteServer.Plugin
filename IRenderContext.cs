namespace SiteServer.Plugin
{
    public interface IRenderContext
    {
        string Html  { get; }

        int PublishmentSystemId { get; }

        int ChannelId { get; }

        int ContentId { get; }
    }
}
