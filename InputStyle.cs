using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteServer.Plugin
{
    /// <summary>
    /// 表单的提交样式。
    /// </summary>
    public class InputStyle
    {
        /// <summary>
        /// 表单的字段名称。
        /// </summary>
        public string AttributeName { get; set; }

        /// <summary>
        /// 表单的输入类型。
        /// </summary>
        public InputType InputType { get; set; }

        /// <summary>
        /// 表单的显示名称。
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// 是否必填项。
        /// </summary>
        public bool IsRequired { get; set; }

        /// <summary>
        /// 表单的默认值。
        /// </summary>
        public string DefaultValue { get; set; }
    }
}
