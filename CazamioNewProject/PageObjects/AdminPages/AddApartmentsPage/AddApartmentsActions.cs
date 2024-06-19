﻿using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace CazamioNewProject.PageObjects.AdminPages.AddApartmentsPage
{
    public partial class AddApartments
    {
        Building building = new Building().Generate();
        Apartment apartment = new Apartment().Generate();
        Agent agent = new Agent().Generate();
        RequiredDocuments requiredDocuments = new RequiredDocuments().Generate();

        #region TabUnits

        [AllureStep("GetLeasePrice")]
        public string GetLeasePrice()
        {
            WaitUntil.CustomElementIsVisible(FieldInputLeasePrice);
            string getLeasePrice = FieldInputLeasePrice.GetAttribute("value");
            string getLeasePriceActual = getLeasePrice.ToString();

            return getLeasePriceActual;
        }

        [AllureStep("GetUnitNumber")]
        public string GetUnitNumber()
        {
            WaitUntil.CustomElementIsVisible(FieldInputUnitNumber);
            string getUnitNumber = FieldInputUnitNumber.GetAttribute("value");
            string getUnitNumberActual = getUnitNumber.ToString();

            return getUnitNumberActual;
        }

        [AllureStep("GetStatus")]
        public string GetStatus()
        {
            WaitUntil.CustomElementIsVisible(ButtonApartmentStatus);
            WaitUntil.CustomElementIsClickable(ButtonApartmentStatus);
            Button.Click(ButtonApartmentStatus);
            WaitUntil.CustomElementIsVisible(InputStatus);
            string getStatus = InputStatus.Text;
            string getStatusActual = getStatus.ToString();
            KeyBoardActions.ClickEnterButton();

            return getStatusActual;
        }

        [AllureStep("GetSecurityDeposit")]
        public string GetSecurityDeposit()
        {
            WaitUntil.CustomElementIsVisible(FieldInputSecurityDeposit);
            string getSecurityDeposit = FieldInputSecurityDeposit.GetAttribute("value");
            string getSecurityDepositActual = getSecurityDeposit.ToString();

            return getSecurityDepositActual;
        }

        [AllureStep("EnterLeasePriceOneNumber")]
        public AddApartments EnterLeasePriceOneNumber()
        //SecurityDeposit autofill
        {
            WaitUntil.CustomElementIsVisible(FieldInputLeasePrice);
            InputGeneral.InputFunctionWithClear(FieldInputLeasePrice, GenerateRandomData.RandomNumberWithoutZero(4));

            return this;
        }

        [AllureStep("EnterSecurityDepositOneNumber")]
        public AddApartments EnterSecurityDepositOneNumber()
        //SecurityDeposit autofill
        {
            WaitUntil.CustomElementIsVisible(FieldInputLeasePrice);
            InputGeneral.InputFunctionWithClear(FieldInputLeasePrice, GenerateRandomData.RandomNumberWithoutZero(4));

            return this;
        }

        [AllureStep("EnterFieldInputFloor")]
        public AddApartments EnterFieldInputFloor()
        {
            WaitUntil.CustomElementIsVisible(FieldInputFloor);
            InputGeneral.InputFunctionWithClear(FieldInputFloor, GenerateRandomData.RandomNumberWithoutZero(2));

            return this;
        }

        [AllureStep("ClickButtonPaymentMethods")]
        public AddApartments ClickButtonPaymentMethods()
        {
            WaitUntil.CustomElementIsVisible(ButtonPaymentMethods);
            Button.Click(ButtonPaymentMethods);

            return this;
        }

        [AllureStep("ClickFieldInputAvailableFrom")]
        public AddApartments ClickFieldInputAvailableFrom()
        {
            WaitUntil.CustomElementIsVisible(FieldInputAvailableFrom);
            Button.Click(FieldInputAvailableFrom);

            return this;
        }

        [AllureStep("ClickButtonApartmentType")]
        public AddApartments ClickButtonApartmentType()
        {
            WaitUntil.CustomElementIsVisible(ButtonApartmentType);
            Button.Click(ButtonApartmentType);

            return this;
        }

        [AllureStep("EnterHoldDepositOneNumber")]
        public AddApartments EnterHoldDepositOneNumber()
        {
            WaitUntil.CustomElementIsVisible(FieldInputApartmentHoldDeposit);
            InputGeneral.InputFunctionWithClear(FieldInputApartmentHoldDeposit, apartment.HoldDeposit.OneNumber);

            return this;
        }

        [AllureStep("ClickButtonSetFromBuilding")]
        public AddApartments ClickButtonSetFromBuilding()
        {
            WaitUntil.CustomElementIsVisible(ButtonSetFromBuilding);
            Button.Click(ButtonSetFromBuilding);

            return this;
        }

        #endregion

        #region TabAmenities

        [AllureStep("ClickFieldInputSearchForAmenitiesAddAprtmntsgPg")]
        public AddApartments ClickFieldInputSearchForAmenitiesAddAprtmntsgPg()
        {
            WaitUntil.WaitSomeInterval(500);
            Button.Click(FieldInputSearchForAmenities);

            return this;
        }

        private static IWebElement _elementAmenitiesForApartment;

        [AllureStep("SelectorAmenitiesForBuilding")]
        public static IList<IWebElement> SelectorAmenitiesForApartment(string _itemAmenity)
        {
            WaitUntil.WaitSomeInterval(1000);
            var str = "//div[@class = 'search-choice-wrapper']";
            _elementAmenitiesForApartment = Browser._Driver.FindElement(By.XPath(str));
            return _elementAmenitiesForApartment.FindElements(By.XPath($".//div[contains(text(), '{_itemAmenity}')]"));
        }

        [AllureStep("SelectAmenitiesForBuilding")]
        public AddApartments SelectAmenitiesForApartment(int numberItem, string itemAmenity)
        {
            WaitUntil.WaitSomeInterval(500);
            IList<IWebElement> _numberItem = SelectorAmenitiesForApartment(itemAmenity);

            _numberItem[numberItem].Click();

            return this;
        }

        [AllureStep("ClickFieldInputSearchForDefaultIncludedInMonthlyRentAmenitiesAddAprtmntsgPg")]
        public AddApartments ClickFieldInputSearchForDefaultIncludedInMonthlyRentAmenitiesAddAprtmntsgPg()
        {
            WaitUntil.WaitSomeInterval(500);
            Button.Click(FieldInputSearchForDefaultIncludedInMonthlyRentAmenities);

            return this;
        }

        private static IWebElement _elementDefaultIncludedInMonthlyRentAmenitiesForApartment;

        [AllureStep("SelectorIncludedInMonthlyRentAmenitiesForApartmentForApartment")]
        public static IList<IWebElement> SelectorIncludedInMonthlyRentAmenitiesForApartmentForApartment(string _itemAmenity)
        {
            WaitUntil.WaitSomeInterval(1000);
            var str = "//div[@class = 'search-choice-wrapper']";
            _elementDefaultIncludedInMonthlyRentAmenitiesForApartment = Browser._Driver.FindElement(By.XPath(str));
            return _elementDefaultIncludedInMonthlyRentAmenitiesForApartment.FindElements(By.XPath($".//div[contains(text(), '{_itemAmenity}')]"));
        }

        [AllureStep("SelectIncludedInMonthlyRentAmenitiesForApartmentForApartment")]
        public AddApartments SelectIncludedInMonthlyRentAmenitiesForApartmentForApartment(int numberItem, string itemAmenity)
        {
            WaitUntil.WaitSomeInterval(500);
            IList<IWebElement> _numberItem = SelectorIncludedInMonthlyRentAmenitiesForApartmentForApartment(itemAmenity);

            _numberItem[numberItem].Click();

            return this;
        }

        #endregion

        [AllureStep("ClickButtonGeneralNext")]
        public AddApartments ClickButtonGeneralNext()
        {
            WaitUntil.WaitSomeInterval(3000);
            Button.Click(ButtonGeneralNext);

            return this;
        }
    }
}
