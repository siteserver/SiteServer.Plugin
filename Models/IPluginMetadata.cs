using System;
using System.Collections.Generic;

namespace SiteServer.Plugin.Models
{
    public interface IPluginMetadata
    {
        string Id { get; }
        string Version { get; }
        Uri IconUrl { get; }
        Uri ProjectUrl { get; }
        Uri LicenseUrl { get; }
        string Copyright { get; }
        string Description { get; }
        string ReleaseNotes { get; }
        bool RequireLicenseAcceptance { get; }
        string Summary { get; }
        string Title { get; }
        string Tags { get; }
        List<string> Authors { get; }
        string Owners { get; }
        string Language { get; }
    }
}
