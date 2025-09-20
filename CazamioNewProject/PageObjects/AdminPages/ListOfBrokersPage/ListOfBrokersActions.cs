using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfBrokersPage
{
    public partial class ListOfBrokers
    {
        [AllureStep("Click button Create Broker on List of brokers page")]
        public ListOfBrokers ClickButtonCreateBroker()
        {
            WaitUntil.CustomElementIsVisible(ButtonCreateBroker);
            Button.Click(ButtonCreateBroker);

            return this;
        }

        [AllureStep("Copy first email record of broker in list")]
        public string CopyEmailFirstRecordEmailForFirstBrokerInList()
        {
            WaitUntil.WaitSomeInterval(500);
            string copyEmail = FirstRecordEmailForFirstBrokerInList.Text;
            string copyEmailActual = copyEmail.ToString();

            return copyEmailActual;
        }
    }
}
