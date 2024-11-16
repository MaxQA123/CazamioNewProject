using Allure.Commons;
using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using CazamioNewProject.PageObjects;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace AgentBrokerGui
{
    [TestFixture]
    [AllureNUnit]

    public class TestsBaseGui : AgentBrokerBase
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Agent Broker")]
        [AllureSubSuite("LogIn")]

        public void LogIn()
        {
            #region Test

            Pages.LogInLandlord
                .EnterEmailPasswordAsAgentBroker()
                .ClickIconShow()
                .ClickButtonLetsGo();

            string getUserNameCompare = Pages.SidebarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SidebarLandlord.GetUserNameRoleFromSideBar();

            Pages.SidebarLandlord
                .VerifyAgentBrokerUserNameAndRole(getUserNameCompare, getUserNameRoleCompare);

            #endregion

        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Agent Broker")]
        [AllureSubSuite("VerifySidebar")]

        public void VerifySidebar()
        {
            #region Preconditions

            Pages.LogInLandlord
                .EnterEmailPasswordAsAgentBroker()
                .ClickIconShow()
                .ClickButtonLetsGo();

            string getUserNameCompare = Pages.SidebarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SidebarLandlord.GetUserNameRoleFromSideBar();

            Pages.SidebarLandlord
                .VerifyAgentBrokerUserNameAndRole(getUserNameCompare, getUserNameRoleCompare);

            #endregion

            #region Test

            Pages.SidebarLandlord
                .UploadImageAvatarUserLandlordFirst()
                .VerifyChangingAvatarImageLandlord()
                .UploadImageAvatarUserLandlordSecond()
                .VerifyChangingAvatarImageLandlord()
                .ClicklinkRemovePhotoOfLandlord()
                .VerifyRewmoveAvatarImageLandlord();
            //.ClickButtonDashboardSidebar();
            //Pages.Dashboard
            //    .VerifyTitleOfDashboardPg();
            Pages.SidebarLandlord
                .ClickButtonBuildings();
            Pages.ListOfBuildings
                .VerifyTitleListOfBuildings();
            Pages.SidebarLandlord
                .ClickButtonApartments();
            Pages.ListOfApartments
                .VerifyTitleListOfApartments();
            Pages.SidebarLandlord
                .ClickButtonApplications();
            Pages.ListOfApplications
                .VerifyTitleListOfApplications();
            Pages.SidebarLandlord
                .ClickButtonTransactions();
            Pages.ListOfTransactions
                .VerifyTitleTransactionsPg();
            Pages.SidebarLandlord
                .ClickButtonLeads();
            Pages.ListOfLeads
                .VerifyTitleLeads();
            Pages.SidebarLandlord
                .ClickButtonCommissions();
            Pages.ListOfCommissions
                .VerifyTitleListOfCommissions();
            Pages.AreYouSureLogOutLandlordMdlWndw
                .MakeLogOut();
            Pages.LogInLandlord
                .VerifyTitle();

            #endregion
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Broker")]
        [AllureSubSuite("AddBuildingAssignedAgentBroker")]

        public void AddBuildingAssignedAgentBroker()
        {
            #region SettingsForBuilding

            //East 51st Street Pedestrian Crossing

            #endregion

            #region Preconditions Test

            Pages.LogInLandlord
                .EnterEmailPasswordAsAgentBroker()
                .ClickIconShow()
                .ClickButtonLetsGo();

            string getUserNameCompare = Pages.SidebarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SidebarLandlord.GetUserNameRoleFromSideBar();

            Pages.SidebarLandlord
                .VerifyAgentBrokerUserNameAndRole(getUserNameCompare, getUserNameRoleCompare);
            Pages.SidebarLandlord
                .ClickButtonBuildings();

            #endregion

            #region Test

            Pages.ListOfBuildings
                .ClickButtonAddBuilding();
            Pages.NewBuilding
                .VerifyTitleNewBuildingPg()
                .SelectOwnerTenantPaysCommissionWithAgent()
                .EnterBuildingDataEast51stStreetPedestrianCrossing()
                .ClickFieldInputInternalNotes();

            string getAddressNewBuildingActual = Pages.NewBuilding.GetValueFromFieldAddress();

            KeyBoardActions.ClickTab();

            string getValueScreeningFee = Pages.NewBuilding.GetValueFromFieldCreditScreeningFee();

            Pages.NewBuilding
                .VerifyValueByDefaulScreeningFee(getValueScreeningFee)
                .ClickBtnSelectPaymentMethodsForCreditScreeningFee();
            Pages.PaymentOptionsMdlWndw
                .SelectCrdtCrdDlvrChckZlVnmForHoldBuilding();
            Pages.NewBuilding
                .ClickBtnEditForPaymentSystem();
            Pages.PaymentKeysMdlWndw
                .SelectPaymentSystemAuthorizeNet();

            string getItemAuthorizeNetActual = Pages.PaymentKeysMdlWndw.GetItemAuthorizeNet();
            string getItemApiKeyAuthorizeNetActual = Pages.PaymentKeysMdlWndw.GetItemApiKeyAuthorizeNet();

            Pages.PaymentKeysMdlWndw
                .VerifyApiKeyAuthorizeNet(getItemAuthorizeNetActual, getItemApiKeyAuthorizeNetActual);
            Pages.PaymentKeysMdlWndw
                .ClickButtonSave();
            Pages.NewBuilding
                .ClickThreeTimesButtonGeneralNext()
                .ClickTabFreeStuff()
                .ClickButtonAddSpecials()
                .AddFreeStuffInActive()
                .ClickButtonAddSpecials()
                .AddFreeStuffIsActiveWithoutName()
                //Add get value
                .ClickTabConcessions()
                .ClickButtonAddSpecials()
                .AddConcessionInActive()
                .ClickButtonAddSpecials()
                .AddConcessionIsActiveWithoutName()
                //Add get value
                //Add Assertions
                .ClickButtonGeneralNext()
                .UploadOneImages()
                .ClickButtonSaveBuilding()
                .VerifyMessageSavedSuccessfullyBuilding();
            Pages.BuildingView
                .VerifyTitleBuildingViewPage();

            string getAddressBuildingView = Pages.BuildingView.GetValueFromFieldNotInputAddress();

            Pages.BuildingView
                .VerifyBuildingAddress(getAddressNewBuildingActual, getAddressBuildingView);

            #endregion
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Broker")]
        [AllureSubSuite("AddBuildingAssignedAgentBroker")]

        public void AddApartmentAssignedAgentBroker()
        {
            #region SettingsForBuilding

            //111A East 51st Street Pedestrian Crossing

            #endregion

            #region Test data

            Apartment apartment = Apartment.Generate();

            #endregion

            #region Preconditions Test

            Pages.LogInLandlord
                .EnterEmailPasswordAsAgentBroker()
                .ClickIconShow()
                .ClickButtonLetsGo();

            string getUserNameCompare = Pages.SidebarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SidebarLandlord.GetUserNameRoleFromSideBar();

            Pages.SidebarLandlord
                .VerifyAgentBrokerUserNameAndRole(getUserNameCompare, getUserNameRoleCompare);

            Pages.SidebarLandlord
                .ClickButtonBuildings();
            Pages.ListOfBuildings
                .SearchOneOneOneAEastStPerestrian();
            Pages.ListOfBuildings
                .SelectItemFirst();
            Pages.BuildingView
                .VerifyTitleBuildingViewPage();

            string getAddressBuildingViewActual = Pages.BuildingView.GetValueFromFieldNotInputAddress();
            string getBuildingNameFromBuildingView = Pages.BuildingView.GetValueFromFieldNotInputBuildingName();

            Pages.BuildingView
                .VerifyBuildingAddress(getAddressBuildingViewActual, apartment.BuildingShortAddress.OneOneOneAEastFiftyOneStStreetPedestrianCrossing)
                .ClickTabApartments();
            KeyBoardActions.ScrollToDown();
            Pages.BuildingView
                .ClickButtonAddInTabApartments();

            #endregion

            #region Test

            Pages.AddApartments
                .EnterDataForOneOneOneAEastStPedestrianCrossing()
                .SelectStatusOffMarket()
                .SelectApartmentTypeLoft()
                .ClickButtonPaymentMethods();
            Pages.PaymentOptionsMdlWndw
                .SelectPaymentMethodCreditCard();
            Pages.AddApartments
                .ClickTabAmenities()
                .SelectThreeAmenitiesIncludedInMonthlyRent()
                .ClickTabAccess()
                .ClickToggleSelfTourStatus()
                .ClickButtonAddLock()
                .AddItemAccessTypeNote()
                .ClickTabSpecials()
                .ClickButtonAddSpecials()
                .AddConcessionIsActiveWithoutName()
                .ClickTabImages()
                .UploadFiveImages();
            //JScriptExecutor.ScrollToDownWebPage();
            Pages.AddApartments
                .ClickButtonSelectVideo()
                .UploadOneFileVideo()
                .ClickButtonSaveApartment();

            #endregion

            WaitUntil.WaitSomeInterval(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Broker")]
        [AllureSubSuite("AddApartmentAssignedAgBr")]

        public void AddApartmentAssignedAgBr()
        {
            #region SettingsForBuilding

            //111A East 51st Street Pedestrian Crossing

            #endregion

            #region Test data

            Apartment apartment = Apartment.Generate();

            #endregion

            #region Preconditions Test

            Pages.LogInLandlord
                .EnterEmailPasswordAsAgentBroker()
                .ClickIconShow()
                .ClickButtonLetsGo();

            string getUserNameCompare = Pages.SidebarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SidebarLandlord.GetUserNameRoleFromSideBar();

            Pages.SidebarLandlord
                .VerifyAgentBrokerUserNameAndRole(getUserNameCompare, getUserNameRoleCompare);

            Pages.SidebarLandlord
                .ClickButtonBuildings();
            Pages.ListOfBuildings
                .SearchOneOneOneAEastStPerestrian();
            Pages.ListOfBuildings
                .SelectItemFirst();
            Pages.BuildingView
                .VerifyTitleBuildingViewPage();

            string getAddressBuildingViewActual = Pages.BuildingView.GetValueFromFieldNotInputAddress();
            string getBuildingNameFromBuildingView = Pages.BuildingView.GetValueFromFieldNotInputBuildingName();

            Pages.BuildingView
                .VerifyBuildingAddress(getAddressBuildingViewActual, apartment.BuildingShortAddress.OneOneOneAEastFiftyOneStStreetPedestrianCrossing)
                .ClickTabApartments();
            KeyBoardActions.ScrollToDown();
            Pages.BuildingView
                .ClickButtonAddInTabApartments();

            #endregion

            #region Test

            Pages.AddApartments
                .EnterFullDataForOneOneOneAEastStPedestrianCrossing()
                .SelectStatusSignedLease()
                .SelectCurrentDatePlusOneDayAvailableFrom()
                .SelectAgent()
                .SelectApartmentTypeLoft();
            JScriptExecutor.ScrollToDownWebPage();
            Pages.AddApartments
                .ClickButtonSetFromBuilding()
                .SetSomeItemsRentalTerms()
                .EnterShortDescriptionInternalNotes()
                .ClickTwiceButtonGeneralNext()
                .ClickToggleSelfTourStatus()
                .ClickButtonAddLock()
                .AddItemAccessTypePinCode()
                .ClickButtonGeneralNext()
                .ClickTabFreeStuff()
                .ClickButtonAddSpecials()
                .AddFreeStuffIsActiveWithoutName()
                .ClickButtonGeneralNext()
                .ClickButtonSelectVideo()
                .SetLinksYouTubeVimeo()
                .ClickButtonSaveApartment();

            #endregion

            WaitUntil.WaitSomeInterval(5000);
        }
    }
}