﻿using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CazamioNewProject.PageObjects.AdminPages.ApartmentApplicationsTbls
{
    public partial class ApartmentApplicationsTbl
    {
        [AllureStep("GetApartmentAddressFromFirstRow")]
        public string GetApartmentAddressFromFirstRow()
        {
            WaitUntil.CustomElementIsVisible(VlOfClmnApartmentFirstRow);
            string apartmentAddress = VlOfClmnApartmentFirstRow.Text;

            return apartmentAddress;
        }

        [AllureStep("GetFirstNameTenantMainApplicantFromFirstRow")]
        public string GetFirstNameTenantMainApplicantFromFirstRow()
        {
            WaitUntil.WaitSomeInterval(500);
            string getFirstName = VlMainApplicantOfClmnApplicantsFrstRw.Text;
            Regex regexGetFirstName = new Regex(@"^\w+");
            string firstName = regexGetFirstName.Match(getFirstName).ToString();

            return firstName;
        }

        [AllureStep("GetLastNameTenantMainApplicantFromFirstRow")]
        public string GetLastNameTenantMainApplicantFromFirstRow()
        {
            WaitUntil.WaitSomeInterval(500);

            // Получаем значение из элемента
            string fullName = VlMainApplicantOfClmnApplicantsFrstRw.Text;

            // Регулярное выражение для второго слова
            Regex regexGetSecondName = new Regex(@"^\w+\s+(\w+)");

            // Ищем совпадение и сразу возвращаем второе слово
            return regexGetSecondName.Match(fullName).Groups[1].Value;
        }

        //[AllureStep("GetSecondNameTenantMainApplicantFromFirstRow")]
        //public string GetSecondNameTenantMainApplicantFromFirstRow()
        //{
        //    WaitUntil.WaitSomeInterval(500);

        //    // Получаем значение из элемента
        //    string fullName = VlMainApplicantOfClmnApplicantsFrstRw.Text;

        //    // Регулярное выражение для второго слова
        //    Regex regexGetSecondName = new Regex(@"^\w+\s+(\w+)");

        //    // Ищем совпадение и сразу возвращаем второе слово
        //    return regexGetSecondName.Match(fullName).Groups[1].Value;
        //}

        [AllureStep("GetPriceFromFirstRow")]
        public string GetPriceFromFirstRow()
        {
            WaitUntil.CustomElementIsVisible(VlOfClmnPriceFrstRw);
            string price = VlOfClmnPriceFrstRw.Text;

            return price;
        }

        [AllureStep("GetAgentFromFrstRw")]
        public string GetAgentFromFrstRw()
        {
            WaitUntil.CustomElementIsVisible(VlOfClmnAgentFrstRw);
            string agent = VlOfClmnAgentFrstRw.Text;

            return agent;
        }

        [AllureStep("GetStatusFromFrstRw")]
        public string GetStatusFromFrstRw()
        {
            WaitUntil.CustomElementIsVisible(VlLabelOfClmnStatusFrstRw);
            string status = VlLabelOfClmnStatusFrstRw.Text;

            return status;
        }
    }
}
