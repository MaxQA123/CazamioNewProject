using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using System;
using System.IO;

namespace CazamioNewProject.PageObjects.AdminPages.AddApartmentsPage
{
    public partial class AddApartments
    {
        [AllureStep("ClickTwiceButtonGeneralNext")]
        public AddApartments ClickTwiceButtonGeneralNext()
        {
            WaitUntil.CustomElementIsVisible(ButtonGeneralNext);
            WaitUntil.CustomElementIsClickable(ButtonGeneralNext);
            Button.Click(ButtonGeneralNext);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonGeneralNext);

            return this;
        }

        #region Tad units

        [AllureStep("SelectBuildingThirtyDashTrirtyNineCrownSt")]
        public AddApartments SelectBuildingThirtyDashTrirtyNineCrownSt()
        {
            WaitUntil.CustomElementIsVisible(ButtonBuildingName);
            WaitUntil.CustomElementIsClickable(ButtonBuildingName);
            Button.Click(ButtonBuildingName);
            WaitUntil.WaitSomeInterval(1000);
            Button.Click(SetItemBuildingThirtyDashTrirtyNineCrownSt());
            WaitUntil.WaitSomeInterval(2000);

            return this;
        }

        [AllureStep("SelectBuildingNineAAlbermaleRoad")]
        public AddApartments SelectBuildingNineAAlbermaleRoad()
        {
            WaitUntil.CustomElementIsVisible(LoaderHidden, 10);
            WaitUntil.WaitSomeInterval(5000);
            WaitUntil.CustomElementIsVisible(ButtonBuildingName);
            WaitUntil.CustomElementIsClickable(ButtonBuildingName);
            Button.Click(ButtonBuildingName);
            WaitUntil.WaitSomeInterval(1000);
            Button.Click(SetItemBuildingNineAAlbermaleRoad());
            WaitUntil.WaitSomeInterval(2000);

            return this;
        }

        [AllureStep("GetBuildingName")]
        public string GetBuildingName()
        {
            WaitUntil.CustomElementIsVisible(ButtonBuildingName);
            WaitUntil.CustomElementIsClickable(ButtonBuildingName);
            Button.Click(ButtonBuildingName);
            WaitUntil.WaitSomeInterval(2000);
            WaitUntil.CustomElementIsVisible(ButtonBuildingName);
            string getBuildingName = GetValueFromFieldBuildingName.Text;
            string getBuildingNameActual = getBuildingName.ToString();
            KeyBoardActions.ClickEnterButton();

            return getBuildingNameActual;

        }

        [AllureStep("EnterToAllFieldsOneWashingtonSquare")]
        public AddApartments EnterToAllFieldsOneWashingtonSquare()
        {
            WaitUntil.CustomElementIsVisible(FieldInputUnitNumber);
            InputGeneral.InputFunctionWithClear(FieldInputUnitNumber, apartment.UnitBasicData.UnitNumberTwoNumberLetterRandom);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputBedrooms, apartment.UnitBasicData.BedroomsOneNumberRandom);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputHalfBedrooms, apartment.UnitBasicData.HalfBedroomsOneStatic);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputBathrooms, apartment.UnitBasicData.BathroomsOneNumberRandom);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputHalfBathrooms, apartment.UnitBasicData.HalfBathroomsOneStatic);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputSqFoot, apartment.UnitBasicData.SqFootOneNubmer);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputLeasePrice, apartment.UnitBasicData.LeasePriceFourNumbersStatic);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputSecurityDeposit, apartment.UnitBasicData.SecurityDepositFourNumbersStatic);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputMonthlyRentsPrePayment, apartment.UnitBasicData.MonthlyRentsPrePaymentOne);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputFloor, apartment.UnitBasicData.FloorOneNumber);

            return this;
        }

        [AllureStep("EnterToAllFieldsThirtyDashThirtyNineCrownSt")]
        public AddApartments EnterToAllFieldsThirtyDashThirtyNineCrownSt()
        {
            WaitUntil.CustomElementIsVisible(FieldInputUnitNumber);
            InputGeneral.InputFunctionWithClear(FieldInputUnitNumber, apartment.UnitBasicData.UnitNumberFourAlphabetRandom);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputBedrooms, apartment.UnitBasicData.BedroomsTwoNumbersRandom);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputHalfBedrooms, apartment.UnitBasicData.HalfBedroomsTwoStatic);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputBathrooms, apartment.UnitBasicData.BathroomsZeroNumberStatic);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputHalfBathrooms, apartment.UnitBasicData.HalfBathroomsTwoStatic);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputSqFoot, apartment.UnitBasicData.SqFootFourNubmers);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputLeasePrice, apartment.UnitBasicData.LeasePriceFourNumbersRandom);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputSecurityDeposit, apartment.UnitBasicData.SecurityDepositFourNumbers);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputMonthlyRentsPrePayment, apartment.UnitBasicData.MonthlyRentsPrePaymentTwo);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputFloor, apartment.UnitBasicData.FloorTwoNumbers);

            return this;
        }

        [AllureStep("EnterDataInFieldsNineAAlbermaleRoad")]
        public AddApartments EnterDataInFieldsNineAAlbermaleRoad()
        {
            WaitUntil.CustomElementIsVisible(FieldInputUnitNumber);
            InputGeneral.InputFunctionWithClear(FieldInputUnitNumber, apartment.UnitBasicData.UnitNumberMaxNumbersAlphabetRandom);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputBedrooms, apartment.UnitBasicData.BedroomsTwoNumbersRandom);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputHalfBedrooms, apartment.UnitBasicData.HalfBedroomsOneStatic);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputBathrooms, apartment.UnitBasicData.BathroomsTwoNumberStatic);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputHalfBathrooms, apartment.UnitBasicData.HalfBathroomsOneStatic);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputSqFoot, apartment.UnitBasicData.SqFootThreeNubmers);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputLeasePrice, apartment.UnitBasicData.LeasePriceFiveNumbersRandom);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputSecurityDeposit, apartment.UnitBasicData.SecurityDepositFourNumbers);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputMonthlyRentsPrePayment, apartment.UnitBasicData.MonthlyRentsPrePaymentTwo);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputFloor, apartment.UnitBasicData.FloorThreeNumbers);

            return this;
        }

        [AllureStep("EnterMandatoryFieldsNineNineNineEightSaintJohnsonPlace")]
        public AddApartments EnterMandatoryFieldsNineNineNineEightSaintJohnsonPlace()
        {
            WaitUntil.CustomElementIsVisible(FieldInputUnitNumber);
            InputGeneral.InputFunctionWithClear(FieldInputUnitNumber, apartment.UnitBasicData.UnitNumberFourNumbersRandom);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputBedrooms, apartment.UnitBasicData.BedroomsTwoNumberStatic);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputBathrooms, apartment.UnitBasicData.BathroomsOneNumberRandom);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputLeasePrice, apartment.UnitBasicData.LeasePriceThreeNumbersStatic);
            WaitUntil.WaitSomeInterval(100);

            return this;
        }

        [AllureStep("EnterDataForOneOneOneAEastStPedestrianCrossing")]
        public AddApartments EnterDataForOneOneOneAEastStPedestrianCrossing()
        {
            WaitUntil.CustomElementIsVisible(FieldInputUnitNumber);
            InputGeneral.InputFunctionWithClear(FieldInputUnitNumber, apartment.UnitBasicData.UnitNumberMaxNumbersAlphabetRandom);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputBedrooms, apartment.UnitBasicData.BedroomsTwoNumberStatic);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputBathrooms, apartment.UnitBasicData.BathroomsOneNumberStatic);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputLeasePrice, apartment.UnitBasicData.LeasePriceFourNumbersRandom);
            WaitUntil.WaitSomeInterval(100);

            return this;
        }

        [AllureStep("EnterFullDataForOneOneOneAEastStPedestrianCrossing")]
        public AddApartments EnterFullDataForOneOneOneAEastStPedestrianCrossing()
        {
            WaitUntil.CustomElementIsVisible(FieldInputUnitNumber);
            InputGeneral.InputFunctionWithClear(FieldInputUnitNumber, apartment.UnitBasicData.UnitNumberTwoNumberLetterRandom);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputBedrooms, apartment.UnitBasicData.BedroomsZeroNumberStatic);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputHalfBedrooms, apartment.UnitBasicData.HalfBedroomsOneStatic);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputBathrooms, apartment.UnitBasicData.BathroomsOneNumberStatic);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputHalfBathrooms, apartment.UnitBasicData.BathroomsOneNumberStatic);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputSqFoot, apartment.UnitBasicData.SqFootZero);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputLeasePrice, apartment.UnitBasicData.LeasePriceFourNumbersStatic);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputSecurityDeposit, apartment.UnitBasicData.SecurityDepositFourNumbersStatic);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputMonthlyRentsPrePayment, apartment.UnitBasicData.MonthlyRentsPrePaymentZero);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputFloor, apartment.UnitBasicData.FloorZero);
            WaitUntil.WaitSomeInterval(100);

            return this;
        }

        [AllureStep("EnterMandatoryFieldsThirtyDashThirtyNineCrownSt")]
        public AddApartments EnterMandatoryFieldsThirtyDashThirtyNineCrownSt()
        {
            WaitUntil.CustomElementIsVisible(FieldInputUnitNumber);
            InputGeneral.InputFunctionWithClear(FieldInputUnitNumber, apartment.UnitBasicData.UnitNumberFourAlphabetRandom);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputBedrooms, apartment.UnitBasicData.BedroomsTwoNumberStatic);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputBathrooms, apartment.UnitBasicData.BathroomsTwoNumberStatic);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputLeasePrice, apartment.UnitBasicData.LeasePriceFourNumbersStatic);
            WaitUntil.WaitSomeInterval(100);

            return this;
        }

        [AllureStep("SelectStatusOffMarket")]
        public AddApartments SelectStatusOffMarket()
        {
            WaitUntil.CustomElementIsVisible(ButtonApartmentStatus);
            WaitUntil.CustomElementIsClickable(ButtonApartmentStatus);
            Button.Click(ButtonApartmentStatus);
            WaitUntil.CustomElementIsVisible(ItemOffMarket);
            WaitUntil.CustomElementIsClickable(ItemOffMarket);
            Button.Click(ItemOffMarket);

            return this;
        }

        [AllureStep("SelectStatusOccupied")]
        public AddApartments SelectStatusOccupied()
        {
            WaitUntil.CustomElementIsVisible(ButtonApartmentStatus);
            WaitUntil.CustomElementIsClickable(ButtonApartmentStatus);
            Button.Click(ButtonApartmentStatus);
            WaitUntil.CustomElementIsVisible(ItemOccupied);
            WaitUntil.CustomElementIsClickable(ItemOccupied);
            Button.Click(ItemOccupied);

            return this;
        }

        [AllureStep("SelectStatusVacant")]
        public AddApartments SelectStatusVacant()
        {
            WaitUntil.CustomElementIsVisible(ButtonApartmentStatus);
            WaitUntil.CustomElementIsClickable(ButtonApartmentStatus);
            Button.Click(ButtonApartmentStatus);
            WaitUntil.CustomElementIsVisible(ItemVacant);
            WaitUntil.CustomElementIsClickable(ItemVacant);
            Button.Click(ItemVacant);

            return this;
        }

        [AllureStep("SelectStatusDepositReceived")]
        public AddApartments SelectStatusDepositReceived()
        {
            WaitUntil.CustomElementIsVisible(ButtonApartmentStatus);
            WaitUntil.CustomElementIsClickable(ButtonApartmentStatus);
            Button.Click(ButtonApartmentStatus);
            WaitUntil.CustomElementIsVisible(ItemDepositReceived);
            WaitUntil.CustomElementIsClickable(ItemDepositReceived);
            Button.Click(ItemDepositReceived);

            return this;
        }

        [AllureStep("SelectStatusApplicationSubmitted")]
        public AddApartments SelectStatusApplicationSubmitted()
        {
            WaitUntil.CustomElementIsVisible(ButtonApartmentStatus);
            WaitUntil.CustomElementIsClickable(ButtonApartmentStatus);
            Button.Click(ButtonApartmentStatus);
            WaitUntil.CustomElementIsVisible(ItemApplicationSubmitted);
            WaitUntil.CustomElementIsClickable(ItemApplicationSubmitted);
            Button.Click(ItemApplicationSubmitted);

            return this;
        }

        [AllureStep("SelectStatusSignedLease")]
        public AddApartments SelectStatusSignedLease()
        {
            WaitUntil.CustomElementIsVisible(ButtonApartmentStatus);
            WaitUntil.CustomElementIsClickable(ButtonApartmentStatus);
            Button.Click(ButtonApartmentStatus);
            WaitUntil.CustomElementIsVisible(ItemSignedLease);
            WaitUntil.CustomElementIsClickable(ItemSignedLease);
            Button.Click(ItemSignedLease);

            return this;
        }

        [AllureStep("SelectAgentAddAprtmntsUnitsPage")]
        public AddApartments SelectAgentAddAprtmntsUnitsPage()
        {
            WaitUntil.CustomElementIsVisible(ButtonAssignedAgent);
            Button.Click(ButtonAssignedAgent);
            KeyBoardActions.ClickArrowDown();
            KeyBoardActions.ClickEnterButton();

            return this;
        }

        [AllureStep("SelectAgent")]
        public AddApartments SelectAgent()
        {
            WaitUntil.CustomElementIsVisible(ButtonAssignedAgent);
            WaitUntil.CustomElementIsClickable(ButtonAssignedAgent);
            Button.Click(ButtonAssignedAgent);
            WaitUntil.WaitSomeInterval(1000);
            Button.Click(SetItemAgent());

            return this;
        }

        [AllureStep("SelectCurrentDateAvailableFrom")]
        public AddApartments SelectCurrentDateAvailableFrom()
        {
            WaitUntil.CustomElementIsVisible(FieldInputAvailableFrom);
            Button.Click(FieldInputAvailableFrom);
            WaitUntil.WaitSomeInterval(100);
            Pages.DatePicker
                .SelectCurrentDay();

            return this;
        }

        [AllureStep("SelectCurrentDatePlusOneDayAvailableFrom")]
        public AddApartments SelectCurrentDatePlusOneDayAvailableFrom()
        {
            WaitUntil.CustomElementIsVisible(FieldInputAvailableFrom);
            Button.Click(FieldInputAvailableFrom);
            WaitUntil.WaitSomeInterval(100);
            Pages.DatePicker
                .SelectCurrentDayPlusOneDay();

            return this;
        }

        [AllureStep("SetFirstDayLastMonthsAvailableFrom")]
        public AddApartments SetFirstDayLastMonthsAvailableFrom()
        {
            WaitUntil.CustomElementIsVisible(FieldInputAvailableFrom);
            Button.Click(FieldInputAvailableFrom);
            WaitUntil.WaitSomeInterval(100);
            Pages.DatePicker
                .ClickButtonDropDownYearMonth()
                .SelectCurrentYear();
            Pages.DatePicker
                .SelectLastMonth();
            Pages.DatePicker
                .SelectFisrtDayInLastMonth();

            return this;
        }

        [AllureStep("SetFirstDayNextMonthsAvailableFrom")]
        public AddApartments SetFirstDayNextMonthsAvailableFrom()
        {
            WaitUntil.CustomElementIsVisible(FieldInputAvailableFrom);
            Button.Click(FieldInputAvailableFrom);
            WaitUntil.WaitSomeInterval(100);
            Pages.DatePicker
                .ClickButtonDropDownYearMonth()
                .SelectNextYear();
            Pages.DatePicker
                .SelectNextMonth();
            Pages.DatePicker
                .SelectFisrtDayInNextMonth();

            return this;
        }

        [AllureStep("SelectApartmentTypeMultiFamily")]
        public AddApartments SelectApartmentTypeMultiFamily()
        {
            WaitUntil.CustomElementIsVisible(ButtonApartmentType);
            Button.Click(ButtonApartmentType);
            WaitUntil.CustomElementIsVisible(ItemMultiFamily);
            WaitUntil.CustomElementIsClickable(ItemMultiFamily);
            Button.Click(ItemMultiFamily);

            return this;
        }

        [AllureStep("SelectApartmentTypeDuplex")]
        public AddApartments SelectApartmentTypeDuplex()
        {
            WaitUntil.CustomElementIsVisible(ButtonApartmentType);
            Button.Click(ButtonApartmentType);
            WaitUntil.CustomElementIsVisible(ItemDuplex);
            WaitUntil.CustomElementIsClickable(ItemDuplex);
            Button.Click(ItemDuplex);

            return this;
        }

        [AllureStep("SelectApartmentTypePlex")]
        public AddApartments SelectApartmentTypePlex()
        {
            WaitUntil.CustomElementIsVisible(ButtonApartmentType);
            Button.Click(ButtonApartmentType);
            WaitUntil.CustomElementIsVisible(ItemPlex);
            WaitUntil.CustomElementIsClickable(ItemPlex);
            Button.Click(ItemPlex);

            return this;
        }

        [AllureStep("SelectApartmentTypeSingleFamily")]
        public AddApartments SelectApartmentTypeSingleFamily()
        {
            WaitUntil.CustomElementIsVisible(ButtonApartmentType);
            Button.Click(ButtonApartmentType);
            WaitUntil.CustomElementIsVisible(ItemSingleFamily);
            WaitUntil.CustomElementIsClickable(ItemSingleFamily);
            Button.Click(ItemSingleFamily);

            return this;
        }

        [AllureStep("SelectApartmentTypeLoft")]
        public AddApartments SelectApartmentTypeLoft()
        {
            WaitUntil.CustomElementIsVisible(ButtonApartmentType);
            Button.Click(ButtonApartmentType);
            WaitUntil.CustomElementIsVisible(ItemLoft);
            WaitUntil.CustomElementIsClickable(ItemLoft);
            Button.Click(ItemLoft);

            return this;
        }

        [AllureStep("EnterLongDescriptionInternalNotes")]
        public AddApartments EnterLongDescriptionInternalNotes()
        {
            WaitUntil.CustomElementIsVisible(FieldInputDescription);
            InputGeneral.InputFunctionWithClear(FieldInputDescription, apartment.DescriptionsInternalNotes.DescriptionLong);
            WaitUntil.CustomElementIsVisible(FieldInputInternalNotes);
            InputGeneral.InputFunctionWithClear(FieldInputInternalNotes, apartment.DescriptionsInternalNotes.InternalNotesLong);

            return this;
        }

        [AllureStep("EnterShortDescriptionInternalNotes")]
        public AddApartments EnterShortDescriptionInternalNotes()
        {
            WaitUntil.CustomElementIsVisible(FieldInputDescription);
            InputGeneral.InputFunctionWithClear(FieldInputDescription, apartment.DescriptionsInternalNotes.DescriptionShort);
            WaitUntil.CustomElementIsVisible(FieldInputInternalNotes);
            InputGeneral.InputFunctionWithClear(FieldInputInternalNotes, apartment.DescriptionsInternalNotes.InternalNotesShort);

            return this;
        }

        [AllureStep("SetOneYearRentalTerms")]
        public AddApartments SetOneYearRentalTerms()
        {
            Button.Click(ButtonTwelveMonths);
            InputGeneral.InputFunctionWithClear(FieldInputRentalTermsFirstValue, apartment.UnitBasicData.RentalTermsOneYear);
            KeyBoardActions.ClickEnterButton();
            return this;
        }

        [AllureStep("SetOneYearRentalTerms")]
        public AddApartments SetSomeItemsRentalTerms()
        {
            Button.Click(FieldInputRentalTermsFirstValue);
            InputGeneral.InputFunctionWithClear(FieldInputRentalTermsFirstValue, apartment.UnitBasicData.RentalTermsOneMonth);
            KeyBoardActions.ClickEnterButton();
            WaitUntil.WaitSomeInterval(100);
            Button.Click(FieldInputRentalTermsFirstValue);
            InputGeneral.InputFunctionWithClear(FieldInputRentalTermsFirstValue, apartment.UnitBasicData.RentalTermsSixMonths);
            KeyBoardActions.ClickEnterButton();
            Button.Click(FieldInputRentalTermsFirstValue);
            InputGeneral.InputFunctionWithClear(FieldInputRentalTermsFirstValue, apartment.UnitBasicData.RentalTermsEighteenMonths);
            KeyBoardActions.ClickEnterButton();
            KeyBoardActions.ClickArrowDown();
            KeyBoardActions.ClickEnterButton();
            return this;
        }

        [AllureStep("EnterTenMonthsRentalTerms")]
        public AddApartments EnterTenMonthsRentalTerms()
        {
            WaitUntil.CustomElementIsVisible(ButtonApartmentStatus);
            WaitUntil.CustomElementIsClickable(ButtonApartmentStatus);
            Button.Click(ButtonTwelveMonths);
            InputGeneral.InputFunctionWithClear(FieldInputRentalTermsFirstValue, apartment.UnitBasicData.RentalTermsTenMonths);
            KeyBoardActions.ClickEnterButton();
            KeyBoardActions.ClickArrowDown();
            KeyBoardActions.ClickEnterButton();
            return this;
        }

        [AllureStep("AddItemSocialSecurityCardRequiredDoc")]
        public AddApartments AddItemSocialSecurityCardRequiredDoc()
        {
            Button.Click(ButtonRequiredDocuments);
            WaitUntil.CustomElementIsVisible(ItemSocialSecurityCardRequiredDoc);
            Button.Click(ItemSocialSecurityCardRequiredDoc);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonRequiredDocuments);

            return this;
        }

        #endregion

        #region Tab Amenities

        [AllureStep("SelectFiveAmenities")]
        public AddApartments SelectFiveAmenities()
        {
            ClickFieldInputSearchForAmenities();
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");

            return this;
        }

        [AllureStep("SelectFourtyFourAmenities")]
        public AddApartments SelectFourtyFourAmenities()
        {
            ClickFieldInputSearchForAmenities();
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");

            return this;
        }

        [AllureStep("SelectThreeAmenitiesIncludedInMonthlyRent")]
        public AddApartments SelectThreeAmenitiesIncludedInMonthlyRent()
        {
            ClickFieldInputSearchForDefaultIncludedInMonthlyRentAmenities();
            Button.Click(ItemHeatIncluded);
            Button.Click(ItemHotWaterIncluded);
            Button.Click(ItemNetflixIncluded);
            Button.Click(ItemSewerIncluded);
            Button.Click(ItemWifiIncluded);
            Button.Click(ItemWaterIncluded);
            Button.Click(ItemSmartHubIncluded);
            Button.Click(ItemElectricIncluded);
            Button.Click(ItemGasIncluded);

            return this;
        }

        [AllureStep("SelectAllAmenitiesIncludedInMonthlyRent")]
        public AddApartments SelectAllAmenitiesIncludedInMonthlyRent()
        {
            ClickFieldInputSearchForDefaultIncludedInMonthlyRentAmenities();
            Button.Click(ItemHeatIncluded);
            Button.Click(ItemHotWaterIncluded);
            Button.Click(ItemNetflixIncluded);
            Button.Click(ItemSewerIncluded);
            Button.Click(ItemWifiIncluded);
            Button.Click(ItemWaterIncluded);
            Button.Click(ItemSmartHubIncluded);
            Button.Click(ItemElectricIncluded);
            Button.Click(ItemGasIncluded);

            return this;
        }

        #endregion

        #region Tab Access

        [AllureStep("AddItemAccessTypePinCode")]
        public AddApartments AddItemAccessTypePinCode()
        {
            WaitUntil.WaitSomeInterval(3000);
            WaitUntil.CustomElementIsVisible(ButtonAccessType);
            Button.Click(ButtonAccessType);
            WaitUntil.WaitSomeInterval(1000);
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
            InputGeneral.InputFunctionWithClear(FieldInputCustomNoteForAccess, apartment.AccessLocks.PincodeLongText);
            WaitUntil.WaitSomeInterval(100);
            ButtonSelectImageForAccess.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.IMAGE_APARTMENT_LOCK_PIN_CODE));
            WaitUntil.SuccessCustomElementIsVisible(MessageSuccessUploadImageForAccess);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonSaveForLock);

            return this;
        }

        [AllureStep("AddItemAccessTypePinCodeWithoutImage")]
        public AddApartments AddItemAccessTypePinCodeWithoutImage()
        {
            WaitUntil.WaitSomeInterval(3000);
            WaitUntil.CustomElementIsVisible(ButtonAccessType);
            Button.Click(ButtonAccessType);
            WaitUntil.WaitSomeInterval(1000);
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
            InputGeneral.InputFunctionWithClear(FieldInputCustomNoteForAccess, apartment.AccessLocks.PincodeLongText);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonSaveForLock);

            return this;
        }

        [AllureStep("AddItemAccessTypeNote")]
        public AddApartments AddItemAccessTypeNote()
        {
            WaitUntil.WaitSomeInterval(3000);
            WaitUntil.CustomElementIsVisible(ButtonAccessType);
            Button.Click(ButtonAccessType);
            WaitUntil.WaitSomeInterval(1000);
            Button.Click(ItemNote);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputCustomNoteForAccess, apartment.AccessLocks.NoteLongText);
            WaitUntil.WaitSomeInterval(100);
            ButtonSelectImageForAccess.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.IMAGE_APARTMENT_LOCK_NOTE));
            WaitUntil.SuccessCustomElementIsVisible(MessageSuccessUploadImageForAccess);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonSaveForLock);

            return this;
        }

        [AllureStep("AddItemAccessTypeNoteWithoutImage")]
        public AddApartments AddItemAccessTypeNoteWithoutImage()
        {
            WaitUntil.WaitSomeInterval(3000);
            WaitUntil.CustomElementIsVisible(ButtonAccessType);
            Button.Click(ButtonAccessType);
            WaitUntil.WaitSomeInterval(1000);
            Button.Click(ItemNote);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputCustomNoteForAccess, apartment.AccessLocks.NoteLongText);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonSaveForLock);

            return this;
        }

        [AllureStep("AddItemAccessTypeExistingOccupant")]
        public AddApartments AddItemAccessTypeExistingOccupant()
        {
            WaitUntil.WaitSomeInterval(3000);
            WaitUntil.CustomElementIsVisible(ButtonAccessType);
            Button.Click(ButtonAccessType);
            WaitUntil.WaitSomeInterval(1000);
            Button.Click(ItemExistingOccupant);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputName, tenantCreatorMySpace.FirstLastNameGeneralData.RandomFirstName);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputEmail, tenantCreatorMySpace.Emails.RandomEmail);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputPhoneNumber, GenerateRandomData.RandomPhoneNumber(10));
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputNote, apartment.AccessLocks.ExistingOccupantLongText);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonSaveForLock);

            return this;
        }

        #endregion

        #region Tab Specials

        [AllureStep("AddConcessionIsActive")]
        public AddApartments AddConcessionIsActive()
        {
            WaitUntil.CustomElementIsVisible(FieldInputNameSpecials);
            WaitUntil.CustomElementIsClickable(FieldInputNameSpecials);
            InputGeneral.InputFunctionWithClear(FieldInputNameSpecials, apartment.SettingsConcessions.NameFirst);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputMonthsFree, apartment.SettingsConcessions.OneMonthYearFree);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputLeaseTerms, apartment.SettingsConcessions.TwelveMonthsLeaseTerms);
            WaitUntil.WaitSomeInterval(100);
            KeyBoardActions.ClickArrowDown();
            KeyBoardActions.ClickEnterButton();
            InputGeneral.InputFunctionWithClear(FieldInputAdditionalInfo, apartment.SettingsConcessions.AdditionalInfoLong);
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
        public AddApartments AddConcessionIsActiveWithoutName()
        {
            WaitUntil.CustomElementIsVisible(FieldInputNameSpecials);
            WaitUntil.CustomElementIsClickable(FieldInputNameSpecials);
            InputGeneral.InputFunctionWithClear(FieldInputMonthsFree, apartment.SettingsConcessions.TwoMonthsFree);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputLeaseTerms, apartment.SettingsConcessions.RandomLeaseTerms);
            WaitUntil.WaitSomeInterval(100);
            KeyBoardActions.ClickArrowDown();
            KeyBoardActions.ClickEnterButton();
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonSaveSpecials);

            return this;
        }

        [AllureStep("AddConcessionInActive")]
        public AddApartments AddConcessionInActive()
        {
            WaitUntil.CustomElementIsVisible(CheckBoxIsActive);
            WaitUntil.ElementIsClickable(CheckBoxIsActive);
            Button.Click(CheckBoxIsActive);
            WaitUntil.CustomElementIsVisible(FieldInputNameSpecials);
            InputGeneral.InputFunctionWithClear(FieldInputNameSpecials, apartment.SettingsConcessions.NameFirst);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputMonthsFree, apartment.SettingsConcessions.TwoMonthsFree);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputLeaseTerms, apartment.SettingsConcessions.OneMonthYearFree);
            WaitUntil.WaitSomeInterval(100);
            KeyBoardActions.ClickArrowDown();
            KeyBoardActions.ClickArrowDown();
            KeyBoardActions.ClickEnterButton();
            InputGeneral.InputFunctionWithClear(FieldInputAdditionalInfo, apartment.SettingsConcessions.AdditionalInfoShort);
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

        [AllureStep("AddFreeStuffIsActive")]
        public AddApartments AddFreeStuffIsActive()
        {
            WaitUntil.CustomElementIsVisible(FieldInputNameSpecials);
            WaitUntil.CustomElementIsClickable(FieldInputNameSpecials);
            InputGeneral.InputFunctionWithClear(FieldInputNameSpecials, apartment.SettingsFreeStuff.NameFirst);
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
               .ClickButtonDropDownYearMonth()
               .SelectNextYear();
            Pages.DatePicker
                .SelectNextMonth();
            Pages.DatePicker
                .SelectFisrtDayInNextMonth();
            //Pages.DatePicker
            //    .SelectCurrentDay();
            WaitUntil.WaitSomeInterval(100);
            KeyBoardActions.ScrollToDown();
            Button.Click(ButtonLeaseSignedTriggerEvent);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonSaveSpecials);

            return this;
        }

        [AllureStep("AddFreeStuffIsActiveWithoutName")]
        public AddApartments AddFreeStuffIsActiveWithoutName()
        {
            WaitUntil.CustomElementIsVisible(FieldInputNameSpecials);
            WaitUntil.CustomElementIsClickable(FieldInputNameSpecials);
            Button.Click(FieldInputSelectItemsFreeStuff);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ItemFreeNetflix);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ItemGoogleSpeaker);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonSaveSpecials);

            return this;
        }

        [AllureStep("AddFreeStuffInActive")]
        public AddApartments AddFreeStuffInActive()
        {
            WaitUntil.CustomElementIsVisible(CheckBoxIsActive);
            WaitUntil.ElementIsClickable(CheckBoxIsActive);
            Button.Click(CheckBoxIsActive);
            WaitUntil.CustomElementIsVisible(FieldInputNameSpecials);
            InputGeneral.InputFunctionWithClear(FieldInputNameSpecials, apartment.SettingsFreeStuff.NameFirst);
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

        #region Tab Images

        [AllureStep("ClickEightTimesButtonRemove")]
        public AddApartments ClickEightTimesButtonRemove()
        {
            WaitUntil.CustomElementIsVisible(ButtonRemoveFile);
            WaitUntil.CustomElementIsClickable(ButtonRemoveFile);
            Button.Click(ButtonRemoveFile);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonRemoveFile);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonRemoveFile);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonRemoveFile);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonRemoveFile);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonRemoveFile);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonRemoveFile);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonRemoveFile);

            return this;
        }

        [AllureStep("UplodImagesFileEnterLinksYouTubeVimeo")]
        public AddApartments UplodImagesFileEnterLinksYouTubeVimeo()
        {
            ButtonBrowseFiles.SendKeys(Path.GetFullPath(Path.Combine(Browser.RootPath() + UploadImages.IMAGE_APARTMENT_FIRST) + "\n" +
                                                                      Browser.RootPath() + UploadImages.IMAGE_APARTMENT_SECOND + "\n" +
                                                                      Browser.RootPath() + UploadImages.IMAGE_APARTMENT_THIRD + "\n" +
                                                                      Browser.RootPath() + UploadImages.IMAGE_APARTMENT_FOURTH + "\n" +
                                                                      Browser.RootPath() + UploadImages.IMAGE_APARTMENT_FIFTH));
            WaitUntil.WaitSomeInterval(5000);
            Pages.SelectorVideosMdlWndw
                .UploadFileEnterLinksYouTubeVimeo();
            WaitUntil.WaitSomeInterval(10000);

            return this;
        }

        [AllureStep("UplodFileVideoEnterLinksYouTubeVimeo")]
        public AddApartments UplodFileVideoEnterLinksYouTubeVimeo()
        {
            WaitUntil.WaitSomeInterval(5000);
            Pages.SelectorVideosMdlWndw
                .UploadFileEnterLinksYouTubeVimeo();
            WaitUntil.WaitSomeInterval(10000);

            return this;
        }

        [AllureStep("UploadOneFileVideo")]
        public AddApartments UploadOneFileVideo()
        {
            KeyBoardActions.ScrollToDown();
            WaitUntil.WaitSomeInterval(5000);
            Pages.SelectorVideosMdlWndw
                .UploadFileVideo();
            WaitUntil.WaitSomeInterval(10000);

            return this;
        }

        [AllureStep("SetLinksYouTubeVimeo")]
        public AddApartments SetLinksYouTubeVimeo()
        {
            WaitUntil.WaitSomeInterval(5000);
            Pages.SelectorVideosMdlWndw
                .EnterLinksYouTubeVimeo();
            WaitUntil.WaitSomeInterval(10000);

            return this;
        }

        #endregion
    }
}
