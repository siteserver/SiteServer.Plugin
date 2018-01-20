using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace SiteServer.Plugin
{
    public class InputStyle
    {
        public InputType InputType { get; set; }

        public string DisplayName { get; set; }

        public string HelpText { get; set; }

        public List<ListItem> ListItems { get; set; }

        public string DefaultValue { get; set; }

        public bool IsRequired { get; set; }

        public ValidateType ValidateType { get; set; }

        public int MinNum { get; set; }

        public int MaxNum { get; set; }

        public string RegExp { get; set; }

        public string Width { get; set; }

        public string Height { get; set; }
    }
}
