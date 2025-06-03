using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using System;
using System.Data.SqlClient;

namespace CazamioNewProject.DbHelpers.Marketplaces
{
    public class MarketplacesDbRequests
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

        public class MarketplacesDbTable
        {
            public static string GetBrandByMarketplaceMySpace()
            {
                BasicDataForProject basicDataForProject = BasicDataForProject.Generate();

                string query = @"SELECT Brand FROM Marketplaces WHERE Subdomain = @subdomain";

                try
                {
                    using SqlConnection connection = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB);
                    using SqlCommand command = new(query, connection);

                    command.Parameters.AddWithValue("@subdomain", basicDataForProject.SubdomainMarketplace.MySpace);
                    connection.Open();

                    object result = command.ExecuteScalar();
                    return result?.ToString();
                }
                catch (Exception ex)
                {
                    throw new ArgumentException($"Error retrieving marketplace brand: {ex.Message}\r\n{ex.StackTrace}");
                }
                finally
                {
                    SqlConnection.ClearAllPools();
                }
            }

            public static bool UpdateBrandForMarketplaceMySpace()
            {
                BasicDataForProject basicDataForProject = BasicDataForProject.Generate();

                string query = @"
                               UPDATE Marketplaces 
                               SET Brand = @newBrand 
                               WHERE Subdomain = @subdomain";
                try
                {
                    using SqlConnection connection = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB);
                    using SqlCommand command = new(query, connection);

                    command.Parameters.AddWithValue("@newBrand", basicDataForProject.SettingsMarketplaceMySpace.BrandNameFirst);
                    command.Parameters.AddWithValue("@subdomain", basicDataForProject.SubdomainMarketplace.MySpace);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    // Return true if at least one row was updated
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    throw new ArgumentException($"Error updating marketplace brand: {ex.Message}\r\n{ex.StackTrace}");
                }
                finally
                {
                    SqlConnection.ClearAllPools();
                }
            }
        }
    }
}
