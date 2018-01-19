namespace SiteServer.Plugin.Models
{
    public interface IPluginRenderContext
    {
        string Html  { get; }
        int PublishmentSystemId { get; }
        int ChannelId { get; }
        int ContentId { get; }
    }
}
