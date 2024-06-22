using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.AdminPages.AddApartmentsPage
{
    public partial class AddApartments
    {
        #region Tad units

        [AllureStep("GetBuildingName")]
        public string GetBuildingName()
        {
            WaitUntil.CustomElementIsVisible(ButtonBuildingNameAddApartmentsUnitsPage);
            WaitUntil.CustomElementIsClickable(ButtonBuildingNameAddApartmentsUnitsPage);
            Button.Click(ButtonBuildingNameAddApartmentsUnitsPage);
            WaitUntil.WaitSomeInterval(2000);
            WaitUntil.CustomElementIsVisible(ButtonBuildingNameAddApartmentsUnitsPage);
            string getBuildingName = GetValueFromFieldBuildingName.Text;
            string getBuildingNameActual = getBuildingName.ToString();
            KeyBoardActions.ClickEnterButton();

            return getBuildingNameActual;

        }

        [AllureStep("EnterToAllFieldsMarkAdmAssignedBrkrOneNumber")]
        public AddApartments EnterToAllFieldsMarkAdmAssignedBrkrOneNumber()
        {
            WaitUntil.CustomElementIsVisible(FieldInputUnitNumber);
            InputGeneral.InputFunctionWithClear(FieldInputUnitNumber, apartment.UnitNumber.UnitNumberMarkAdmAssignedRoleBrkr);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputBedrooms, apartment.Bedrooms.OneNumber);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputHalfBedrooms, apartment.HalfBedrooms.OneNumber);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputBathrooms, apartment.Bathrooms.OneNumber);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputHalfBathrooms, apartment.HalfBathrooms.OneNumber);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputSqFoot, apartment.SqFoot.OneNumber);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputLeasePrice, apartment.LeasePrice.OneNumber);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputSecurityDeposit, apartment.SecurityDeposit.OneNumber);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputMonthlyRentsPrePayment, apartment.MonthlyRentsPrePayment.OneNumber);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputFloor, apartment.Floor.OneNumber);


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

        [AllureStep("EnterDescriptionInternalNotes")]
        public AddApartments EnterDescriptionInternalNotes()
        {
            WaitUntil.CustomElementIsVisible(FieldInputDescription);
            InputGeneral.InputFunctionWithClear(FieldInputDescription, apartment.TextVariable.TextLongDescription);
            WaitUntil.CustomElementIsVisible(FieldInputInternalNotes);
            InputGeneral.InputFunctionWithClear(FieldInputInternalNotes, apartment.TextVariable.TextLongInternalNotes);

            return this;
        }

        #endregion

        #region Tab Amenities

        [AllureStep("SelectFiveAmenities")]
        public AddApartments SelectFiveAmenities()
        {
            ClickFieldInputSearchForAmenities();
            WaitUntil.WaitSomeInterval(5000);
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");
            SelectAmenitiesForApartment(ListOfAmenitiesForApartmentAdminsPage.FIRST_TAG, " ");

            return this;
        }

        [AllureStep("SelectAllAmenitiesIncludedInMonthlyRent")]
        public AddApartments SelectAllAmenitiesIncludedInMonthlyRent()
        {
            ClickFieldInputSearchForDefaultIncludedInMonthlyRentAmenities();
            WaitUntil.WaitSomeInterval(5000);
            SelectIncludedInMonthlyRentAmenity(ListOfAmenitiesForApartmentIncludedInMonthlyRent.FIRST_TAG, " ");
            SelectIncludedInMonthlyRentAmenity(ListOfAmenitiesForApartmentIncludedInMonthlyRent.FIRST_TAG, " ");
            SelectIncludedInMonthlyRentAmenity(ListOfAmenitiesForApartmentIncludedInMonthlyRent.FIRST_TAG, " ");
            SelectIncludedInMonthlyRentAmenity(ListOfAmenitiesForApartmentIncludedInMonthlyRent.FIRST_TAG, " ");
            SelectIncludedInMonthlyRentAmenity(ListOfAmenitiesForApartmentIncludedInMonthlyRent.FIRST_TAG, " ");

            return this;
        }

        #endregion
    }
}
