﻿using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.IO;

namespace CazamioNewProject.PageObjects.AdminPages.AddApartmentsPage
{
    public partial class AddApartments
    {
        Building building = Building.Generate();
        Apartment apartment = Apartment.Generate();
        RequiredDocuments requiredDocuments = new RequiredDocuments().Generate();
        TenantCreatorMySpace tenantCreatorMySpace = TenantCreatorMySpace.Generate();

        #region Tabs

        [AllureStep("ClickTabAmenities")]
        public AddApartments ClickTabAmenities()
        {
            WaitUntil.CustomElementIsVisible(TabAmenities);
            WaitUntil.CustomElementIsClickable(TabAmenities);
            Button.Click(TabAmenities);

            return this;
        }

        [AllureStep("ClickTabAccess")]
        public AddApartments ClickTabAccess()
        {
            WaitUntil.CustomElementIsVisible(TabAccess);
            WaitUntil.CustomElementIsClickable(TabAccess);
            Button.Click(TabAccess);

            return this;
        }

        [AllureStep("ClickTabSpecials")]
        public AddApartments ClickTabSpecials()
        {
            WaitUntil.CustomElementIsVisible(TabSpecials);
            WaitUntil.CustomElementIsClickable(TabSpecials);
            Button.Click(TabSpecials);

            return this;
        }

        [AllureStep("ClickTabImages")]
        public AddApartments ClickTabImages()
        {
            WaitUntil.CustomElementIsVisible(TabImages);
            WaitUntil.CustomElementIsClickable(TabImages);
            Button.Click(TabImages);

            return this;
        }

        #endregion

        #region Tab Units

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

        [AllureStep("EnterUnitNumber")]
        public AddApartments EnterUnitNumber()
        {
            WaitUntil.CustomElementIsVisible(FieldInputUnitNumber);
            InputGeneral.InputFunctionWithClear(FieldInputUnitNumber, apartment.UnitBasicData.UnitNumberOneNumberRandom);

            return this;
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

        [AllureStep("EnterHoldDepositOneThousand")]
        public AddApartments EnterHoldDepositOneThousand()
        {
            WaitUntil.CustomElementIsVisible(FieldInputApartmentHoldDeposit);
            InputGeneral.InputFunctionWithClear(FieldInputApartmentHoldDeposit, apartment.MySpaceAmountPayments.HoldDepositOneStatic);

            return this;
        }

        [AllureStep("EnterHoldDepositThreeNumbers")]
        public AddApartments EnterHoldDepositThreeNumbers()
        {
            WaitUntil.CustomElementIsVisible(FieldInputApartmentHoldDeposit);
            InputGeneral.InputFunctionWithClear(FieldInputApartmentHoldDeposit, apartment.MySpaceAmountPayments.HoldDepositRandom);

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

        #region Tab Amenities

        [AllureStep("ClickFieldInputSearchForAmenities")]
        public AddApartments ClickFieldInputSearchForAmenities()
        {
            WaitUntil.CustomElementIsVisible(FieldInputSearchForAmenities);
            WaitUntil.CustomElementIsClickable(FieldInputSearchForAmenities);
            Button.Click(FieldInputSearchForAmenities);

            return this;
        }

        private static IWebElement _elementAmenitiesForApartment;

        [AllureStep("SelectorAmenitiesForApartment")]
        public static IList<IWebElement> SelectorAmenitiesForApartment(string itemAmenity)
        {
            var wait = new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(10));
            var str = "//div[@class = 'search-choice-wrapper']";

            _elementAmenitiesForApartment = wait.Until(drv => drv.FindElement(By.XPath(str)));

            return _elementAmenitiesForApartment.FindElements(By.XPath($".//div[contains(text(), '{itemAmenity}')]"));
        }

        [AllureStep("SelectAmenitiesForApartment")]
        public AddApartments SelectAmenitiesForApartment(int numberItem, string itemAmenity)
        {
            var wait = new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(5));
            IList<IWebElement> amenitiesList = SelectorAmenitiesForApartment(itemAmenity);

            if (numberItem >= 0 && numberItem < amenitiesList.Count)
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(amenitiesList[numberItem])).Click();
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(numberItem), "Invalid index for amenities list");
            }

            return this;
        }

        [AllureStep("ClickFieldInputSearchForDefaultIncludedInMonthlyRentAmenities")]
        public AddApartments ClickFieldInputSearchForDefaultIncludedInMonthlyRentAmenities()
        {
            WaitUntil.CustomElementIsVisible(FieldInputSearchForDefaultIncludedInMonthlyRentAmenities);
            WaitUntil.CustomElementIsClickable(FieldInputSearchForDefaultIncludedInMonthlyRentAmenities);
            Button.Click(FieldInputSearchForDefaultIncludedInMonthlyRentAmenities);

            return this;
        }

        private static IWebElement _elementDefaultIncludedInMonthlyRentAmenitiesForApartment;

        [AllureStep("SelectorIncludedInMonthlyRentAmenitiesForApartment")]
        public static IList<IWebElement> GetIncludedInMonthlyRentAmenities(string amenityText)
        {
            var wait = new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(10));
            var xpath = "//div[@class='search-choice-wrapper']";

            _elementDefaultIncludedInMonthlyRentAmenitiesForApartment = wait.Until(drv => drv.FindElement(By.XPath(xpath)));

            return _elementDefaultIncludedInMonthlyRentAmenitiesForApartment.FindElements(By.XPath($".//div[contains(text(), '{amenityText}')]"));
        }

        [AllureStep("SelectIncludedInMonthlyRentAmenity")]
        public AddApartments SelectIncludedInMonthlyRentAmenity(int index, string amenityText)
        {
            var wait = new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(5));
            IList<IWebElement> amenitiesList = GetIncludedInMonthlyRentAmenities(amenityText);

            if (index >= 0 && index < amenitiesList.Count)
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(amenitiesList[index])).Click();
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Invalid index for amenities list");
            }

            return this;
        }

        #endregion

        #region Tab Access

        [AllureStep("ClickToggleSelfTourStatus")]
        public AddApartments ClickToggleSelfTourStatus()
        {
            WaitUntil.CustomElementIsVisible(ToggleSelfTourStatus);
            Button.Click(ToggleSelfTourStatus);

            return this;
        }

        [AllureStep("ClickButtonAddLock")]
        public AddApartments ClickButtonAddLock()
        {
            WaitUntil.CustomElementIsVisible(ButtonAddLock);
            Button.Click(ButtonAddLock);

            return this;
        }

        #endregion

        #region Tab Specials

        [AllureStep("ClickTabConcessions")]
        public AddApartments ClickTabConcessions()
        {
            WaitUntil.CustomElementIsVisible(TabConcessions);
            WaitUntil.ElementIsClickable(TabConcessions);
            Button.Click(TabConcessions);

            return this;
        }

        [AllureStep("ClickTabFreeStuff")]
        public AddApartments ClickTabFreeStuff()
        {
            WaitUntil.CustomElementIsVisible(TabFreeStuff);
            WaitUntil.ElementIsClickable(TabFreeStuff);
            Button.Click(TabFreeStuff);

            return this;
        }

        [AllureStep("ClickButtonAddSpecials")]
        public AddApartments ClickButtonAddSpecials()
        {
            WaitUntil.CustomElementIsVisible(ButtonAddSpecials);
            WaitUntil.ElementIsClickable(ButtonAddSpecials);
            Button.Click(ButtonAddSpecials);

            return this;
        }

        [AllureStep("ClickButtonLeaseSignedTriggerEvent")]
        public AddApartments ClickButtonLeaseSignedTriggerEvent()
        {
            WaitUntil.CustomElementIsVisible(ButtonLeaseSignedTriggerEvent);
            WaitUntil.ElementIsClickable(ButtonLeaseSignedTriggerEvent);
            Button.Click(ButtonLeaseSignedTriggerEvent);

            return this;
        }

        [AllureStep("ClickCheckBoxIsActive")]
        public AddApartments ClickCheckBoxIsActive()
        {
            WaitUntil.CustomElementIsVisible(CheckBoxIsActive);
            WaitUntil.ElementIsClickable(CheckBoxIsActive);
            Button.Click(CheckBoxIsActive);

            return this;
        }

        #endregion

        #region Tab Images

        [AllureStep("UploadFiveImages")]
        public AddApartments UploadFiveImages()
        {
            WaitUntil.CustomElementIsVisible(ButtonBrowseFiles);
            WaitUntil.CustomElementIsClickable(ButtonBrowseFiles);
            ButtonBrowseFiles.SendKeys(Path.GetFullPath(Path.Combine(Browser.RootPath() + UploadImages.IMAGE_APARTMENT_FIRST) + "\n" +
                                                                      Browser.RootPath() + UploadImages.IMAGE_APARTMENT_SECOND + "\n" +
                                                                      Browser.RootPath() + UploadImages.IMAGE_APARTMENT_THIRD + "\n" +
                                                                      Browser.RootPath() + UploadImages.IMAGE_APARTMENT_FOURTH + "\n" +
                                                                      Browser.RootPath() + UploadImages.IMAGE_APARTMENT_FIFTH));
            WaitUntil.WaitSomeInterval(10000);

            return this;
        }

        [AllureStep("UploadEightImages")]
        public AddApartments UploadEightImages()
        {
            WaitUntil.CustomElementIsVisible(ButtonBrowseFiles);
            WaitUntil.CustomElementIsClickable(ButtonBrowseFiles);
            ButtonBrowseFiles.SendKeys(Path.GetFullPath(Path.Combine(Browser.RootPath() + UploadImages.IMAGE_APARTMENT_FIRST) + "\n" +
                                                                      Browser.RootPath() + UploadImages.IMAGE_APARTMENT_SECOND + "\n" +
                                                                      Browser.RootPath() + UploadImages.IMAGE_APARTMENT_THIRD + "\n" +
                                                                      Browser.RootPath() + UploadImages.IMAGE_APARTMENT_FOURTH + "\n" +
                                                                      Browser.RootPath() + UploadImages.IMAGE_APARTMENT_SECOND + "\n" +
                                                                      Browser.RootPath() + UploadImages.IMAGE_APARTMENT_THIRD + "\n" +
                                                                      Browser.RootPath() + UploadImages.IMAGE_APARTMENT_FOURTH + "\n" +
                                                                      Browser.RootPath() + UploadImages.IMAGE_APARTMENT_FIFTH));
            WaitUntil.WaitSomeInterval(10000);

            return this;
        }

        [AllureStep("ClickButtonSaveApartment")]
        public AddApartments ClickButtonSaveApartment()
        {
            WaitUntil.WaitSomeInterval(10000);
            KeyBoardActions.ScrollToDown();
            WaitUntil.WaitSomeInterval(10000);
            Button.Click(ButtonSaveApartment);

            return this;
        }

        [AllureStep("ClickButtonSelectVideo")]
        public AddApartments ClickButtonSelectVideo()
        {
            WaitUntil.CustomElementIsVisible(ButtonSelectVideo);
            WaitUntil.CustomElementIsClickable(ButtonSelectVideo);
            Button.Click(ButtonSelectVideo);

            return this;
        }

        [AllureStep("ClickButtonRemoveFile")]
        public AddApartments ClickButtonRemoveFile()
        {
            WaitUntil.CustomElementIsVisible(ButtonRemoveFile);
            Button.Click(ButtonRemoveFile);

            return this;
        }

        #endregion

        [AllureStep("ClickButtonGeneralNext")]
        public AddApartments ClickButtonGeneralNext()
        {
            WaitUntil.CustomElementIsVisible(ButtonGeneralNext);
            WaitUntil.CustomElementIsClickable(ButtonGeneralNext);
            Button.Click(ButtonGeneralNext);

            return this;
        }

        [AllureStep("ClickFirstRow")]
        public AddApartments ClickFirstRow()
        {
            WaitUntil.WaitSomeInterval(5000);
            WaitUntil.CustomElementIsVisible(FirstRow);
            WaitUntil.CustomElementIsClickable(FirstRow);
            Button.Click(FirstRow);

            return this;
        }
    }
}
