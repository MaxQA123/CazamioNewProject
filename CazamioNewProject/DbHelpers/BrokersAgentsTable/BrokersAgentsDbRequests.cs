using CazamioNewProject.GuiHelpers;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CazamioNewProject.DbHelpers.BrokersAgentsTable
{
    public class BrokersAgentsDbRequests
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

        public class BrokersAgents
        {
            public static BrokersAgentsDbModelsCombined GetAgentBasicData(string email)
            {
                var row = new BrokersAgentsDbModelsCombined();

                // SQL запрос для выборки данных
                string query = "SELECT AspnetUsers.FirstName, AspnetUsers.LastName, AspnetUsers.Email, Brokers.BrokerCommission, Brokers.AgentCommission" +
                       " FROM Brokers LEFT JOIN AspNetUsers" +
                       " ON Brokers.UserId = AspNetUsers.Id" +
                       " WHERE Brokers.UserId IN(SELECT Id FROM AspNetUsers WHERE Email = @email)";
                try
                {
                    using SqlConnection connection = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB);
                    using SqlCommand command = new(query, connection);
                    connection.Open();

                    // Параметризованный запрос с двумя параметрами
                    command.Parameters.AddWithValue("@email", DbType.String).Value = email;

                    using SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        row.FirstName = GetValueOrDefault<string>(reader, 0);
                        row.LastName = GetValueOrDefault<string>(reader, 1);
                        row.Email = GetValueOrDefault<string>(reader, 2);
                        row.BrokerCommission = GetValueOrDefault<decimal>(reader, 3);
                        row.AgentCommission = GetValueOrDefault<decimal>(reader, 4);
                    }

                }
                catch (Exception ex)
                {
                    throw new ArgumentException($"Error: {ex.Message}\r\n{ex.StackTrace}");
                }
                finally
                {

                    // Обеспечиваем освобождение ресурсов
                    SqlConnection.ClearAllPools();
                }

                return row;
            }

            public static string DeleteNewlyCreatedAgent(string email, int marketplaceId)
            {
                string data = null;
                using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
                {
                    db.Open();
                    SqlTransaction transaction = db.BeginTransaction(); // Начинаем транзакцию

                    try
                    {
                        // Удаление из таблицы Brokers
                        using (SqlCommand deleteAgentCommand = new(
                            "DELETE FROM Brokers " +
                            "WHERE UserId IN " +
                            "(SELECT Id FROM AspNetUsers WHERE Email = @Email AND MarketplaceId = @MarketplaceId)", db, transaction))
                        {
                            deleteAgentCommand.Parameters.AddWithValue("@Email", email);
                            deleteAgentCommand.Parameters.AddWithValue("@MarketplaceId", marketplaceId);
                            deleteAgentCommand.ExecuteNonQuery();
                        }

                        // Удаление из таблицы AspNetUsers
                        using (SqlCommand deleteUserCommand = new(
                            "DELETE FROM AspNetUsers " +
                            "WHERE Email = @Email AND MarketplaceId = @MarketplaceId", db, transaction))
                        {
                            deleteUserCommand.Parameters.AddWithValue("@Email", email);
                            deleteUserCommand.Parameters.AddWithValue("@MarketplaceId", marketplaceId);
                            int rowsAffected = deleteUserCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                data = "Agent and user records deleted successfully.";
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
        }
    }
}
