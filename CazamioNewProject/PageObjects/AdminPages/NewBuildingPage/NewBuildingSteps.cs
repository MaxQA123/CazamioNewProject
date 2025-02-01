using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using System;
using System.IO;

namespace CazamioNewProject.PageObjects.AdminPages.NewBuildingPage
{
    public partial class NewBuilding
    {
        #region Tab Basic Details

        [AllureStep("EnterBuildingDataWashingtonSquare")]
        public NewBuilding EnterBuildingDataWashingtonSquare()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputAddress, building.WashingtonSquare.NumberNameAddressStatic);
            WaitUntil.WaitSomeInterval(500);
            KeyBoardActions.ClickTab();
            KeyBoardActions.ClickEnterButton();
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputCity, building.WashingtonSquare.City);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputState, building.WashingtonSquare.State);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputZip, building.WashingtonSquare.Zip);
            WaitUntil.WaitSomeInterval(500);
            KeyBoardActions.ClickArrowDown();
            WaitUntil.WaitSomeInterval(100);
            KeyBoardActions.ClickEnterButton();
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputNeighborhood, building.WashingtonSquare.Neighborhood);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputBuildingName, building.WashingtonSquare.BuildingName);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputLlcName, building.WashingtonSquare.LlcName);

            return this;
        }

        [AllureStep("EnterBuildingDataAlbermaleRd")]
        public NewBuilding EnterBuildingDataAlbermaleRd()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputAddress, building.AlbermaleRd.NumberNameAddressStatic);
            WaitUntil.WaitSomeInterval(500);
            KeyBoardActions.ClickTab();
            KeyBoardActions.ClickEnterButton();
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputCity, building.AlbermaleRd.City);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputState, building.AlbermaleRd.State);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputZip, building.AlbermaleRd.Zip);
            WaitUntil.WaitSomeInterval(500);
            KeyBoardActions.ClickArrowDown();
            WaitUntil.WaitSomeInterval(100);
            KeyBoardActions.ClickEnterButton();
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputNeighborhood, building.AlbermaleRd.Neighborhood);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputBuildingName, building.AlbermaleRd.BuildingName);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputLlcName, building.AlbermaleRd.LlcName);

            return this;
        }

        [AllureStep("EnterBuildingDataEast51stStreetPedestrianCrossing")]
        public NewBuilding EnterBuildingDataEast51stStreetPedestrianCrossing()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputAddress, building.East51stStreetPedestrianCrossing.NumberNameAddressStatic);
            WaitUntil.WaitSomeInterval(500);
            KeyBoardActions.ClickTab();
            KeyBoardActions.ClickEnterButton();
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputCity, building.East51stStreetPedestrianCrossing.City);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputState, building.East51stStreetPedestrianCrossing.State);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputZip, building.East51stStreetPedestrianCrossing.Zip);
            WaitUntil.WaitSomeInterval(500);
            KeyBoardActions.ClickArrowDown();
            WaitUntil.WaitSomeInterval(100);
            KeyBoardActions.ClickEnterButton();
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputNeighborhood, building.East51stStreetPedestrianCrossing.Neighborhood);

            return this;
        }

        [AllureStep("EnterBuildingDataSaintJohnsonPl")]
        public NewBuilding EnterBuildingDataSaintJohnsonPl()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputAddress, building.SaintJohnsonPl.NumberNameAddressStatic);
            WaitUntil.WaitSomeInterval(500);
            KeyBoardActions.ClickTab();
            KeyBoardActions.ClickEnterButton();
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputCity, building.SaintJohnsonPl.City);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputState, building.SaintJohnsonPl.State);
            WaitUntil.WaitSomeInterval(100);

            return this;
        }

        [AllureStep("EnterBuildingDataCrownSt")]
        public NewBuilding EnterBuildingDataCrownSt()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputAddress, building.CrownSt.NumberNameAddressStatic);
            WaitUntil.WaitSomeInterval(500);
            KeyBoardActions.ClickTab();
            KeyBoardActions.ClickEnterButton();
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputCity, building.CrownSt.City);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputState, building.CrownSt.State);
            WaitUntil.WaitSomeInterval(100);

            return this;
        }

        [AllureStep("EnterLongInternalNotesDescription")]
        public NewBuilding EnterLongInternalNotesDescription()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputDescroption, building.DescriptionsInternalNotes.DescriptionLong);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputInternalNotes, building.DescriptionsInternalNotes.InternalNotesLong);

            return this;
        }

        [AllureStep("EnterShortInternalNotesDescription")]
        public NewBuilding EnterShortInternalNotesDescription()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputDescroption, building.DescriptionsInternalNotes.DescriptionShort);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputInternalNotes, building.DescriptionsInternalNotes.InternalNotesShort);

            return this;
        }

        [AllureStep("EnterCreditScreeningFeeHoldDeposit")]
        public NewBuilding EnterCreditScreeningFeeHoldDeposit()
        {
            WaitUntil.CustomElementIsVisible(FieldInputCreditScreeningFee);
            WaitUntil.CustomElementIsClickable(FieldInputCreditScreeningFee);
            InputGeneral.InputFunctionWithClear(FieldInputCreditScreeningFee, building.MySpaceAmountPayments.CreditScreeningFeeStatic);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputHoldDeposit, building.MySpaceAmountPayments.HoldDepositStatic);

            return this;
        }

        [AllureStep("SelectOwnerNoCommissionAgent")]
        public NewBuilding SelectOwnerNoCommissionAgent()
        {
            WaitUntil.WaitSomeInterval(5000);
            Button.Click(ButtonMenuOwnerSelect);
            WaitUntil.WaitSomeInterval(5000);
            Button.Click(SetOwnerNoCommissionAgent());

            return this;
        }

        [AllureStep("SelectOwnerOwnerAndTenantPaysCommissionBroker")]
        public NewBuilding SelectOwnerOwnerAndTenantPaysCommissionBroker()
        {
            WaitUntil.WaitSomeInterval(5000);
            Button.Click(ButtonMenuOwnerSelect);
            WaitUntil.WaitSomeInterval(5000);
            Button.Click(SetItemOwnerOwnerAndTenantPaysCommissionBroker());

            return this;
        }

        [AllureStep("SelectOwnerOwnerPaysBroker")]
        public NewBuilding SelectOwnerOwnerPaysBroker()
        {
            WaitUntil.WaitSomeInterval(5000);
            Button.Click(ButtonMenuOwnerSelect);
            WaitUntil.WaitSomeInterval(5000);
            Button.Click(SetOwnerOwnerPaysBroker());

            return this;
        }

        [AllureStep("SelectOwnerTenantPaysCommissionAgent")]
        public NewBuilding SelectOwnerTenantPaysCommissionAgent()
        {
            WaitUntil.WaitSomeInterval(5000);
            Button.Click(ButtonMenuOwnerSelect);
            WaitUntil.WaitSomeInterval(5000);
            Button.Click(SetOwnerTenantPaysCommissionAgent());

            return this;
        }

        #endregion

        #region Tab Amenities

        [AllureStep("SelectFiveAmenities")]
        public NewBuilding SelectFiveAmenities()
        {
            WaitUntil.WaitSomeInterval(500);
            Pages.NewBuilding
            .SelectAmenitiesForBuilding(ListOfAmenitiesForBuildingAdminsPage.FIRST_TAG, " ")
            .SelectAmenitiesForBuilding(ListOfAmenitiesForBuildingAdminsPage.FIRST_TAG, " ")
            .SelectAmenitiesForBuilding(ListOfAmenitiesForBuildingAdminsPage.FIRST_TAG, " ")
            .SelectAmenitiesForBuilding(ListOfAmenitiesForBuildingAdminsPage.FIRST_TAG, " ")
            .SelectAmenitiesForBuilding(ListOfAmenitiesForBuildingAdminsPage.FIRST_TAG, " ");

            return this;
        }

        #endregion

        #region Tab Access

        [AllureStep("AddItemAccessTypePinCode")]
        public NewBuilding AddItemAccessTypePinCode()
        {
            WaitUntil.WaitSomeInterval(3000);
            WaitUntil.CustomElementIsVisible(ButtonAccessType);
            Button.Click(ButtonAccessType);
            KeyBoardActions.ClickEnterButton();
            //Button.Click(ItemPinCode);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputPinCodeForFirstEnter, GenerateRandomData.RandomNumberWithoutZero(1));
            KeyBoardActions.ClickSpaceButton();
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithoutClear(FieldInputPinCodeForNextEnter, GenerateRandomData.RandomNumberWithoutZero(1));
            KeyBoardActions.ClickSpaceButton();
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithoutClear(FieldInputPinCodeForNextEnter, GenerateRandomData.RandomNumberWithoutZero(1));
            KeyBoardActions.ClickSpaceButton();
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithoutClear(FieldInputPinCodeForNextEnter, GenerateRandomData.RandomNumberWithoutZero(1));
            KeyBoardActions.ClickSpaceButton();
            InputGeneral.InputFunctionWithClear(FieldInputCustomNoteForAccess, building.AccessLocks.PinCodeTextLorem);
            WaitUntil.WaitSomeInterval(100);
            ButtonSelectImageForAccess.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.IMAGE_BUILDING_LOCK_PIN_CODE));
            ToasterSuccessfully.IsVisible(MessageSuccessUploadImageForAccess);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonSaveForLock);

            return this;
        }

        [AllureStep("AddItemAccessTypeNote")]
        public NewBuilding AddItemAccessTypeNote()
        {
            WaitUntil.WaitSomeInterval(3000);
            WaitUntil.CustomElementIsVisible(ButtonAccessType);
            Button.Click(ButtonAccessType);
            Button.Click(ItemNote);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputCustomNoteForAccess, building.AccessLocks.NoteTextLorem);
            WaitUntil.WaitSomeInterval(100);
            ButtonSelectImageForAccess.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.IMAGE_BUILDING_LOCK_NOTE));
            ToasterSuccessfully.IsVisible(MessageSuccessUploadImageForAccess);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonSaveForLock);

            return this;
        }

        #endregion

        #region Tab Specials

        [AllureStep("AddFirstConcessionIsActive")]
        public NewBuilding AddFirstConcessionIsActive()
        {
            WaitUntil.CustomElementIsVisible(FieldInputNameSpecials);
            WaitUntil.CustomElementIsClickable(FieldInputNameSpecials);
            InputGeneral.InputFunctionWithClear(FieldInputNameSpecials, building.SettingsConcessions.NameFirst);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputMonthsFree, building.SettingsConcessions.OneMonthYearFree);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputLeaseTerms, building.SettingsConcessions.TwelveMonthsLeaseTerms);
            WaitUntil.WaitSomeInterval(100);
            KeyBoardActions.ClickArrowDown();
            KeyBoardActions.ClickEnterButton();
            InputGeneral.InputFunctionWithClear(FieldInputAdditionalInfo, building.SettingsConcessions.AdditionalInfoShort);
            WaitUntil.WaitSomeInterval(100);
            KeyBoardActions.ClickArrowDown();
            KeyBoardActions.ClickEnterButton();
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonYesSpecials);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(FieldInputDateFrom);
            WaitUntil.WaitSomeInterval(100);
            Pages.DatePicker
                .SelectCurrentDay();
            WaitUntil.WaitSomeInterval(100);
            Button.Click(FieldInputDateTo);
            WaitUntil.WaitSomeInterval(100);
            Pages.DatePicker
                .ClickButtonDropDownYearMonth()
                .SelectNextYear();
            Pages.DatePicker
                .SelectNextMonth();
            Pages.DatePicker
                .SelectFisrtDayInNextMonth();
            //Pages.DatePicker
            //    .SelectCurrentDay();
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonSaveSpecials);

            return this;
        }

        [AllureStep("AddConcessionIsActiveWithoutName")]
        public NewBuilding AddConcessionIsActiveWithoutName()
        {
            WaitUntil.CustomElementIsVisible(FieldInputNameSpecials);
            WaitUntil.CustomElementIsClickable(FieldInputNameSpecials);
            InputGeneral.InputFunctionWithClear(FieldInputMonthsFree, building.SettingsConcessions.RandomMonthsFree);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputLeaseTerms, building.SettingsConcessions.TwelveMonthsLeaseTerms);
            WaitUntil.WaitSomeInterval(100);
            KeyBoardActions.ClickArrowDown();
            KeyBoardActions.ClickEnterButton();
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonYesSpecials);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(FieldInputDateFrom);
            WaitUntil.WaitSomeInterval(100);
            Pages.DatePicker
                .SelectCurrentDay();
            WaitUntil.WaitSomeInterval(100);
            Button.Click(FieldInputDateTo);
            WaitUntil.WaitSomeInterval(100);
            Pages.DatePicker
                .SelectCurrentDayPlusOneDay();
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonSaveSpecials);

            return this;
        }

        [AllureStep("AddConcessionInActive")]
        public NewBuilding AddConcessionInActive()
        {
            WaitUntil.CustomElementIsVisible(CheckBoxIsActive);
            WaitUntil.ElementIsClickable(CheckBoxIsActive);
            Button.Click(CheckBoxIsActive);
            WaitUntil.CustomElementIsVisible(FieldInputNameSpecials);
            InputGeneral.InputFunctionWithClear(FieldInputNameSpecials, building.SettingsConcessions.NameFirst);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputMonthsFree, building.SettingsConcessions.TwoMonthsFree);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputLeaseTerms, building.SettingsConcessions.TwelveMonthsLeaseTerms);
            WaitUntil.WaitSomeInterval(100);
            KeyBoardActions.ClickArrowDown();
            KeyBoardActions.ClickEnterButton();
            InputGeneral.InputFunctionWithClear(FieldInputAdditionalInfo, building.SettingsConcessions.AdditionalInfoLong);
            WaitUntil.WaitSomeInterval(100);
            KeyBoardActions.ClickArrowDown();
            KeyBoardActions.ClickEnterButton();
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonYesSpecials);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(FieldInputDateFrom);
            WaitUntil.WaitSomeInterval(100);
            Pages.DatePicker
                .SelectCurrentDay();
            WaitUntil.WaitSomeInterval(100);
            Button.Click(FieldInputDateTo);
            WaitUntil.WaitSomeInterval(100);
            Pages.DatePicker
                .SelectCurrentDay();
            KeyBoardActions.ScrollToDown();
            Button.Click(ButtonMoveInTriggerEvent);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonSaveSpecials);

            return this;
        }

        [AllureStep("AddFirstFreeStuffIsActive")]
        public NewBuilding AddFirstFreeStuffIsActive()
        {
            WaitUntil.CustomElementIsVisible(FieldInputNameSpecials);
            WaitUntil.CustomElementIsClickable(FieldInputNameSpecials);
            InputGeneral.InputFunctionWithClear(FieldInputNameSpecials, building.SettingsFreeStuff.NameFirst);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(FieldInputSelectItemsFreeStuff);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ItemFreeNetflix);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ItemGoogleSpeaker);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonYesSpecials);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(FieldInputDateFrom);
            WaitUntil.WaitSomeInterval(100);
            Pages.DatePicker
                .SelectCurrentDay();
            WaitUntil.WaitSomeInterval(100);
            Button.Click(FieldInputDateTo);
            WaitUntil.WaitSomeInterval(100);
            Pages.DatePicker
                .SelectCurrentDay();
            WaitUntil.WaitSomeInterval(100);
            KeyBoardActions.ScrollToDown();
            Button.Click(ButtonLeaseSignedTriggerEvent);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonSaveSpecials);

            return this;
        }

        [AllureStep("AddFreeStuffIsActiveWithoutName")]
        public NewBuilding AddFreeStuffIsActiveWithoutName()
        {
            WaitUntil.CustomElementIsVisible(FieldInputNameSpecials);
            WaitUntil.CustomElementIsClickable(FieldInputNameSpecials);
            Button.Click(FieldInputSelectItemsFreeStuff);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ItemFreeNetflix);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ItemGoogleSpeaker);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonYesSpecials);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(FieldInputDateFrom);
            WaitUntil.WaitSomeInterval(100);
            Pages.DatePicker
                .SelectCurrentDay();
            WaitUntil.WaitSomeInterval(100);
            Button.Click(FieldInputDateTo);
            WaitUntil.WaitSomeInterval(100);
            Pages.DatePicker
                .SelectCurrentDayPlusOneDay();
            WaitUntil.WaitSomeInterval(100);
            KeyBoardActions.ScrollToDown();
            Button.Click(ButtonLeaseSignedTriggerEvent);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonSaveSpecials);

            return this;
        }

        [AllureStep("AddFreeStuffInActive")]
        public NewBuilding AddFreeStuffInActive()
        {
            WaitUntil.CustomElementIsVisible(CheckBoxIsActive);
            WaitUntil.ElementIsClickable(CheckBoxIsActive);
            Button.Click(CheckBoxIsActive);
            WaitUntil.CustomElementIsVisible(FieldInputNameSpecials);
            InputGeneral.InputFunctionWithClear(FieldInputNameSpecials, building.SettingsFreeStuff.NameFirst);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(FieldInputSelectItemsFreeStuff);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ItemFreeNetflix);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonYesSpecials);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(FieldInputDateFrom);
            WaitUntil.WaitSomeInterval(100);
            Pages.DatePicker
                .SelectCurrentDay();
            WaitUntil.WaitSomeInterval(100);
            Button.Click(FieldInputDateTo);
            WaitUntil.WaitSomeInterval(100);
            Pages.DatePicker
                .SelectCurrentDay();
            WaitUntil.WaitSomeInterval(100);
            KeyBoardActions.ScrollToDown();
            Button.Click(ButtonMoveInTriggerEvent);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonSaveSpecials);

            return this;
        }

        #endregion

        [AllureStep("ClickTwiceButtonGeneralNext")]
        public NewBuilding ClickTwiceButtonGeneralNext()
        {
            WaitUntil.CustomElementIsVisible(ButtonGeneralNext);
            WaitUntil.CustomElementIsClickable(ButtonGeneralNext);
            Button.Click(ButtonGeneralNext);
            WaitUntil.CustomElementIsVisible(ButtonGeneralNext);
            WaitUntil.CustomElementIsClickable(ButtonGeneralNext);
            Button.Click(ButtonGeneralNext);

            return this;
        }

        [AllureStep("ClickThreeTimesButtonGeneralNext")]
        public NewBuilding ClickThreeTimesButtonGeneralNext()
        {
            WaitUntil.WaitSomeInterval(3000);
            WaitUntil.CustomElementIsVisible(ButtonGeneralNext);
            WaitUntil.CustomElementIsClickable(ButtonGeneralNext);
            Button.Click(ButtonGeneralNext);
            WaitUntil.CustomElementIsVisible(ButtonGeneralNext);
            WaitUntil.CustomElementIsClickable(ButtonGeneralNext);
            Button.Click(ButtonGeneralNext);
            WaitUntil.CustomElementIsVisible(ButtonGeneralNext);
            WaitUntil.CustomElementIsClickable(ButtonGeneralNext);
            Button.Click(ButtonGeneralNext);

            return this;
        }
    }
}
