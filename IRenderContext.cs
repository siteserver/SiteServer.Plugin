namespace SiteServer.Plugin
{
    public interface IRenderContext
    {
        string Html  { get; }

        int SiteId { get; }

        int ChannelId { get; }

        int ContentId { get; }
    }
}
