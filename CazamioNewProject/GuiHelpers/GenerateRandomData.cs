using System;
using System.Linq;

namespace CazamioNewProject.GuiHelpers
{
    public class GenerateRandomData
    {
        private static readonly Random _random = new Random();
        public static string GetRandomStreet()
        {
            string[] streets = { "Avenue A", "Bank Street", "Lincoln Place", "Hart Street", "West 126th Street" };

            int index = _random.Next(streets.Length);

            return streets[index];
        }

        public static string RandomPhoneNumber(int size)
        {
            Random random = new Random();
            const string chars = "1234567890";
            return new string(Enumerable.Repeat(chars, size)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string RandomNumberWithoutZero(int size)
        {
            Random random = new Random();
            const string chars = "123456789";
            return new string(Enumerable.Repeat(chars, size)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string RandomAlphabetUpperCase(int size)
        {
            Random random = new Random();
            const string chars = "QWERTYUIOPASDFGHJKLZXCVBNM";
            return new string(Enumerable.Repeat(chars, size)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string RandomNumberWithZero(int size)
        {
            Random random = new Random();
            const string chars = "1234567890";
            return new string(Enumerable.Repeat(chars, size)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string RandomNumberByDateTime()
        {
            //Get the current date and time with the format "MMddyyyyHHmm" 211220241234
            string dateTimeFormatted = DateTime.Now.ToString("MMddyyyyHHmm");

            return dateTimeFormatted;
        }

        public static string RandomEmail(int size)
        {
            Random random = new Random();
            const string chars = "qwertyuiopasdfghjklzxcvbnm";
            return new string(Enumerable.Repeat(chars, size)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string RandomCostRentMortgageCost(int size)
        {
            Random random = new Random();
            const string chars = "123456789";
            return new string(Enumerable.Repeat(chars, size)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string RandomPriceCreditScreeningFee(int size)
        {
            Random random = new Random();
            const string chars = "123456789";
            return new string(Enumerable.Repeat(chars, size)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string RandomPriceMinInteger(int size)
        {
            Random random = new Random();
            const string chars = "11";
            return new string(Enumerable.Repeat(chars, size)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
