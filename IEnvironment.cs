namespace SiteServer.Plugin
{
    public interface IEnvironment
    {
        DatabaseType DatabaseType { get; }

        string ConnectionString { get; }

        string AdminDirectory { get; }

        string PhysicalApplicationPath { get; }
    }
}
