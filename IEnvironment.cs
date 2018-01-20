namespace SiteServer.Plugin
{
    public interface IEnvironment
    {
        string DatabaseType { get; }

        string ConnectionString { get; }

        string AdminDirectory { get; }

        string PhysicalApplicationPath { get; }
    }
}
