using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using Huzyon.Library.Models;

namespace Huzyon.Library.DAL
{
    public class CategoryDAL
    {
        private readonly string connectionString = DbConfig.ConnectionString;

        public List<Category> GetAllCategories()
        {
            var categories = new List<Category>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT CategoryID, CategoryName FROM Category_Table";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var category = new Category
                    {
                        CategoryID = reader.GetInt32(0),
                        CategoryName = reader.GetString(1)
                    };
                    categories.Add(category);
                }
            }

            return categories;
        }
    }
}

