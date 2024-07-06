using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.AddApartmentsPage
{
    public partial class AddApartments
    {
        [FindsBy(How = How.XPath, Using = ("//div[text() = 'Add Apartments']"))]
        public IWebElement TitleAddApartmentsPage;

        #region TabUnits

        public IWebElement ItemFullNameAgent;

        public IWebElement SetItemAgent()
        {
            // Создание экземпляра класса Owner
            Agent agent = new Agent().Generate();

            // Использование переменной экземпляра owner для построения XPath
            var xpath = "//span[text() = '" + agent.FullNameCreatedAgentMySpace.FirstAgent + "']";

            // Присвоение значения ItemForAutotestForBroker
            return Browser._Driver.FindElement(By.XPath(xpath));
        }

        #region ListOfTabs

        [FindsBy(How = How.XPath, Using = "//a[text() = 'Amenities']")]
        public IWebElement TabAmenities;

        [FindsBy(How = How.XPath, Using = "//a[text() = 'Access']")]
        public IWebElement TabAccess;

        [FindsBy(How = How.XPath, Using = "//a[text() = 'Specials']")]
        public IWebElement TabSpecials;

        [FindsBy(How = How.XPath, Using = "//a[text() = 'Images']")]
        public IWebElement TabImages;

        #endregion

        [FindsBy(How = How.XPath, Using = ("//ng-select[@bindlabel = 'buildingName']//div[@aria-haspopup = 'listbox']"))]
        public IWebElement ButtonBuildingNameAddApartmentsUnitsPage;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'unit']"))]
        public IWebElement FieldInputUnitNumber;

        [FindsBy(How = How.XPath, Using = ("//div[@aria-selected = 'true']//span"))]
        public IWebElement GetValueFromFieldBuildingName;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'bedrooms']"))]
        public IWebElement FieldInputBedrooms;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'half-bedrooms']"))]
        public IWebElement FieldInputHalfBedrooms;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'bathrooms']"))]
        public IWebElement FieldInputBathrooms;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'half-bathrooms']"))]
        public IWebElement FieldInputHalfBathrooms;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'sqFoot']"))]
        public IWebElement FieldInputSqFoot;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'leastPrice']"))]
        public IWebElement FieldInputLeasePrice;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'depositPrice']"))]
        public IWebElement FieldInputSecurityDeposit;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'paidMonths']"))]
        public IWebElement FieldInputMonthlyRentsPrePayment;

        [FindsBy(How = How.XPath, Using = ("//input[@id = 'floor']"))]
        public IWebElement FieldInputFloor;

        [FindsBy(How = How.XPath, Using = ("//ng-select[@formcontrolname = 'status']"))]
        public IWebElement ButtonApartmentStatus;

        [FindsBy(How = How.XPath, Using = ("//ng-select[@formcontrolname = 'status']//div[@aria-selected= 'true']//span"))]
        public IWebElement InputStatus;

        [FindsBy(How = How.XPath, Using = ("//div/span[text() = 'Off market']"))]
        public IWebElement ItemOffMarket;

        [FindsBy(How = How.XPath, Using = ("//div/span[text() = 'Occupied']"))]
        public IWebElement ItemOccupied;

        [FindsBy(How = How.XPath, Using = ("//div/span[text() = 'Vacant']"))]
        public IWebElement ItemVacant;

        [FindsBy(How = How.XPath, Using = ("//div/span[text() = 'Deposit Received']"))]
        public IWebElement ItemDepositReceived;

        [FindsBy(How = How.XPath, Using = ("//div/span[text() = 'Application submitted']"))]
        public IWebElement ItemApplicationSubmitted;

        [FindsBy(How = How.XPath, Using = ("//div/span[text() = 'Signed lease']"))]
        public IWebElement ItemSignedLease;

        [FindsBy(How = How.XPath, Using = ("//ng-select[@formcontrolname = 'broker']"))]
        public IWebElement ButtonAssignedAgent;

        [FindsBy(How = How.XPath, Using = ("//input[@formcontrolname = 'availableFrom']"))]
        public IWebElement FieldInputAvailableFrom;

        [FindsBy(How = How.XPath, Using = ("//ng-select[@formcontrolname = 'apartmentType']"))]
        public IWebElement ButtonApartmentType;

        [FindsBy(How = How.XPath, Using = ("//ng-dropdown-panel//div/span[text() = 'MultiFamily']"))]
        public IWebElement ItemMultiFamily;

        [FindsBy(How = How.XPath, Using = ("//ng-dropdown-panel//div/span[text() = 'SingleFamily']"))]
        public IWebElement ItemSingleFamily;

        [FindsBy(How = How.XPath, Using = ("//ng-dropdown-panel//div/span[text() = 'Duplex']"))]
        public IWebElement ItemDuplex;

        [FindsBy(How = How.XPath, Using = ("//ng-dropdown-panel//div/span[text() = 'Plex']"))]
        public IWebElement ItemPlex;

        [FindsBy(How = How.XPath, Using = ("//ng-dropdown-panel//div/span[text() = 'Loft']"))]
        public IWebElement ItemLoft;

        [FindsBy(How = How.XPath, Using = ("//input[@formcontrolname = 'holdingDeposit']"))]
        public IWebElement FieldInputApartmentHoldDeposit;

        [FindsBy(How = How.XPath, Using = ("//span[text() = 'Set from building']"))]
        public IWebElement ButtonSetFromBuilding;

        [FindsBy(How = How.XPath, Using = ("//span[text() = 'Payment methods']"))]
        public IWebElement ButtonPaymentMethods;

        [FindsBy(How = How.XPath, Using = ("//input[@formcontrolname = 'rentalTerms']"))]
        public IWebElement FieldInputRentalTermsFirstValue;

        [FindsBy(How = How.XPath, Using = ("//button[@aria-label = 'remove 12 months']"))]
        public IWebElement ButtonTwelveMonths;

        [FindsBy(How = How.XPath, Using = ("//span[text() =  ' 12 months ']"))]
        public IWebElement ItemTwelveMonthsRentalTerms;

        #region RequiredDocuments

        [FindsBy(How = How.XPath, Using = ("//app-required-documents//ng-multiselect-dropdown//span[contains(text(), '2 Recent paystubs')]"))]
        public IWebElement ItemTwoRecentPaystubs;

        [FindsBy(How = How.XPath, Using = ("//app-required-documents//ng-multiselect-dropdown//span[contains(text(), 'Employment Verification Letter')]"))]
        public IWebElement ItemEmploymentVerificationLetter;

        [FindsBy(How = How.XPath, Using = ("//app-required-documents//ng-multiselect-dropdown//span[contains(text(), '2 Most recent bank statements')]"))]
        public IWebElement ItemTwoMostRecentBankStatements;

        [FindsBy(How = How.XPath, Using = ("//app-required-documents//ng-multiselect-dropdown//span[contains(text(), 'Gov issued ID')]"))]
        public IWebElement ItemGovIssuedId;

        [FindsBy(How = How.XPath, Using = ("//app-required-documents//ng-multiselect-dropdown//span[contains(text(), '3 most recent rent payments')]"))]
        public IWebElement ItemThreeMostRecentRentPayments;

        [FindsBy(How = How.XPath, Using = ("//app-required-documents//ng-multiselect-dropdown//span[contains(text(), 'Most recent tax return')]"))]
        public IWebElement ItemMostRecentTaxReturn;

        #endregion

        [FindsBy(How = How.XPath, Using = ("//textarea[@id = 'description' ]"))]
        public IWebElement FieldInputDescription;

        [FindsBy(How = How.XPath, Using = ("//textarea[@id = 'internalNotes' ]"))]
        public IWebElement FieldInputInternalNotes;

        #endregion

        #region Amenities

        [FindsBy(How = How.XPath, Using = "//input[@id = 'input-amenity']")]
        public IWebElement FieldInputSearchForAmenities;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'input-included-amenity']")]
        public IWebElement FieldInputSearchForDefaultIncludedInMonthlyRentAmenities;

        [FindsBy(How = How.XPath, Using = "//div[text() = ' Heat Included ']")]
        public IWebElement ItemHeatIncluded;

        [FindsBy(How = How.XPath, Using = "//div[text() = ' Hot water Included ']")]
        public IWebElement ItemHotWaterIncluded;

        [FindsBy(How = How.XPath, Using = "//div[text() = ' Netflix Included ']")]
        public IWebElement ItemNetflixIncluded;

        [FindsBy(How = How.XPath, Using = "//div[text() = ' Sewer Included ']")]
        public IWebElement ItemSewerIncluded;

        [FindsBy(How = How.XPath, Using = "//div[text() = ' Wifi Included ']")]
        public IWebElement ItemWifiIncluded;

        [FindsBy(How = How.XPath, Using = "//div[text() = ' Water Included ']")]
        public IWebElement ItemWaterIncluded;

        [FindsBy(How = How.XPath, Using = "//div[text() = ' SmartHub Included ']")]
        public IWebElement ItemSmartHubIncluded;

        [FindsBy(How = How.XPath, Using = "//div[text() = ' Electric Included ']")]
        public IWebElement ItemElectricIncluded;

        [FindsBy(How = How.XPath, Using = "//div[text() = ' Gas Included ']")]
        public IWebElement ItemGasIncluded;

        #endregion

        #region TabAccess

        [FindsBy(How = How.XPath, Using = "//button//span[text() = 'Add lock']")]
        public IWebElement ButtonAddLock;

        [FindsBy(How = How.XPath, Using = "//input[@formcontrolname = 'location']")]
        public IWebElement FieldInputLocationForAccess;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'accessType']")]
        public IWebElement ButtonAccessType;

        [FindsBy(How = How.XPath, Using = "//span[text() = 'PinCode']")]
        public IWebElement ItemPinCode;

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Note']")]
        public IWebElement ItemNote;

        [FindsBy(How = How.XPath, Using = "//span[text() = 'ExistingOccupant']")]
        public IWebElement ItemExistingOccupant;

        [FindsBy(How = How.XPath, Using = "//input[@autocomplete = 'ab6a07d3a4cb']")]
        public IWebElement FieldInputLockForAccess;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder = 'Pin term']")]
        public IWebElement FieldInputPinCodeForFirstEnter;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'mat-mdc-chip-list-input-1']")]
        public IWebElement FieldInputPinCodeForNextEnter;

        [FindsBy(How = How.XPath, Using = "//input[@formcontrolname = 'lockGuid']")]
        public IWebElement FieldInputLockGuideForAccess;

        [FindsBy(How = How.XPath, Using = "//textarea[@formcontrolname = 'customNote']")]
        public IWebElement FieldInputCustomNoteForAccess;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'occupant-name']")]
        public IWebElement FieldInputName;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'occupant-email']")]
        public IWebElement FieldInputEmail;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'occupant-phonenumber']")]
        public IWebElement FieldInputPhoneNumber;

        [FindsBy(How = How.XPath, Using = "//textarea[@id = 'occupant-note']")]
        public IWebElement FieldInputNote;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'add-note-image']")]
        public IWebElement ButtonSelectImageForAccess;

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Image was upload successfully.']")]
        public IWebElement MessageSuccessUploadImageForAccess;

        //This element will be hidden
        //[FindsBy(How = How.XPath, Using = "//span[text() = ' Time Restriction Enabled ']")]
        //public IWebElement CheckBoxTimeRestrictionEnabledForAccess;

        [FindsBy(How = How.XPath, Using = "//button//span[text() = 'Save']")]
        public IWebElement ButtonSaveForLock;

        [FindsBy(How = How.XPath, Using = "//button//span[text() = 'Cancel']")]
        public IWebElement ButtonCancelForAccess;

        [FindsBy(How = How.XPath, Using = "//table//tbody//tr//td[text() = 'CAB']")]
        public IWebElement RecordCABInTableAccess;

        [FindsBy(How = How.XPath, Using = "//table//tbody//tr//td[text() = 'Note']")]
        public IWebElement RecordNoteInTableAccess;

        [FindsBy(How = How.XPath, Using = "//table//tbody//tr//td[text() = 'PinCode']")]
        public IWebElement RecordPinCodeInTableAccess;

        #endregion

        #region TabSpecials

        [FindsBy(How = How.XPath, Using = "//a[text() = 'Free Stuff']")]
        public IWebElement TabFreeStuff;

        [FindsBy(How = How.XPath, Using = "//a[text() = 'Concessions']")]
        public IWebElement TabConcessions;

        [FindsBy(How = How.XPath, Using = "//button//span[text() = 'Add']")]
        public IWebElement ButtonAddSpecials;

        [FindsBy(How = How.XPath, Using = "//input[@formcontrolname = 'name']")]
        public IWebElement FieldInputNameSpecials;

        [FindsBy(How = How.XPath, Using = "//input[@formcontrolname = 'monthsFree']")]
        public IWebElement FieldInputMonthsFree;

        [FindsBy(How = How.XPath, Using = "//input[@formcontrolname = 'leaseTerms']")]
        public IWebElement FieldInputLeaseTerms;

        [FindsBy(How = How.XPath, Using = "//mat-button-toggle-group//mat-button-toggle[2]")]
        public IWebElement ButtonYesSpecials;

        [FindsBy(How = How.XPath, Using = "//input[@formcontrolname = 'dateFrom']")]
        public IWebElement FieldInputDateFrom;

        [FindsBy(How = How.XPath, Using = "//input[@formcontrolname = 'dateTo']")]
        public IWebElement FieldInputDateTo;

        [FindsBy(How = How.XPath, Using = "//button//span[text() = 'Save']")]
        public IWebElement ButtonSaveSpecials;

        [FindsBy(How = How.XPath, Using = "//button//span[text() = 'Cancel']")]
        public IWebElement ButtonCancelSpecials;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'building-specials-container ng-star-inserted'] //table//tbody//td[1]")]
        public IWebElement RecordNameInTableConcessions;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'building-specials-container ng-star-inserted'] //table//tbody//td[1]")]
        public IWebElement RecordNameInTableFreeStuff;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder = 'Search for specials']")]
        public IWebElement FieldInputSelectItemsFreeStuff;

        [FindsBy(How = How.XPath, Using = "//div[text() = ' Free Netflix ']")]
        public IWebElement ItemFreeNetflix;

        [FindsBy(How = How.XPath, Using = "//div[text() = ' Google Speaker ']")]
        public IWebElement ItemGoogleSpeaker;

        [FindsBy(How = How.XPath, Using = "//label[text() = 'Application Submitted ']")]
        public IWebElement ButtonApplicationSubmittedTriggerEvent;

        [FindsBy(How = How.XPath, Using = "//label[text() = 'Lease Signed']")]
        public IWebElement ButtonLeaseSignedTriggerEvent;

        [FindsBy(How = How.XPath, Using = "//label[text() = 'Move In']")]
        public IWebElement ButtonMoveInTriggerEvent;

        [FindsBy(How = How.XPath, Using = "//label[text() = 'Self Tour']")]
        public IWebElement ButtonSelfTourTriggerEvent;

        [FindsBy(How = How.XPath, Using = "//mat-checkbox//label[text() = 'Is Active']")]
        public IWebElement CheckBoxIsActive;

        [FindsBy(How = How.XPath, Using = "//input[@Id = 'additional_info']")]
        public IWebElement FieldInputAdditionalInfo;

        #endregion

        #region Tab Images

        [FindsBy(How = How.XPath, Using = "//input[@id = 'add-image0']")]
        public IWebElement ButtonBrowseFiles;

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Save']")]
        public IWebElement ButtonSaveApartment;

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Saved successfully!']")]
        public IWebElement MessageSavedSuccessfullyApartment;

        #endregion

        [FindsBy(How = How.XPath, Using = "//cazamio-button[@text = 'Next']")]
        public IWebElement ButtonGeneralNext;

    }
}
