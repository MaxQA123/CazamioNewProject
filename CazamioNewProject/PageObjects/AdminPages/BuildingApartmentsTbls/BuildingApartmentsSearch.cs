using CazamioNewProject.GuiHelpers;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.BuildingApartmentsTbls
{
    public partial class BuildingApartments
    {
        [FindsBy(How = How.XPath, Using = ("//table//tbody//tr"))]
        public IWebElement FirstRow;


        [FindsBy(How = How.XPath, Using = ("//table//tbody//tr//td[text() = 'Deposit Received']/ancestor::tr"))]
        public IWebElement DemoOne;

        public static IWebElement SetItemAgent()
        {

            // Использование переменной экземпляра owner для построения XPath
            var xpath = "//table//tbody//tr//td[text() = 'Deposit Received']/ancestor::tr";

            // Присвоение значения ItemForAutotestForBroker
            return Browser._Driver.FindElement(By.XPath(xpath));
        }

        public BuildingApartments SelectApartmentDepositReceived()
        {
            // Формируем XPath для поиска строки <tr>, содержащей ячейку <td> с текстом "Deposit Received"
            //var xpath = "//table//tbody//tr//td[text() = 'Deposit Received']/ancestor::tr";
            Button.Click(DemoOne);

            //try
            //{
            //    // Находим строку <tr>, содержащую текст "Deposit Received"
            //    var rowElement = Browser._Driver.FindElement(By.XPath(xpath));

            //    // Прокручиваем к строке, чтобы сделать её видимой
            //    ((IJavaScriptExecutor)Browser._Driver).ExecuteScript("arguments[0].scrollIntoView(true);", rowElement);

            //    // Ждём, чтобы строка стала кликабельной
            //    var wait = new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(10));
            //    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(rowElement));

            //    // Кликаем по строке
            //    rowElement.Click();

            //    Console.WriteLine("Row with status 'Deposit Received' clicked successfully.");
            //}
            //catch (Exception Ex)
            //{
            //    Console.WriteLine("Row with status 'Deposit Received' not found.");
            //    throw new Exception(Ex.Message); // Пробрасываем исключение для отчёта о сбое
            //}
            //catch (ElementClickInterceptedException)
            //{
            //    Console.WriteLine("Click on the row was intercepted. Check for overlapping elements.");
            //    throw new Exception("Click on the row was intercepted. Check for overlapping elements."); // Пробрасываем исключение для анализа
            //}

            return this; // Возвращаем текущий экземпляр для Fluent API
        }
    }
}
