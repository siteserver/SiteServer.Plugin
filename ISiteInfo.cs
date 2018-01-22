namespace SiteServer.Plugin
{
    public interface ISiteInfo
    {
        int Id { get; set; }

        string SiteName { get; set; }

        string SiteDir { get; set; }

        string TableName { get; set; }

        bool IsRoot { get; set; }

        int ParentId { get; set; }

        int Taxis { get; set; }

        IAttributes Attributes { get; }
    }
}
