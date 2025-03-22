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
            public static string DeleteNewlyCreatedBroker(string email, int marketplaceId)
            {
                string data = null;
                using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
                {
                    db.Open();

                    // Удаление из таблицы Landlords
                    using (SqlCommand deleteBrokerCommand = new(
                        "DELETE FROM Landlords " +
                        "WHERE UserId IN " +
                        "(SELECT Id FROM AspNetUsers WHERE Email = @Email AND MarketplaceId = @MarketplaceId)", db))
                    {
                        deleteBrokerCommand.Parameters.AddWithValue("@Email", email);
                        deleteBrokerCommand.Parameters.AddWithValue("@MarketplaceId", marketplaceId);
                        deleteBrokerCommand.ExecuteNonQuery(); // Выполняем удаление
                    }

                    // Удаление из таблицы AspNetUsers
                    using (SqlCommand deleteUserCommand = new(
                        "DELETE FROM AspNetUsers " +
                        "WHERE Email = @Email AND MarketplaceId = @MarketplaceId", db))
                    {
                        deleteUserCommand.Parameters.AddWithValue("@Email", email);
                        deleteUserCommand.Parameters.AddWithValue("@MarketplaceId", marketplaceId);
                        int rowsAffected = deleteUserCommand.ExecuteNonQuery(); // Выполняем удаление

                        // Если нужно вернуть данные о том, была ли удалена запись
                        if (rowsAffected > 0)
                        {
                            data = "Broker and user records deleted successfully.";
                        }
                        else
                        {
                            data = "No records found to delete.";
                        }
                    }
                }
                return data;
            }
        }
    }
}
