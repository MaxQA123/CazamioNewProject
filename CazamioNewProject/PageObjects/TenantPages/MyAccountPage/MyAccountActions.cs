using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using System.Text.RegularExpressions;

namespace CazamioNewProject.PageObjects.TenantPages.MyAccountPage
{
    public partial class MyAccount
    {
        [AllureStep("GetApplicationId")]
        public string GetApplicationId()
        {
            WaitUntil.WaitSomeInterval(100);
            string applicationIdText = ApplicationIdStringAndValueFromFrstRw.Text;
            Regex regexOnlyApplicationIdNumber = new Regex(@"(\d+)");
            string onlyApplicationIdNumber = regexOnlyApplicationIdNumber.Match(applicationIdText).ToString();

            return onlyApplicationIdNumber;
        }

        [AllureStep("GetApplicationId")]
        public string GetApplicationIdDemo()
        {
            WaitUntil.WaitSomeInterval(100);

            // Получаем текст, содержащий Application ID
            string applicationIdText = ApplicationIdStringAndValueFromFrstRw.Text;

            // Создаем регулярное выражение для поиска цифр после #
            Regex regex = new Regex(@"#(\d+)");

            // Ищем совпадение
            Match match = regex.Match(applicationIdText);

            // Если совпадение найдено, возвращаем цифры
            if (match.Success)
            {
                return match.Groups[1].Value; // Группа 1 содержит только цифры
            }

            // Если совпадение не найдено, возвращаем пустую строку или выбрасываем исключение
            return string.Empty;
        }
    }
}
