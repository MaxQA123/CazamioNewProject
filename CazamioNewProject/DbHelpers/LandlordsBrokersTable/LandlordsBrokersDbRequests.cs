using CazamioNewProject.GuiHelpers;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CazamioNewProject.DbHelpers.LandlordsBrokersTable
{
    public class LandlordsBrokersDbRequests
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
        public class LandlordsBrokers
        {
            public static string DeleteCreatedUserBroker(string email, int marketplaceId)
            {
                string data = null;
                using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
                {
                    SqlCommand command = new("DELETE" +
                               " FROM Landlords" +
                               " WHERE UserId IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = @Email AND MarketplaceId = @MarketplaceId)", db);
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
