using CazamioNewProject.GuiHelpers;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CazamioNewProject.DbHelpers.OwnersDbTable
{
    public class OwnersDbRequests
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

        public class DBOwners
        {
            public static string DeleteNewlyCreatedOwner(string email, int marketplaceId)
            {
                string data = null;
                using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
                {
                    db.Open();
                    SqlTransaction transaction = db.BeginTransaction(); // Начинаем транзакцию

                    try
                    {
                        // Удаление из таблицы OwnerCommissionsStructure
                        using (SqlCommand deleteCommissionsCommand = new(
                            "DELETE FROM OwnerCommissionsStructure " +
                            "WHERE OwnerId IN " +
                            "(SELECT Id FROM Owners WHERE OwnerEmail = @OwnerEmail AND MarketplaceId = @MarketplaceId)", db, transaction))
                        {
                            deleteCommissionsCommand.Parameters.AddWithValue("@OwnerEmail", email);
                            deleteCommissionsCommand.Parameters.AddWithValue("@MarketplaceId", marketplaceId);
                            deleteCommissionsCommand.ExecuteNonQuery();
                        }

                        // Удаление из таблицы OwnerPhoneNumbers
                        using (SqlCommand deletePhoneNumbersCommand = new(
                            "DELETE FROM OwnerPhoneNumbers " +
                            "WHERE OwnerId IN " +
                            "(SELECT Id FROM Owners WHERE OwnerEmail = @OwnerEmail AND MarketplaceId = @MarketplaceId)", db, transaction))
                        {
                            deletePhoneNumbersCommand.Parameters.AddWithValue("@OwnerEmail", email);
                            deletePhoneNumbersCommand.Parameters.AddWithValue("@MarketplaceId", marketplaceId);
                            deletePhoneNumbersCommand.ExecuteNonQuery();
                        }

                        // Удаление из таблицы OwnerManagements
                        using (SqlCommand deleteManagementsCommand = new(
                            "DELETE FROM OwnerManagements " +
                            "WHERE OwnerId IN " +
                            "(SELECT Id FROM Owners WHERE OwnerEmail = @OwnerEmail AND MarketplaceId = @MarketplaceId)", db, transaction))
                        {
                            deleteManagementsCommand.Parameters.AddWithValue("@OwnerEmail", email);
                            deleteManagementsCommand.Parameters.AddWithValue("@MarketplaceId", marketplaceId);
                            deleteManagementsCommand.ExecuteNonQuery();
                        }

                        // Удаление из таблицы Owners
                        using (SqlCommand deleteOwnerCommand = new(
                            "DELETE FROM Owners " +
                            "WHERE OwnerEmail = @OwnerEmail AND MarketplaceId = @MarketplaceId", db, transaction))
                        {
                            deleteOwnerCommand.Parameters.AddWithValue("@OwnerEmail", email);
                            deleteOwnerCommand.Parameters.AddWithValue("@MarketplaceId", marketplaceId);
                            int rowsAffected = deleteOwnerCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                data = "Owner and all related records deleted successfully.";
                            }
                            else
                            {
                                data = "No records found to delete.";
                            }
                        }

                        transaction.Commit(); // Подтверждаем транзакцию
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback(); // Откатываем транзакцию в случае ошибки
                        data = $"Error: {ex.Message}";
                    }
                }
                return data;
            }

            public static string GetMarketplaceIdByEmailUserOwner(string email)
            {
                string data = null;
                using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
                {
                    SqlCommand command = new("SELECT MarketplaceId" +
                               " FROM Owners" +
                               " WHERE OwnerEmail = @Email", db);
                    command.Parameters.AddWithValue("@Email", DbType.String).Value = email;
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
