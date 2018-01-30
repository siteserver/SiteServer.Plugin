namespace SiteServer.Plugin
{
    public abstract class PluginInitialize
    {
        public abstract void Initialize(IMetadata metadata, IEnvironment environment, IApiCollection apiCollection);
    }
}
