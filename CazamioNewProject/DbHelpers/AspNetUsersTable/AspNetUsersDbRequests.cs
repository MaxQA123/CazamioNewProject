using CazamioNewProject.GuiHelpers;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CazamioNewProject.DbHelpers.AspNetUsersTable
{
    public class AspNetUsersDbRequests
    {
        private static T GetValueOrDefault<T>(SqlDataReader reader, int index, T defaultValue = default(T))
        {
            if (!reader.IsDBNull(index))
            {
                return (T)reader.GetValue(index);
            }
            else
            {
                return defaultValue;
            }
        }

        public class AspNetUsers
        {
            public static AspNetUsersDbModels GetMarketplaceIdByEmailAndMarketplaceId(string email, int marketplaceId)
            {
                var row = new AspNetUsersDbModels();

                // SQL запрос для выборки данных
                string query = "SELECT MarketplaceId" +
                               " FROM AspNetUsers" +
                               " WHERE Email = @Email AND MarketplaceId = @MarketplaceId";
                try
                {
                    using SqlConnection connection = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB);
                    using SqlCommand command = new(query, connection);
                    connection.Open();

                    // Параметризованный запрос с двумя параметрами
                    command.Parameters.AddWithValue("@Email", DbType.String).Value = email;
                    command.Parameters.AddWithValue("@MarketplaceId", DbType.String).Value = marketplaceId;

                    using SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        row.MarketplaceId = GetValueOrDefault<long>(reader, 0);
                    }

                }
                catch (Exception ex)
                {
                    throw new ArgumentException($"Error: {ex.Message}\r\n{ex.StackTrace}");
                }
                finally
                {

                    // Обеспечиваем освобождение ресурсов
                    SqlConnection.ClearAllPools();
                }

                return row;
            }

            public static string GetEmailByEmailAndMarketplaceId(string email, int marketplaceId)
            {
                string data = null;
                using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
                {
                    SqlCommand command = new("SELECT Email" +
                               " FROM AspNetUsers" +
                               " WHERE Email = @Email AND MarketplaceId = @MarketplaceId", db);
                    command.Parameters.AddWithValue("@Email", DbType.String).Value = email;
                    command.Parameters.AddWithValue("@MarketplaceId", DbType.String).Value = marketplaceId;
                    db.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            data = reader.GetValue(0).ToString();
                        }
                    }
                }
                return data;
            }

            public static string DeleteCreatedUser(string email, int marketplaceId)
            {
                string data = null;
                using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
                {
                    SqlCommand command = new("DELETE" +
                               " FROM AspNetUsers" +
                               " WHERE Email = @Email AND MarketplaceId = @MarketplaceId", db);
                    command.Parameters.AddWithValue("@Email", DbType.String).Value = email;
                    command.Parameters.AddWithValue("@MarketplaceId", DbType.String).Value = marketplaceId;
                    db.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            data = reader.GetValue(0).ToString();
                        }
                    }
                }
                return data;
            }
        }
    }
}
