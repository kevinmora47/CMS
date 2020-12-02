using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Models
{
    public class User
    {
        [Key()]
        public int iduser { get; set; }
        public string username { get; set; }
        public string pass { get; set; }
    }
}
