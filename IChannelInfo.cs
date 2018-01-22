using System;

namespace SiteServer.Plugin
{
    public interface IChannelInfo
    {
        int Id { get; set; }

        string ChannelName { get; set; }

        int SiteId { get; set; }

        string ContentModelPluginId { get; set; }

        string ContentRelatedPluginIds { get; set; }

        int ParentId { get; set; }

        string ParentsPath { get; set; }

        int ParentsCount { get; set; }

        int ChildrenCount { get; set; }

        bool IsLastNode { get; set; }

        string IndexName { get; set; }

        string GroupNameCollection { get; set; }

        int Taxis { get; set; }

        DateTime AddDate { get; set; }

        string ImageUrl { get; set; }

        string Content { get; set; }

        int ContentNum { get; set; }

        string FilePath { get; set; }

        string ChannelFilePathRule { get; set; }

        string ContentFilePathRule { get; set; }

        string LinkUrl { get; set; }

        string LinkType { get; set; }

        int ChannelTemplateId { get; set; }

        int ContentTemplateId { get; set; }

        string Keywords { get; set; }

        string Description { get; set; }

        IAttributes Attributes { get; }
    }
}
