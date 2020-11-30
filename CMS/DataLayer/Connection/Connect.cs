using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.DataLayer.Connection
{
    public class Connect
    {
        public string Connection { get; set; }

        public void GetConnection()
        {
            using (SqlConnection cmd = new SqlConnection())
            {                
            }      
	}
    }
}