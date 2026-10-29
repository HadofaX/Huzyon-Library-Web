using Microsoft.Data.SqlClient;
using Huzyon.Library.Models;
using System.Collections.Generic;
using System.Data;

namespace Huzyon.Library.DAL
{
    public class FavoriteDAL
    {
        private readonly string connectionString = DbConfig.ConnectionString;

        public List<Favorite> GetAllFavorites()
        {
            var favorites = new List<Favorite>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT CustomerID, ProductID, FavoriteDate, Price, FavoriteCount FROM Favorite_Table";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    favorites.Add(new Favorite
                    {
                        CustomerID = reader.GetInt32(0),
                        ProductID = reader.GetInt32(1),
                        FavoriteDate = reader.GetDateTime(2),
                        Price = reader.GetDecimal(3),
                        FavoriteCount = reader.GetInt32(4)
                    });
                }
            }

            return favorites;
        }
    }
}
