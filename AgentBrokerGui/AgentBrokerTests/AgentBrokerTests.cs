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
        //Amount order 5 next must be 6
        [Test]
        [Order(1)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Agent-Broker")]
        [AllureSubSuite("LogIn")]

        public void LogIn()
        {
            #region Test

            Pages.LogInLandlord
                .LogInAsAgentBrokerMySpace();

            #endregion

        }

        [Test]
        [Order(2)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Agent-Broker")]
        [AllureSubSuite("VerifySidebar")]

        public void VerifySidebar()
        {
            #region Preconditions

            Pages.LogInLandlord
                 .LogInAsAgentBrokerMySpace();

            string getUserNameCompare = Pages.SidebarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SidebarLandlord.GetUserNameRoleFromSideBar();

            Pages.SidebarLandlord
                .VerifyAgentBrokerUserNameAndRole(getUserNameCompare, getUserNameRoleCompare);

            #endregion

            #region Test

            Pages.SidebarLandlord
                .ChangingImageUserOfAgentBroker()
                .ClickingAllTabsOfAgentBroker();
            Pages.AreYouSureLogOutLandlordMdlWndw
                .MakeLogOut();
            Pages.LogInLandlord
                .VerifyTitle();

            #endregion
        }

        [Test]
        [Order(3)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Agent-Broker")]
        [AllureSubSuite("AddBuildingAssignedAgentBroker")]

        public void AddBuildingAssignedAgentBroker()
        {
            #region SettingsForBuilding

            //East 51st Street Pedestrian Crossing

            #endregion

            #region Preconditions Test

            Pages.LogInLandlord
                .LogInAsAgentBrokerMySpace();
            Pages.SidebarLandlord
                .ClickButtonBuildings();

            #endregion

            #region Test

            Pages.ListOfBuildings
                .ClickButtonAddBuilding();
            Pages.NewBuilding
                .VerifyTitleNewBuildingPg()
                .SelectOwnerTenantPaysCommissionAgent()
                .EnterBuildingDataEast51stStreetPedestrianCrossing()
                .ClickFieldInputInternalNotes();

            string getAddressNewBuildingActual = Pages.NewBuilding.GetValueFromFieldAddress();

            KeyBoardActions.ClickTab();

            string getValueScreeningFee = Pages.NewBuilding.GetValueFromFieldCreditScreeningFee();

            Pages.NewBuilding
                .VerifyValueByDefaulScreeningFee(getValueScreeningFee)
                .ClickBtnSelectPaymentMethodsForCreditScreeningFee();
            Pages.PaymentOptionsMdlWndw
                .SelectPaymentMethodAch();
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
                .ClickButtonSaveBuilding();
            Pages.ToasterMessagesLandlord
               .VerifyMessageSavedSuccessfullyIfCreatedBuilding();
            Pages.BuildingView
                .VerifyTitleBuildingViewPage();

            string getAddressBuildingView = Pages.BuildingView.GetValueOfStringAddress();

            Pages.BuildingView
                .VerifyBuildingAddress(getAddressNewBuildingActual, getAddressBuildingView);

            #endregion
        }

        [Test]
        [Order(5)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Agent-Broker")]
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
                .LogInAsAgentBrokerMySpace();
            Pages.SidebarLandlord
                .ClickButtonBuildings();
            Pages.ListOfBuildings
                .SearchOneOneOneAEastStPerestrian()
                .SelectOneOneOneAEastStPerestrian();
            Pages.BuildingView
                .VerifyTitleBuildingViewPage();

            string getAddressBuildingViewActual = Pages.BuildingView.GetValueOfStringAddress();
            string getBuildingNameFromBuildingView = Pages.BuildingView.GetValueOfStringBuildingName();

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
                .SelectApartmentTypeLoft();
            Pages.AddApartments
                .ClickTabAmenities()
                .SelectThreeAmenitiesIncludedInMonthlyRent()
                .ClickTabAccess()
                .ClickButtonAddLock()
                .AddItemAccessTypeNote()
                .ClickTabSpecials()
                .ClickButtonAddSpecials()
                .AddConcessionIsActiveWithoutName()
                .ClickTabImages()
                .UploadFiveImages();
            Pages.AddApartments
                .ClickButtonSelectVideo()
                .UploadOneFileVideo()
                .ClickButtonSaveApartment();
            Pages.ToasterMessagesLandlord
                .VerifyMessageApartmentsWereSavedSuccessfully();
            Pages.ListOfApartments
               .VerifyTitleListOfApartments();

            WaitUntil.WaitSomeInterval(5000);

            #endregion
        }

        [Test]
        [Order(4)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Agent-Broker")]
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
                .LogInAsAgentBrokerMySpace();
            Pages.SidebarLandlord
                .ClickButtonBuildings();
            Pages.ListOfBuildings
                .SearchOneOneOneAEastStPerestrian()
                .SelectOneOneOneAEastStPerestrian();
            Pages.BuildingView
                .VerifyTitleBuildingViewPage();

            string getAddressBuildingViewActual = Pages.BuildingView.GetValueOfStringAddress();
            string getBuildingNameFromBuildingView = Pages.BuildingView.GetValueOfStringBuildingName();

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
            Pages.ToasterMessagesLandlord
                .VerifyMessageApartmentsWereSavedSuccessfully();
            Pages.ListOfApartments
               .VerifyTitleListOfApartments();

            WaitUntil.WaitSomeInterval(5000);

            #endregion
        }
    }
}