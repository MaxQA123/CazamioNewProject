using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using System.Text.RegularExpressions;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfApplicationsApplicationsTbls
{
    public partial class ListOfApplicationsApplicationsTbl
    {
        [AllureStep("GetApplicationIdFromFirstRow")]
        public string GetApplicationIdFromFirstRow()
        {
            WaitUntil.CustomElementIsVisible(VlIdOfClmnApplicationIdFrstRw);
            string apartmentAddress = VlIdOfClmnApplicationIdFrstRw.Text;

            return apartmentAddress;
        }

        [AllureStep("GetApartmentAddressFromFirstRow")]
        public string GetApartmentAddressFromFirstRow()
        {
            WaitUntil.CustomElementIsVisible(VlOfClmnApartmentFirstRow);
            string apartmentAddress = VlOfClmnApartmentFirstRow.Text;

            return apartmentAddress;
        }

        [AllureStep("GetFullNameTenantMainApplicantFromFirstRow")]
        public string GetFullNameTenantMainApplicantFromFirstRow()
        {
            WaitUntil.CustomElementIsVisible(VlMainApplicantOfClmnApplicantsFrstRw);
            string apartmentAddress = VlMainApplicantOfClmnApplicantsFrstRw.Text;

            return apartmentAddress;
        }

        [AllureStep("GetFullNameTenantOccupantFromFirstRow")]
        public string GetFullNameTenantOccupantFromFirstRow()
        {
            WaitUntil.CustomElementIsVisible(VlOccupantOfClmnApplicantsFrstRw);
            string apartmentAddress = VlOccupantOfClmnApplicantsFrstRw.Text;

            return apartmentAddress;
        }

        [AllureStep("GetPriceFromFirstRow")]
        public string GetPriceFromFirstRow()
        {
            WaitUntil.CustomElementIsVisible(VlOfClmnPriceFrstRw);
            string price = VlOfClmnPriceFrstRw.Text;

            return price;
        }

        [AllureStep("GetDateCreatedFromFirstRow")]
        public string GetDateCreatedFromFirstRow()
        {
            WaitUntil.WaitSomeInterval(500);
            string getFirstName = VlOfClmnCreatedOnFrstRw.Text;
            Regex regexGetFirstName = new Regex(@"^.{1,10}");
            string firstName = regexGetFirstName.Match(getFirstName).ToString();

            return firstName;
        }

        [AllureStep("GetAgentFromFrstRw")]
        public string GetAgentFromFrstRw()
        {
            WaitUntil.CustomElementIsVisible(VlOfClmnAgentFrstRw);
            string agent = VlOfClmnAgentFrstRw.Text;

            return agent;
        }
    }
}
