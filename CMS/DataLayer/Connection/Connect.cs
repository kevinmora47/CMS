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

        public async Task GetConnectionAsync(Models.User user)
        {
            using (SqlConnection sql = new SqlConnection("Server=DESKTOP-L73GDJC\\SQLEXPRESS;Database=CMS;Trusted_Connection=True;"))
            {
                using (SqlCommand cmd = new SqlCommand("ValidateUser", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", user.username);
                    cmd.Parameters.AddWithValue("@pass", user.pass);
                    await sql.OpenAsync();
                    int result = 0;

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            result = Convert.ToInt32(reader["result"]);
                        }
                    }
                }
            }
        }
    }
}