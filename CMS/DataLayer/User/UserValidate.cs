using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.DataLayer.User
{
    public class UserValidate
    {
        public bool ValidateUser(Models.User users)
        {
            using (Models.CMSContext db = new Models.CMSContext())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                return true;
            }
        }
    }
}
