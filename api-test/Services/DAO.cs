using api_test.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace api_test.Services
{
    public class DAO
    {
        private string connectionString = "Server=(localdb)\\mssqllocaldb;Database=testDatabase;Trusted_Connection=True;";

        public List<Category> GetAllCategory()
        {
            var result = new List<Category>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "select * from Category";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(new Category() { CategoryId = reader.GetInt32(0), Name = reader.GetString(1) });
                        }
                    }
                    connection.Close();
                }
            }
            return result;
        }
    }
}
