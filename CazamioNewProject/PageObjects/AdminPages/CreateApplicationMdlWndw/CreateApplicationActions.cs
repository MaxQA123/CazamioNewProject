using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using NUnit.Allure.Attributes;
using System.Text.RegularExpressions;

namespace CazamioNewProject.PageObjects.AdminPages.CreateApplicationMdlWndw
{
    public partial class CreateApplicationMdlWndw
    {
        TenantCreatorMySpace tenantCreatorMySpace = TenantCreatorMySpace.Generate();
        Application application = Application.Generate();
        Apartment apartment = Apartment.Generate();
        Building building = Building.Generate();

        [AllureStep("GetFullEmail")]
        public string GetFullEmail()
        {
            WaitUntil.WaitSomeInterval(1000);
            WaitUntil.CustomElementIsVisible(VlFromStringLeadEmail);
            string fullEmail = VlFromStringLeadEmail.Text;

            return fullEmail;
        }

        [AllureStep("CopyEmailBeforeDogFromFieldGetApplicationLink")]
        public string CopyEmailBeforeDogFromFieldGetApplicationLink()
        {
            WaitUntil.WaitSomeInterval(2000);
            string copyPartEmail = VlFromStringLeadEmail.Text;
            Regex regexPartEmail = new Regex(@"^.........................");
            string partEmail = regexPartEmail.Match(copyPartEmail).ToString();

            return partEmail;
        }

        [AllureStep("GetFullEmailOnThirdStep")]
        public string GetFullEmailOnThirdStep()
        {
            WaitUntil.WaitSomeInterval(2000);
            string fullEmail = VlFromStringLeadEmail.Text;

            return fullEmail;
        }

        [AllureStep("GetApartmentShortAddress")]
        public string GetApartmentShortAddress()
        {
            WaitUntil.WaitSomeInterval(2000);
            string address = VlFromBtnUnitAddress.GetAttribute("value");

            return address;
        }

        [AllureStep("ClickButtonNext")]
        public CreateApplicationMdlWndw ClickButtonNext()
        {
            WaitUntil.WaitSomeInterval(2000);
            Button.Click(ButtonNext);

            return this;
        }

        [AllureStep("ClickButtonAddApplicant")]
        public CreateApplicationMdlWndw ClickButtonAddApplicant()
        {
            Button.Click(ButtonAddApplicant);

            return this;
        }

        [AllureStep("ClickButtonClose")]
        public CreateApplicationMdlWndw ClickButtonClose()
        {
            Button.Click(ButtonClose);

            return this;
        }

        [AllureStep("EnterEmailCreatedTenantCreatorWithCreditReportMySpace")]
        public CreateApplicationMdlWndw EnterEmailCreatedTenantCreatorWithCreditReportMySpace()
        {
            InputGeneral.InputFunctionWithClear(FieldInputMainApplicantEmailAddress, tenantCreatorMySpace.CreatedWithCreditReport.Email);

            return this;
        }

        [AllureStep("EnterEmailCreatedTenantCreatorWithoutCreditReportMySpace")]
        public CreateApplicationMdlWndw EnterEmailCreatedTenantCreatorWithoutCreditReportMySpace()
        {
            InputGeneral.InputFunctionWithClear(FieldInputMainApplicantEmailAddress, tenantCreatorMySpace.CreatedWithoutCreditReport.Email);

            return this;
        }

        [AllureStep("ClickUnitAddressFieldInput")]
        public CreateApplicationMdlWndw ClickUnitAddressFieldInput()
        {
            WaitUntil.CustomElementIsVisible(UnitAddressButton);
            Button.Click(UnitAddressButton);

            return this;
        }

        [AllureStep("EnterOneTwoEightSixSevenGatesAvenueAddress")]
        public CreateApplicationMdlWndw EnterOneTwoEightSixSevenGatesAvenueAddress()
        {
            WaitUntil.CustomElementIsVisible(UnitAddressButton);
            InputGeneral.InputFunctionWithClear(UnitAddressFieldInput, building.GatesAvenue.NumberNameAddressStaticForSearch);

            return this;
        }

        [AllureStep("EnterOneOneOneAEastStPedestrianCrossingAddress")]
        public CreateApplicationMdlWndw EnterOneOneOneAEastStPedestrianCrossingAddress()
        {
            WaitUntil.CustomElementIsVisible(UnitAddressButton);
            InputGeneral.InputFunctionWithClear(UnitAddressFieldInput, building.East51stStreetPedestrianCrossing.NumberNameAddressStaticForSearch);

            return this;
        }
    }
}
