﻿using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using System;
using System.Data.SqlClient;

namespace CazamioNewProject.DbHelpers.ApartmentsTable
{
    public class DemoDbRequests
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
            public static DemoDbModels GetBuildingByAddressDetails()
            {
                Building building = Building.Generate();
                var row = new DemoDbModels();

                string query = @"
                       SELECT TOP 1 B.Id
                       FROM Buildings B
                       JOIN Addresses A ON B.AddressId = A.Id
                       WHERE B.MarketplaceId = @marketplaceId
                       AND A.Street = @street
                       AND A.City = @city
                       AND A.State = @state
                       AND (A.Neighborhood = @neighborhood OR @neighborhood IS NULL OR @neighborhood = '')
                       AND (A.ZipCode = @zipCode OR @zipCode IS NULL OR @zipCode = '')
                       ORDER BY B.Id DESC";

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
        }
    }
}
