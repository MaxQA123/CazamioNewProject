using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfBrokersPage
{
    public partial class ListOfBrokers
    {
        [AllureStep("Click Button Create Broker")]
        public ListOfBrokers ClickButtonCreateBroker()
        {
            WaitUntil.CustomElementIsVisible(ButtonCreateBroker);
            Button.Click(ButtonCreateBroker);

            return this;
        }

        [AllureStep("CopyEmailFirstRecordEmailForFirstBrokerInList")]
        public string CopyEmailFirstRecordEmailForFirstBrokerInList()
        {
            WaitUntil.WaitSomeInterval(500);
            string copyEmail = FirstRecordEmailForFirstBrokerInList.Text;
            string copyEmailActual = copyEmail.ToString();

            return copyEmailActual;
        }
    }
}
