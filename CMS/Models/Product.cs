using System;
using System.Collections.Generic;

#nullable disable

namespace CMS.Models
{
    public partial class Product
    {
        public int IdProduct { get; set; }
        public string Header { get; set; }
        public string Legend { get; set; }
        public string ArticleOneheader { get; set; }
        public string ArticleTwoheader { get; set; }
        public string ArticleThreeheader { get; set; }
        public string ArticleFourheader { get; set; }
        public string ArticleOneBody { get; set; }
        public string ArticleTwoBody { get; set; }
        public string ArticleThreeBody { get; set; }
        public string ArticleFourBody { get; set; }
    }
}
