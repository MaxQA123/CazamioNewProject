using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using NUnit.Allure.Attributes;
using System;
using System.Text.RegularExpressions;

namespace CazamioNewProject.PageObjects.AdminPages.ApartmentViewPage
{
    public partial class ApartmentView
    {
        Apartment apartment = Apartment.Generate();
        Application application = Application.Generate();
        EmailNotifications emailNotifications = EmailNotifications.Generate();
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

        [AllureStep("CopyEmailFromFieldGetApplicationLink")]
        public string CopyEmailFromFieldGetApplicationLink()
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

        [AllureStep("GetSubjectExpected")]
        public string GetSubjectExpected()
        {
            WaitUntil.WaitSomeInterval(1000);
            // Получение текста уведомления из EmailNotifications
            string subjectNotification = EmailNotifications.Generate().SubjectsTenantGeneral.CreateTenantViaGetLink;
            string unitNumberAc = Pages.BuildingApartmentsTbl.GetVlOfClmnUnitFrstRw();

            // Замена номера квартиры в subjectNotification
            string updatedText = ReplaceUnitNumber(subjectNotification, unitNumberAc);

            // Возвращение обновленного текста
            return updatedText;
        }

        private static string ReplaceUnitNumber(string subjectNotification, string unitNumber)
        {
            // Замена номера квартиры в тексте
            string updatedText = Regex.Replace(subjectNotification, @"(?<=#)\d+", unitNumber);

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

        [AllureStep("GetLeasePriceValueOfString")]
        public string GetLeasePriceValueOfString()
        {
            WaitUntil.CustomElementIsVisible(LeasePriceValueOfString);
            WaitUntil.WaitSomeInterval(2000);
            string leasePrice = LeasePriceValueOfString.Text;

            return leasePrice;
        }

        [AllureStep("EnterFieldInputFirstName")]
        public ApartmentView EnterFieldInputGetApplicationLink()
        {
            WaitUntil.CustomElementIsVisible(FieldInputGetApplicationLink);
            InputGeneral.InputFunctionWithClear(FieldInputGetApplicationLink, tenantCreatorMySpace.Emails.RandomMainApplicantEmail);

            return this;
        }

        [AllureStep("ClickButtonGetLink")]
        public ApartmentView ClickButtonGetLink()
        {
            WaitUntil.CustomElementIsVisible(ButtonGetLink);
            Button.Click(ButtonGetLink);

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
