using CazamioNewProject.GuiHelpers;
using System;
using System.Data.SqlClient;

namespace CazamioNewProject.DbHelpers.ApartmentsTable
{
    public class ApartmentsDbRequests
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

        public class ApartmentsDbTable
        {
            public static ApartmentsDbModels GetLastApartmentId()
            {
                var row = new ApartmentsDbModels();

                string query = @"
                       SELECT TOP 1 *
                       FROM Apartments Apart
                       LEFT JOIN Buildings B ON Apart.BuildingId = B.Id
                       LEFT JOIN Addresses Addrss ON Addrss.Id = B.AddressId
                       WHERE Addrss.Street = @street 
                         AND Addrss.City = @city 
                         AND Addrss.State = @state
                         AND (Addrss.Neighborhood = @neighborhood OR @neighborhood IS NULL OR @neighborhood = '') 
                         AND (Addrss.ZipCode = @zipCode OR @zipCode IS NULL OR @zipCode = '') 
                         AND B.MarketplaceId = @marketplaceId
                       ORDER BY Apart.CreationDate DESC";
                       
                try
                {
                    using SqlConnection connection = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB);
                    using SqlCommand command = new(query, connection);

                    // Add parameters
                    command.Parameters.AddWithValue("@marketplaceId", 15);
                    command.Parameters.AddWithValue("@street", "12567 Dean Street");
                    command.Parameters.AddWithValue("@city", "Brooklyn");
                    command.Parameters.AddWithValue("@state", "NY");
                    command.Parameters.AddWithValue("@neighborhood", "Prospect Heights");
                    command.Parameters.AddWithValue("@zipCode", "11238");

                    connection.Open();

                    using SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        row.Id = GetValueOrDefault<long>(reader, 0);
                    }
                }
                catch (Exception ex)
                {
                    throw new ArgumentException($"Error retrieving building: {ex.Message}\r\n{ex.StackTrace}");
                }
                finally
                {
                    SqlConnection.ClearAllPools();
                }

                return row;
            }
        }
    }
}
