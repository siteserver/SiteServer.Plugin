namespace SiteServer.Plugin
{
    public class TableColumn
    {
        public string AttributeName { get; set; }

        public string DataType { get; set; }

        public int DataLength { get; set; } = 50;

        public InputStyle InputStyle { get; set; }
    }
}
