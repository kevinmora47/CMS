using System;
using System.Collections.Generic;

#nullable disable

namespace CMS.Models
{
    public partial class Header
    {
        public int IdHeader { get; set; }
        public string CompanyName { get; set; }
        public string LegendName { get; set; }
        public string SubLegendName { get; set; }
        public string Plans { get; set; }
    }
}
