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
        private readonly string connectionString = "Server=(localdb)\\mssqllocaldb;Database=testDatabase;Trusted_Connection=True;";

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
                            result.Add(new Category()
                            {
                                Id = reader.GetInt32(0),
                                CategoryId = reader.GetInt32(0), Name = reader.GetString(1).Trim()
                            });
                        }
                    }
                    connection.Close();
                }
            }
            return result;
        }

        public Main GetMain()
        {
            var points = new List<Point>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "select * from Point";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            points.Add(new Point()
                            {
                                Id = reader.GetInt32(0),
                                Address = reader.GetString(1).Trim(),
                                Phone = reader.GetString(2).Trim(),
                                Description = reader.GetString(3).Trim(),
                                BusinessHours = reader.GetString(4).Trim(),
                                Lat = reader.GetDouble(5),
                                Lon = reader.GetDouble(6),
                                AvailableCategories = new List<Category>()
                            });
                        }
                    }
                    connection.Close();
                }
            }
            for (int i = 0; i < points.Count; i++) {
                var result = new List<Category>();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "select c.* from Category c join PointCategory pc on pc.categoryId = c.Id and pc.pointId = @ID";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@ID", points[i].Id);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                result.Add(new Category()
                                {
                                    Id = reader.GetInt32(0),
                                    CategoryId = reader.GetInt32(0),
                                    Name = reader.GetString(1).Trim()
                                });
                            }
                        }
                        connection.Close();
                    }
                    points[i].AvailableCategories = result;
                }
            }

            return new Main() {
                Points = points,
                Categories = GetAllCategory()
            };
        }
        //public List<Category> GetCategoriesByPoint(int categoryId) {

        //}
    }
}
