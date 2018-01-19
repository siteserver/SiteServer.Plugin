namespace SiteServer.Plugin.Models
{
    public interface IPluginEnvironment
    {
        string DatabaseType { get; }

        string ConnectionString { get; }

        string AdminDirectory { get; }

        string PhysicalApplicationPath { get; }
    }
}
