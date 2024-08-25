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
            InputGeneral.InputFunctionWithClear(FieldInputAddress, demo.WashingtonSquare.NumberNameAddressStatic);
            WaitUntil.WaitSomeInterval(500);
            KeyBoardActions.ClickTab();
            KeyBoardActions.ClickEnterButton();
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputCity, demo.WashingtonSquare.City);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputState, demo.WashingtonSquare.State);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputZip, demo.WashingtonSquare.Zip);
            WaitUntil.WaitSomeInterval(500);
            KeyBoardActions.ClickArrowDown();
            WaitUntil.WaitSomeInterval(100);
            KeyBoardActions.ClickEnterButton();
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputNeighborhood, demo.WashingtonSquare.Neighborhood);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputBuildingName, demo.WashingtonSquare.BuildingName);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputLlcName, demo.WashingtonSquare.LlcName);

            return this;
        }

        [AllureStep("EnterBuildingDataAlbermaleRd")]
        public NewBuilding EnterBuildingDataAlbermaleRd()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputAddress, demo.AlbermaleRd.NumberNameAddressStatic);
            WaitUntil.WaitSomeInterval(500);
            KeyBoardActions.ClickTab();
            KeyBoardActions.ClickEnterButton();
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputCity, demo.AlbermaleRd.City);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputState, demo.AlbermaleRd.State);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputZip, demo.AlbermaleRd.Zip);
            WaitUntil.WaitSomeInterval(500);
            KeyBoardActions.ClickArrowDown();
            WaitUntil.WaitSomeInterval(100);
            KeyBoardActions.ClickEnterButton();
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputNeighborhood, demo.AlbermaleRd.Neighborhood);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputBuildingName, demo.AlbermaleRd.BuildingName);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputLlcName, demo.AlbermaleRd.LlcName);

            return this;
        }

        [AllureStep("EnterBuildingDataEast51stStreetPedestrianCrossing")]
        public NewBuilding EnterBuildingDataEast51stStreetPedestrianCrossing()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputAddress, demo.East51stStreetPedestrianCrossing.NumberNameAddressStatic);
            WaitUntil.WaitSomeInterval(500);
            KeyBoardActions.ClickTab();
            KeyBoardActions.ClickEnterButton();
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputCity, demo.East51stStreetPedestrianCrossing.City);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputState, demo.East51stStreetPedestrianCrossing.State);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputZip, demo.East51stStreetPedestrianCrossing.Zip);
            WaitUntil.WaitSomeInterval(500);
            KeyBoardActions.ClickArrowDown();
            WaitUntil.WaitSomeInterval(100);
            KeyBoardActions.ClickEnterButton();
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputNeighborhood, demo.East51stStreetPedestrianCrossing.Neighborhood);

            return this;
        }

        [AllureStep("EnterBuildingDataSaintJohnsonPl")]
        public NewBuilding EnterBuildingDataSaintJohnsonPl()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputAddress, demo.SaintJohnsonPl.NumberNameAddressStatic);
            WaitUntil.WaitSomeInterval(500);
            KeyBoardActions.ClickTab();
            KeyBoardActions.ClickEnterButton();
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputCity, demo.SaintJohnsonPl.City);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputState, demo.SaintJohnsonPl.State);
            WaitUntil.WaitSomeInterval(100);

            return this;
        }

        [AllureStep("EnterBuildingDataCrownSt")]
        public NewBuilding EnterBuildingDataCrownSt()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputAddress, demo.CrownSt.NumberNameAddressStatic);
            WaitUntil.WaitSomeInterval(500);
            KeyBoardActions.ClickTab();
            KeyBoardActions.ClickEnterButton();
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputCity, demo.CrownSt.City);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputState, demo.CrownSt.State);
            WaitUntil.WaitSomeInterval(100);

            return this;
        }

        [AllureStep("EnterLongInternalNotesDescription")]
        public NewBuilding EnterLongInternalNotesDescription()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputDescroption, demo.DescriptionsInternalNotes.DescriptionLong);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputInternalNotes, demo.DescriptionsInternalNotes.InternalNotesLong);

            return this;
        }

        [AllureStep("EnterShortInternalNotesDescription")]
        public NewBuilding EnterShortInternalNotesDescription()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputDescroption, demo.DescriptionsInternalNotes.DescriptionShort);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputInternalNotes, demo.DescriptionsInternalNotes.InternalNotesShort);

            return this;
        }

        [AllureStep("EnterCreditScreeningFeeHoldDeposit")]
        public NewBuilding EnterCreditScreeningFeeHoldDeposit()
        {
            WaitUntil.CustomElementIsVisible(FieldInputCreditScreeningFee);
            WaitUntil.CustomElementIsClickable(FieldInputCreditScreeningFee);
            InputGeneral.InputFunctionWithClear(FieldInputCreditScreeningFee, demo.MySpaceAmountPayments.CreditScreeningFeeStatic);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputHoldDeposit, demo.MySpaceAmountPayments.HoldDepositStatic);

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

        [AllureStep("OwnerOwnerAndTenantPaysCommissionWithBroker")]
        public NewBuilding SelectOwnerOwnerAndTenantPaysCommissionWithBroker()
        {
            WaitUntil.WaitSomeInterval(5000);
            Button.Click(ButtonMenuOwnerSelect);
            WaitUntil.WaitSomeInterval(5000);
            Button.Click(SetItemOwnerOwnerAndTenantPaysCommissionWithBroker());

            return this;
        }

        [AllureStep("SelectOwnerOwnerPaysWithBroker")]
        public NewBuilding SelectOwnerOwnerPaysWithBroker()
        {
            WaitUntil.WaitSomeInterval(5000);
            Button.Click(ButtonMenuOwnerSelect);
            WaitUntil.WaitSomeInterval(5000);
            Button.Click(SetOwnerOwnerPaysBroker());

            return this;
        }

        [AllureStep("SelectOwnerTenantPaysCommissionWithAgent")]
        public NewBuilding SelectOwnerTenantPaysCommissionWithAgent()
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
            InputGeneral.InputFunctionWithClear(FieldInputCustomNoteForAccess, building.TextLorem.TextLoremForPinCode);
            WaitUntil.WaitSomeInterval(100);
            ButtonSelectImageForAccess.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.IMAGE_BUILDING_LOCK_PIN_CODE));
            WaitUntil.SuccessCustomElementIsVisible(MessageSuccessUploadImageForAccess);
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
            InputGeneral.InputFunctionWithClear(FieldInputCustomNoteForAccess, building.TextLorem.TextLoremForNote);
            WaitUntil.WaitSomeInterval(100);
            ButtonSelectImageForAccess.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.IMAGE_BUILDING_LOCK_NOTE));
            WaitUntil.SuccessCustomElementIsVisible(MessageSuccessUploadImageForAccess);
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
            InputGeneral.InputFunctionWithClear(FieldInputNameSpecials, building.Concessions.NameFirst);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputMonthsFree, building.Concessions.OneMonthYearFree);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputLeaseTerms, building.Concessions.TwelveMonthsLeaseTerms);
            WaitUntil.WaitSomeInterval(100);
            KeyBoardActions.ClickArrowDown();
            KeyBoardActions.ClickEnterButton();
            InputGeneral.InputFunctionWithClear(FieldInputAdditionalInfo, building.AdditionalInfo.ShortInfo);
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
                .SelectCurrentYear();
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
            InputGeneral.InputFunctionWithClear(FieldInputMonthsFree, building.Concessions.RandomMonthsFree);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputLeaseTerms, building.Concessions.TwelveMonthsLeaseTerms);
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
            InputGeneral.InputFunctionWithClear(FieldInputNameSpecials, building.Concessions.NameFirst);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputMonthsFree, building.Concessions.TwoMonthsFree);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputLeaseTerms, building.Concessions.TwelveMonthsLeaseTerms);
            WaitUntil.WaitSomeInterval(100);
            KeyBoardActions.ClickArrowDown();
            KeyBoardActions.ClickEnterButton();
            InputGeneral.InputFunctionWithClear(FieldInputAdditionalInfo, building.AdditionalInfo.LongInfo);
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
            InputGeneral.InputFunctionWithClear(FieldInputNameSpecials, building.FreeStuff.NameFirst);
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
            InputGeneral.InputFunctionWithClear(FieldInputNameSpecials, building.FreeStuff.NameFirst);
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
