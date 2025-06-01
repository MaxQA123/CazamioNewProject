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
            public static MarketplacesDbModels GetFullDataByMarketplaceMySpace()
            {
                BasicDataForProject basicDataForProject = BasicDataForProject.Generate();
                var row = new MarketplacesDbModels();

                string query = @"
                               SELECT Brand
                               FROM Marketplaces
                               WHERE Subdomain = @subdomain";
                try
                {
                    using SqlConnection connection = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB);
                    using SqlCommand command = new(query, connection);

                    command.Parameters.AddWithValue("@subdomain", basicDataForProject.SubdomainMarketplace.MySpace);
                    connection.Open();

                    using SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        row.Id = GetValueOrDefault<long>(reader, 0);
                        row.Subdomain = GetValueOrDefault<string>(reader, 1);
                        row.CreationDate = GetValueOrDefault<DateTime?>(reader, 2);
                        row.ModifyDate = GetValueOrDefault<DateTime?>(reader, 3);
                        row.IsDeleted = GetValueOrDefault<bool?>(reader, 4);
                        row.FacebookUrl = GetValueOrDefault<string>(reader, 5);
                        row.TwitterUrl = GetValueOrDefault<string>(reader, 6);
                        row.YoutubeUrl = GetValueOrDefault<string>(reader, 7);
                        row.LinkedinUrl = GetValueOrDefault<string>(reader, 8);
                        row.InstagramUrl = GetValueOrDefault<string>(reader, 9);
                        row.TermsAndConditionsUrl = GetValueOrDefault<string>(reader, 10);
                        row.PrivacyPolicyUrl = GetValueOrDefault<string>(reader, 11);
                        row.ExternalDomain = GetValueOrDefault<string>(reader, 12);
                        row.Brand = GetValueOrDefault<string>(reader, 13);
                        row.Logo = GetValueOrDefault<string>(reader, 14);
                        row.ApplicationValidationSettings = GetValueOrDefault<string>(reader, 15);
                        row.DefaultHoldingDeposit = GetValueOrDefault<decimal?>(reader, 16);
                        row.DefaultPaymentKeyId = GetValueOrDefault<string>(reader, 17);
                        row.CreditScreeningProvider = GetValueOrDefault<string>(reader, 18);
                        row.FullName = GetValueOrDefault<string>(reader, 19);
                        row.OwnerName = GetValueOrDefault<string>(reader, 20);
                        row.PhoneNumber = GetValueOrDefault<string>(reader, 21);
                        row.Address = GetValueOrDefault<string>(reader, 22);
                        row.ZelleAddress = GetValueOrDefault<string>(reader, 23);
                        row.VenmoQRCode = GetValueOrDefault<string>(reader, 24);
                        row.DeliverCheckNote = GetValueOrDefault<string>(reader, 25);
                    }
                }
                catch (Exception ex)
                {
                    throw new ArgumentException($"Error retrieving marketplace data: {ex.Message}\r\n{ex.StackTrace}");
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
