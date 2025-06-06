﻿using CazamioNewProject.GuiHelpers; // Вспомогательные утилиты проекта
using CazamioNewProject.Objects;   // Модели данных
using System;
using System.Data.SqlClient;      // Работа с SQL Server

namespace CazamioNewProject.DbHelpers.ApartmentsTable
{
    public class DemoDbRequests
    {
        //DemoDbModels
        // Универсальный метод: безопасно получает значение из SqlDataReader
        // Если ячейка NULL — возвращает defaultValue (по умолчанию null или 0)
        private static T GetValueOrDefault<T>(SqlDataReader reader, int index, T defaultValue = default(T))
        {
            if (!reader.IsDBNull(index))
            {
                return (T)reader.GetValue(index); // Если есть значение — возвращаем приведённое
            }
            else
            {
                return defaultValue; // Иначе возвращаем значение по умолчанию
            }
        }

        public class TableNameDbTable
        {
            // Метод: возвращает полную строку из таблицы Marketplaces по поддомену "MySpace"
            public static DemoDbModels GetFullDataByMarketplaceMySpace()
            {
                // Получение тестовых/предустановленных данных, включая поддомен "MySpace"
                BasicDataForProject basicDataForProject = BasicDataForProject.Generate();

                // Объект модели, в который будут записаны значения из БД
                var row = new DemoDbModels();

                // SQL-запрос на выборку всех колонок, где Subdomain = нужный
                string query = @"
                               SELECT *
                               FROM Marketplaces
                               WHERE Subdomain = @subdomain";

                try
                {
                    // Открытие соединения с БД по строке подключения
                    using SqlConnection connection = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB);

                    // Подготовка команды SQL
                    using SqlCommand command = new(query, connection);

                    // Передаём значение параметра @subdomain
                    command.Parameters.AddWithValue("@subdomain", basicDataForProject.SubdomainMarketplace.MySpace);

                    // Открываем подключение
                    connection.Open();

                    // Выполняем запрос и читаем результат
                    using SqlDataReader reader = command.ExecuteReader();

                    // Если строка найдена
                    if (reader.Read())
                    {
                        // Последовательно заполняем поля модели
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
                    // Если произошла ошибка при работе с БД — кидаем исключение с подробностями
                    throw new ArgumentException($"Error retrieving marketplace data: {ex.Message}\r\n{ex.StackTrace}");
                }
                finally
                {
                    // Очищаем все SQL-пулы соединений — на случай зависших подключений
                    SqlConnection.ClearAllPools();
                }

                // Возвращаем объект с полученными из БД значениями
                return row;
            }
        }
    }
}
