using CazamioNewProject.GuiHelpers;
using System;
using System.Data.SqlClient;

namespace CazamioNewProject.DbHelpers.BuildingsTable
{
    public class BuildingsDbRequests
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

        public class Buildings
        {
            public static BuildingsDbModels GetBuildingIdNineNineNineEightSaintJohnsonPlace()
            {
                var row = new BuildingsDbModels();

                string query = "SELECT Id" +
                       " FROM Buildings" +
                       " WHERE MarketplaceId = '15' AND AddressId IN" +
                       " (SELECT TOP 1 Id FROM Addresses WHERE Street = '9998 Saint Johnson Place' ORDER BY Id DESC)";
                try
                {
                    using SqlConnection connection = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB);
                    using SqlCommand command = new(query, connection);
                    connection.Open();

                    using SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        row.AddressId = GetValueOrDefault<long>(reader, 0);
                    }

                }
                catch (Exception ex)
                {
                    throw new ArgumentException($"Error: {ex.Message}\r\n{ex.StackTrace}");
                }
                finally
                {

                    SqlConnection.ClearAllPools();
                }

                return row;
            }

            public static BuildingsDbModels GetBuildingIdThirtyDashTrirtyNineCrownSt()
            {
                var row = new BuildingsDbModels();

                string query = "SELECT Id" +
                       " FROM Buildings" +
                       " WHERE MarketplaceId = '15' AND AddressId IN" +
                       " (SELECT TOP 1 Id FROM Addresses WHERE Street = '30-39 Crown St' ORDER BY Id DESC)";
                try
                {
                    using SqlConnection connection = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB);
                    using SqlCommand command = new(query, connection);
                    connection.Open();

                    using SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        row.AddressId = GetValueOrDefault<long>(reader, 0);
                    }

                }
                catch (Exception ex)
                {
                    throw new ArgumentException($"Error: {ex.Message}\r\n{ex.StackTrace}");
                }
                finally
                {

                    SqlConnection.ClearAllPools();
                }

                return row;
            }

            public static BuildingsDbModels GetBuildingIdEast51stStreetPedestrianCrossing()
            {
                var row = new BuildingsDbModels();

                string query = "SELECT Id" +
                       " FROM Buildings" +
                       " WHERE MarketplaceId = '15' AND AddressId IN" +
                       " (SELECT TOP 1 Id FROM Addresses WHERE Street = '111A East 51st Street Pedestrian Crossing' ORDER BY Id DESC)";
                try
                {
                    using SqlConnection connection = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB);
                    using SqlCommand command = new(query, connection);
                    connection.Open();

                    using SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        row.AddressId = GetValueOrDefault<long>(reader, 0);
                    }

                }
                catch (Exception ex)
                {
                    throw new ArgumentException($"Error: {ex.Message}\r\n{ex.StackTrace}");
                }
                finally
                {

                    SqlConnection.ClearAllPools();
                }

                return row;
            }

            public static BuildingsDbModels GetBuildingIdGatesAvenue()
            {
                var row = new BuildingsDbModels();

                string query = "SELECT Id" +
                       " FROM Buildings" +
                       " WHERE MarketplaceId = '15' AND AddressId IN" +
                       " (SELECT TOP 1 Id FROM Addresses WHERE Street = '12867 Gates Avenue' ORDER BY Id DESC)";
                try
                {
                    using SqlConnection connection = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB);
                    using SqlCommand command = new(query, connection);
                    connection.Open();

                    using SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        row.AddressId = GetValueOrDefault<long>(reader, 0);
                    }

                }
                catch (Exception ex)
                {
                    throw new ArgumentException($"Error: {ex.Message}\r\n{ex.StackTrace}");
                }
                finally
                {

                    SqlConnection.ClearAllPools();
                }

                return row;
            }

            public static BuildingsDbModels GetBuildingIdOneTwoFiveSixSevenDeanStreet()
            {
                var row = new BuildingsDbModels();

                string query = "SELECT Id" +
                       " FROM Buildings" +
                       " WHERE MarketplaceId = '15' AND AddressId IN" +
                       " (SELECT TOP 1 Id FROM Addresses WHERE Street = '12567 Dean Street' ORDER BY Id DESC)";
                try
                {
                    using SqlConnection connection = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB);
                    using SqlCommand command = new(query, connection);
                    connection.Open();

                    using SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        row.AddressId = GetValueOrDefault<long>(reader, 0);
                    }

                }
                catch (Exception ex)
                {
                    throw new ArgumentException($"Error: {ex.Message}\r\n{ex.StackTrace}");
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
