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
            string fullEmail = FieldInputFirstName.GetAttribute("value");

            return fullEmail;
        }

        [AllureStep("GetLastNameFromFieldLastName")]
        public string GetLastNameFromFieldLastName()
        {
            WaitUntil.CustomElementIsVisible(FieldInputLastName);
            string fullEmail = FieldInputLastName.GetAttribute("value");

            return fullEmail;
        }

        [AllureStep("GetVlUnitNumber")]
        public string GetVlUnitNumber()
        {
            WaitUntil.WaitSomeInterval(1000);
            WaitUntil.CustomElementIsVisible(VlUnitNumber);
            // Получение текста уведомления из EmailNotifications
            string subjectNotification = EmailNotifications.Generate().SubjectsTenantGeneral.CreateTenantViaGetLink;
            Console.WriteLine("Original Notification: " + subjectNotification);

            // Извлечение номера квартиры из строки
            Regex regexUnitNumber = new Regex(@"#\s*\d+");
            string unitNumberAc = regexUnitNumber.Match(VlUnitNumber.Text).ToString();
            Console.WriteLine("Extracted Unit Number: " + unitNumberAc);

            // Проверка извлеченного номера квартиры
            if (string.IsNullOrEmpty(unitNumberAc))
            {
                throw new Exception("Unit number could not be extracted. Check the input format of VlUnitNumber.Text.");
            }

            // Замена номера квартиры в subjectNotification
            string updatedText = ReplaceUnitNumber(subjectNotification, unitNumberAc);
            Console.WriteLine("Updated Notification: " + updatedText);

            // Возвращение обновленного текста
            return updatedText;
        }

        private static string ReplaceUnitNumber(string subjectNotification, string unitNumber)
        {
            // Лог для проверки входных данных
            Console.WriteLine("Before Replacement: " + subjectNotification);
            Console.WriteLine("Unit Number to Replace With: " + unitNumber);

            // Замена номера квартиры в тексте
            string updatedText = Regex.Replace(subjectNotification, @"#\s*\d+", unitNumber);

            // Лог для проверки результата
            Console.WriteLine("After Replacement: " + updatedText);

            return updatedText;
        }

        //[AllureStep("GetVlUnitNumber")]
        //public string GetVlUnitNumber()
        //{
        //    WaitUntil.WaitSomeInterval(500);

        //    // Получение текста уведомления из EmailNotifications
        //    string subjectNotification = EmailNotifications.Generate().SubjectsTenantGeneral.CreateTenantViaGetLink;

        //    // Извлечение номера квартиры из строки
        //    Regex regexUnitNumber = new Regex(@"#\d+");
        //    string unitNumberAc = regexUnitNumber.Match(VlUnitNumber.Text).ToString();

        //    // Замена номера квартиры в subjectNotification
        //    string updatedText = ReplaceUnitNumber(subjectNotification, unitNumberAc);

        //    // Возвращение обновленного текста
        //    return updatedText;
        //}

        //private static string ReplaceUnitNumber(string subjectNotification, string unitNumber)
        //{
        //    // Замена текста между "Place" и "now" (номер квартиры)
        //    return Regex.Replace(subjectNotification, @"#\s\d+", unitNumber);
        //}

        //[AllureStep("GetVlUnitNumber")]
        //public string GetVlUnitNumber()
        //{
        //    WaitUntil.WaitSomeInterval(500);
        //    string unitNumber = VlUnitNumber.Text;
        //    Regex regexUnitNumber = new Regex(@"#\s\d+");
        //    string unitNumberAc = regexUnitNumber.Match(unitNumber).ToString();

        //    return unitNumberAc;
        //}

        [AllureStep("CopyEmailBeforeDogFromFieldGetApplicationLink")]
        public string CopyEmailBeforeDogFromFieldGetApplicationLink()
        {
            WaitUntil.WaitSomeInterval(500);
            string copyPartEmail = FieldInputGetApplicationLink.GetAttribute("value");
            Regex regexPartEmail = new Regex(@"^...................");
            string partEmail = regexPartEmail.Match(copyPartEmail).ToString();

            return partEmail;
        }

        [AllureStep("GetLeasePriceValueOfString")]
        public string GetLeasePriceValueOfString()
        {
            WaitUntil.CustomElementIsVisible(LeasePriceValueOfString);
            string fullEmail = LeasePriceValueOfString.Text;

            return fullEmail;
        }

        [AllureStep("EnterFieldInputFirstName")]
        public ApartmentView EnterFieldInputGetApplicationLink()
        {
            WaitUntil.CustomElementIsVisible(FieldInputGetApplicationLink);
            InputGeneral.InputFunctionWithClear(FieldInputGetApplicationLink, application.TenantsData.EmailNewTenantMainApplicant);

            return this;
        }

        [AllureStep("ClickButtonGetLink")]
        public ApartmentView ClickButtonGetLink()
        {
            WaitUntil.CustomElementIsVisible(ButtonGetLink);
            Button.Click(ButtonGetLink);

            return this;
        }

        [AllureStep("EnterFieldInputFirstName")]
        public ApartmentView EnterFieldInputFirstName()
        {
            WaitUntil.CustomElementIsVisible(FieldInputFirstName);
            InputGeneral.InputFunctionWithClear(FieldInputFirstName, application.TenantsData.FirstNameNewTenantMainApplicant);

            return this;
        }

        [AllureStep("EnterFieldInputLastName")]
        public ApartmentView EnterFieldInputLastName()
        {
            WaitUntil.CustomElementIsVisible(FieldInputLastName);
            InputGeneral.InputFunctionWithClear(FieldInputLastName, application.TenantsData.LastNameNewTenantMainApplicant);

            return this;
        }

        #endregion
    }
}
