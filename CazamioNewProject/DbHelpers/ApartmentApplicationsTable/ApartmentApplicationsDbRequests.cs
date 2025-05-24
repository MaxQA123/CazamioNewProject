using CazamioNewProject.DbHelpers.ApartmentApplicationsTable;
using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using System;
using System.Data.SqlClient;

namespace CazamioNewProject.DbHelpers.ApartmentsTable
{
    public class ApartmentApplicationsDbRequests
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

        public class ApartmentApplicationsDbTable
        {
            public static ApartmentApplicationsDbModels GetLastApartmentApplicationIdForOneTwoFiveSixSevenDeanStreet()
            {
                Building building = Building.Generate();
                var row = new ApartmentApplicationsDbModels();

                string query = @"
                       SELECT TOP 1 *
                      FROM ApartmentApplications
                      WHERE ApartmentId = (
                          SELECT TOP 1 Apart.Id
                          FROM Apartments Apart
                          LEFT JOIN Buildings B ON Apart.BuildingId = B.Id
                          LEFT JOIN Addresses Addrss ON Addrss.Id = B.AddressId
                          WHERE Addrss.Street = @street 
                            AND Addrss.City = @city 
                            AND Addrss.State = @state
                            AND (Addrss.Neighborhood = @neighborhood OR @neighborhood IS NULL OR @neighborhood = '') 
                            AND (Addrss.ZipCode = @zipCode OR @zipCode IS NULL OR @zipCode = '') 
                            AND B.MarketplaceId = @marketplaceId
                          ORDER BY Apart.CreationDate DESC
                      )
                      ORDER BY CreationDate DESC;";  
                try
                {
                    using SqlConnection connection = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB);
                    using SqlCommand command = new(query, connection);

                    // Add parameters
                    command.Parameters.AddWithValue("@marketplaceId", 15);
                    command.Parameters.AddWithValue("@street", building.DeanStreet.NumberNameAddressStaticForDb);
                    command.Parameters.AddWithValue("@city", building.DeanStreet.City);
                    command.Parameters.AddWithValue("@state", building.DeanStreet.State);
                    command.Parameters.AddWithValue("@neighborhood", building.DeanStreet.Neighborhood);
                    command.Parameters.AddWithValue("@zipCode", building.DeanStreet.Zip);

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

            public static ApartmentApplicationsDbModels GetLastApartmentApplicationIdForOneOneOneAEastStPerestrian()
            {
                Building building = Building.Generate();
                var row = new ApartmentApplicationsDbModels();

                string query = @"
                       SELECT TOP 1 *
                      FROM ApartmentApplications
                      WHERE ApartmentId = (
                          SELECT TOP 1 Apart.Id
                          FROM Apartments Apart
                          LEFT JOIN Buildings B ON Apart.BuildingId = B.Id
                          LEFT JOIN Addresses Addrss ON Addrss.Id = B.AddressId
                          WHERE Addrss.Street = @street 
                            AND Addrss.City = @city 
                            AND Addrss.State = @state
                            AND (Addrss.Neighborhood = @neighborhood OR @neighborhood IS NULL OR @neighborhood = '') 
                            AND (Addrss.ZipCode = @zipCode OR @zipCode IS NULL OR @zipCode = '') 
                            AND B.MarketplaceId = @marketplaceId
                          ORDER BY Apart.CreationDate DESC
                      )
                      ORDER BY CreationDate DESC;";
                try
                {
                    using SqlConnection connection = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB);
                    using SqlCommand command = new(query, connection);

                    // Add parameters
                    command.Parameters.AddWithValue("@marketplaceId", 15);
                    command.Parameters.AddWithValue("@street", building.East51stStreetPedestrianCrossing.NumberNameAddressStaticForDb);
                    command.Parameters.AddWithValue("@city", building.East51stStreetPedestrianCrossing.City);
                    command.Parameters.AddWithValue("@state", building.East51stStreetPedestrianCrossing.State);
                    command.Parameters.AddWithValue("@neighborhood", building.East51stStreetPedestrianCrossing.Neighborhood);
                    command.Parameters.AddWithValue("@zipCode", building.East51stStreetPedestrianCrossing.Zip);

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
