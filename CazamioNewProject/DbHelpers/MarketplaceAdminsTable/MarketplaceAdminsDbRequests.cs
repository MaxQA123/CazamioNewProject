using CazamioNewProject.GuiHelpers;
using System;
using System.Data.SqlClient;

namespace CazamioNewProject.DbHelpers.MarketplaceAdminsTable
{
    public class MarketplaceAdminsDbRequests
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
        public class MarketplaceAdmins
        {
            public static string DeleteNewlyCreatedMarketplaceAdmin(string email, int marketplaceId)
            {
                string data = null;
                using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
                {
                    db.Open();
                    SqlTransaction transaction = db.BeginTransaction();

                    try
                    {
                        using (SqlCommand deleteAdminCommand = new(
                            "DELETE FROM MarketplaceAdmins " +
                            "WHERE UserId IN " +
                            "(SELECT Id FROM AspNetUsers WHERE Email = @Email AND MarketplaceId = @MarketplaceId)", db, transaction))
                        {
                            deleteAdminCommand.Parameters.AddWithValue("@Email", email);
                            deleteAdminCommand.Parameters.AddWithValue("@MarketplaceId", marketplaceId);
                            deleteAdminCommand.ExecuteNonQuery();
                        }

                        using (SqlCommand deleteUserCommand = new(
                            "DELETE FROM AspNetUsers " +
                            "WHERE Email = @Email AND MarketplaceId = @MarketplaceId", db, transaction))
                        {
                            deleteUserCommand.Parameters.AddWithValue("@Email", email);
                            deleteUserCommand.Parameters.AddWithValue("@MarketplaceId", marketplaceId);
                            int rowsAffected = deleteUserCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                data = "User and admin records deleted successfully.";
                            }
                            else
                            {
                                data = "No records found to delete.";
                            }
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        data = $"Error: {ex.Message}";
                    }
                }
                return data;
            }
        }
    }
}
