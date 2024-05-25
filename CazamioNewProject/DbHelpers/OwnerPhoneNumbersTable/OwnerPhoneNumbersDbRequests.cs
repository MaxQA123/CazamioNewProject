using CazamioNewProject.GuiHelpers;
using System.Data;
using System.Data.SqlClient;

namespace CazamioNewProject.DbHelpers.OwnerPhoneNumbersTable
{
    public class OwnerPhoneNumbersDbRequests
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
        public class OwnerPhoneNumbers
        {
            public static string DeleteRecordAboutOwnerPhoneNumber(string email, int marketplaceId)
            {
                string data = null;
                using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
                {
                    SqlCommand command = new("DELETE" +
                               " FROM OwnerPhoneNumbers" +
                               " WHERE OwnerId IN" +
                               " (SELECT Id FROM Owners WHERE OwnerEmail = @OwnerEmail AND MarketplaceId = @MarketplaceId)", db);
                    command.Parameters.AddWithValue("@OwnerEmail", DbType.String).Value = email;
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
