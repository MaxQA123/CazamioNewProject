﻿using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using NUnit.Allure.Attributes;
using System.Text.RegularExpressions;

namespace CazamioNewProject.PageObjects.AdminPages.ApartmentViewPage
{
    public partial class ApartmentView
    {
        TenantCreatorMySpace tenantCreatorMySpace = TenantCreatorMySpace.Generate();

        #region Tabs

        [AllureStep("ClickTabApplications")]
        public ApartmentView ClickTabApplications()
        {
            WaitUntil.CustomElementIsVisible(TabApplications);
            Button.Click(TabApplications);

            return this;
        }

        #endregion

        #region Apartment view

        [AllureStep("GetFullEmailFromGetApplicationLinkField")]
        public string GetFullEmailFromGetApplicationLinkField()
        {
            WaitUntil.CustomElementIsVisible(FieldInputGetApplicationLink);
            string fullEmail = FieldInputGetApplicationLink.GetAttribute("value");

            return fullEmail;
        }

        [AllureStep("GetFirstNameFromFieldFirstName")]
        public string GetFirstNameFromFieldFirstName()
        {
            WaitUntil.CustomElementIsVisible(FieldInputFirstName);
            string firstName = FieldInputFirstName.GetAttribute("value");

            return firstName;
        }

        [AllureStep("GetLastNameFromFieldLastName")]
        public string GetLastNameFromFieldLastName()
        {
            WaitUntil.CustomElementIsVisible(FieldInputLastName);
            string LastName = FieldInputLastName.GetAttribute("value");

            return LastName;
        }

        [AllureStep("GetSubjectWithoutAgentSaintJohnsonPlace")]
        public string GetSubjectWithoutAgentSaintJohnsonPlace()
        {
            WaitUntil.WaitSomeInterval(1000);
            // Получение текста уведомления из EmailNotifications
            string subjectNotification = EmailNotifications.Generate().SubjectsCreateTenantPlusApp.CreateTenantViaGetLinkWithoutAgentSaintJohnsonPlace;
            string unitNumberAc = Pages.BuildingApartmentsTbl.GetVlOfClmnUnitFrstRw();

            // Замена номера квартиры в subjectNotification
            string updatedText = ReplaceUnitNumber(subjectNotification, unitNumberAc);

            // Возвращение обновленного текста
            return updatedText;
        }

        [AllureStep("GetSubjectWithAgentBrokerSaintJohnsonPlace")]
        public string GetSubjectWithAgentBrokerSaintJohnsonPlace()
        {
            WaitUntil.WaitSomeInterval(1000);

            string subjectNotification = EmailNotifications.Generate().SubjectsCreateTenantPlusApp.CreateTenantViaGetLinkWithAgentBrokerSaintJohnsonPlace;
            string unitNumberAc = Pages.BuildingApartmentsTbl.GetVlOfClmnUnitFrstRw();

            // Используем Regex для замены числа после #
            string updatedText = Regex.Replace(subjectNotification, @"#\d+", "#" + unitNumberAc);

            return updatedText;
        }

        [AllureStep("GetSubjectWithoutAgentDeanStreet")]
        public string GetSubjectWithoutAgentDeanStreet()
        {
            WaitUntil.WaitSomeInterval(1000);
            string subjectNotification = EmailNotifications.Generate().SubjectsCreateTenantPlusApp.CreateTenantOccupantViaPlusAppWithoutAgentDeanStreet;
            string unitNumberAc = Pages.BuildingApartmentsTbl.GetVlOfClmnUnitFrstRw();

            string updatedText = ReplaceUnitNumber(subjectNotification, unitNumberAc);

            return updatedText;
        }

        [AllureStep("GetSubjectWithoutAgentAlbermaleRd")]
        public string GetSubjectWithoutAgentAlbermaleRd()
        {
            WaitUntil.WaitSomeInterval(1000);
            string subjectNotification = EmailNotifications.Generate().SubjectsCreateTenantPlusApp.CreateTenantViaGetLinkWithoutAgentAlbermaleRd;
            string unitNumberAc = Pages.BuildingApartmentsTbl.GetVlOfClmnUnitFrstRw();

            string updatedText = ReplaceUnitNumber(subjectNotification, unitNumberAc);

            return updatedText;
        }

        private static string ReplaceUnitNumber(string subjectNotification, string unitNumber)
        {
            // Замена номера квартиры в тексте
            string updatedText = Regex.Replace(subjectNotification, @"(?<=#)\d+", unitNumber);

            return updatedText;
        }

        [AllureStep("GetSubjectWithAgentWashingtonSquare")]
        public string GetSubjectWithAgentWashingtonSquare()
        {
            WaitUntil.WaitSomeInterval(1000);

            string subjectNotification = EmailNotifications.Generate().SubjectsCreateTenantPlusApp.CreateTenantViaPlusAppWithAgentWashingtonSquare;
            string unitNumberAc = Pages.BuildingApartmentsTbl.GetVlOfClmnUnitFrstRw();

            string updatedText = ReplaceLastUnitNumber(subjectNotification, unitNumberAc);

            return updatedText;
        }

        private static string ReplaceLastUnitNumber(string subjectNotification, string unitNumber)
        {
            string updatedText = Regex.Replace(subjectNotification, @"(?<=#)\w{2}(?=\.)", unitNumber);

            return updatedText;
        }

        [AllureStep("CopyEmailBeforeDogFromFieldGetApplicationLink")]
        public string CopyEmailBeforeDogFromFieldGetApplicationLink()
        {
            KeyBoardActions.ClickArrowDown();
            WaitUntil.WaitSomeInterval(500);
            string copyPartEmail = FieldInputGetApplicationLink.GetAttribute("value");
            Regex regexPartEmail = new Regex(@"^.........................");
            string partEmail = regexPartEmail.Match(copyPartEmail).ToString();

            return partEmail;
        }

        [AllureStep("CopyEmailBeforeDogFromGetApplicationLink")]
        public string CopyEmailBeforeDogFromGetApplicationLink()
        {
            KeyBoardActions.ClickArrowDown();
            WaitUntil.WaitSomeInterval(500);
            string copyPartEmail = FieldInputGetApplicationLink.GetAttribute("value");
            Regex regexPartEmail = new Regex(@"^..................");
            string partEmail = regexPartEmail.Match(copyPartEmail).ToString();

            return partEmail;
        }

        [AllureStep("GetLeasePriceValueOfString")]
        public string GetLeasePriceValueOfString()
        {
            WaitUntil.CustomElementIsVisible(LeasePriceValueOfString);
            WaitUntil.WaitSomeInterval(2000);
            string leasePrice = LeasePriceValueOfString.Text;

            return leasePrice;
        }

        [AllureStep("EnterRandomEmailGetApplicationLink")]
        public ApartmentView EnterRandomEmailGetApplicationLink()
        {
            WaitUntil.CustomElementIsVisible(FieldInputGetApplicationLink);
            InputGeneral.InputFunctionWithClear(FieldInputGetApplicationLink, tenantCreatorMySpace.Emails.RandomMainApplicantEmail);

            return this;
        }

        [AllureStep("EnterExistEmailWithCreditReporGetApplicationLink")]
        public ApartmentView EnterExistEmailWithCreditReporGetApplicationLink()
        {
            WaitUntil.CustomElementIsVisible(FieldInputGetApplicationLink);
            InputGeneral.InputFunctionWithClear(FieldInputGetApplicationLink, tenantCreatorMySpace.CreatedWithCreditReport.Email);

            return this;
        }

        [AllureStep("EnterExistEmailWithCreditReporGetApplicationLink")]
        public ApartmentView EnterExistEmailWithoutCreditReporGetApplicationLink()
        {
            WaitUntil.CustomElementIsVisible(FieldInputGetApplicationLink);
            InputGeneral.InputFunctionWithClear(FieldInputGetApplicationLink, tenantCreatorMySpace.CreatedWithoutCreditReport.Email);

            return this;
        }

        [AllureStep("ClickButtonGetLink")]
        public ApartmentView ClickButtonGetLink()
        {
            WaitUntil.CustomElementIsVisible(ButtonGetLink);
            Button.Click(ButtonGetLink);
            Pages.ToasterMessagesLandlord
                .VerifyMessageCopiedTheLinkToApplication();

            return this;
        }

        [AllureStep("ClickButtonPlusApplication")]
        public ApartmentView ClickButtonPlusApplication()
        {
            WaitUntil.CustomElementIsVisible(ButtonPlusApplication);
            Button.Click(ButtonPlusApplication);

            return this;
        }

        [AllureStep("EnterFieldInputFirstName")]
        public ApartmentView EnterFieldInputFirstName()
        {
            WaitUntil.CustomElementIsVisible(FieldInputFirstName);
            InputGeneral.InputFunctionWithClear(FieldInputFirstName, tenantCreatorMySpace.FirstLastNameGeneralData.RandomFirstName);

            return this;
        }

        [AllureStep("EnterFieldInputLastName")]
        public ApartmentView EnterFieldInputLastName()
        {
            WaitUntil.CustomElementIsVisible(FieldInputLastName);
            InputGeneral.InputFunctionWithClear(FieldInputLastName, tenantCreatorMySpace.FirstLastNameGeneralData.RandomLastName);

            return this;
        }

        #endregion
    }
}
