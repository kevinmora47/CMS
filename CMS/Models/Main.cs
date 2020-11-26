using System;
using System.Collections.Generic;

#nullable disable

namespace CMS.Models
{
    public partial class Main
    {
        public int IdMain { get; set; }
        public string Header { get; set; }
        public string Legend { get; set; }
        public string TableTitle { get; set; }
        public string CategoryOne { get; set; }
        public string CategoryTwo { get; set; }
        public string CategoryThree { get; set; }
        public string CategoryFour { get; set; }
        public string CategoryOneValue { get; set; }
        public string CategoryTwoValue { get; set; }
        public string CategoryThreeValue { get; set; }
        public string CategoryFourValue { get; set; }
        public DateTime? Updated { get; set; }
    }
}
