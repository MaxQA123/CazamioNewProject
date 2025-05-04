using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfBuildingsPage
{
    public partial class ListOfBuildings
    {
        Building building = Building.Generate();
        Apartment apartment = Apartment.Generate();

        [AllureStep("ClickButtonAddBuilding")]
        public ListOfBuildings ClickButtonAddBuilding()
        {
            WaitUntil.WaitSomeInterval(10000);
            WaitUntil.CustomElementIsVisible(ButtonAdd, 10);
            WaitUntil.CustomElementIsClickable(ButtonAdd, 10);
            Button.Click(ButtonAdd);

            return this;
        }

        [AllureStep("SearchBuildingOneWashingtonSquare")]
        public ListOfBuildings SearchBuildingOneWashingtonSquare()
        {
            WaitUntil.CustomElementIsVisible(LoaderHidden, 10);
            WaitUntil.WaitSomeInterval(5000);
            WaitUntil.CustomElementIsVisible(FieldInputSearch);
            WaitUntil.CustomElementIsClickable(FieldInputSearch);
            InputGeneral.InputFunctionWithClear(FieldInputSearch, building.WashingtonSquare.NumberNameAddressStaticForSearch);

            return this;
        }

        [AllureStep("SearchNineNineNineEightSaintJohnsonPlace")]
        public ListOfBuildings SearchNineNineNineEightSaintJohnsonPlace()
        {
            WaitUntil.CustomElementIsVisible(LoaderHidden, 10);
            WaitUntil.WaitSomeInterval(10000);
            WaitUntil.CustomElementIsVisible(FieldInputSearch);
            WaitUntil.CustomElementIsClickable(FieldInputSearch);
            InputGeneral.InputFunctionWithClear(FieldInputSearch, building.SaintJohnsonPl.NumberNameAddressStaticForSearch);

            return this;
        }

        [AllureStep("SearchOneTwoFiveSixSevenDeanStreet")]
        public ListOfBuildings SearchOneTwoFiveSixSevenDeanStreet()
        {
            WaitUntil.CustomElementIsVisible(LoaderHidden, 10);
            WaitUntil.WaitSomeInterval(10000);
            WaitUntil.CustomElementIsVisible(FieldInputSearch);
            WaitUntil.CustomElementIsClickable(FieldInputSearch);
            InputGeneral.InputFunctionWithClear(FieldInputSearch, building.DeanStreet.NumberNameAddressStaticForSearch);

            return this;
        }

        [AllureStep("SearchOneOneOneAEastStPerestrian")]
        public ListOfBuildings SearchOneOneOneAEastStPerestrian()
        {
            WaitUntil.CustomElementIsVisible(LoaderHidden, 10);
            WaitUntil.WaitSomeInterval(10000);
            WaitUntil.CustomElementIsVisible(FieldInputSearch);
            WaitUntil.CustomElementIsClickable(FieldInputSearch);
            InputGeneral.InputFunctionWithClear(FieldInputSearch, building.East51stStreetPedestrianCrossing.NumberNameAddressStaticForSearch);

            return this;
        }

        [AllureStep("SearchThirtyDashThirtyNineCrownSt")]
        public ListOfBuildings SearchThirtyDashThirtyNineCrownSt()
        {
            WaitUntil.CustomElementIsVisible(LoaderHidden, 10);
            WaitUntil.WaitSomeInterval(10000);
            WaitUntil.CustomElementIsVisible(FieldInputSearch);
            WaitUntil.CustomElementIsClickable(FieldInputSearch);
            InputGeneral.InputFunctionWithClear(FieldInputSearch, building.CrownSt.NumberNameAddressStaticForSearch);

            return this;
        }

        [AllureStep("SearchNineAAlbermaleRd")]
        public ListOfBuildings SearchNineAAlbermaleRd()
        {
            WaitUntil.CustomElementIsVisible(LoaderHidden, 10);
            WaitUntil.WaitSomeInterval(10000);
            WaitUntil.CustomElementIsVisible(FieldInputSearch);
            WaitUntil.CustomElementIsClickable(FieldInputSearch);
            InputGeneral.InputFunctionWithClear(FieldInputSearch, building.AlbermaleRd.NumberNameAddressStaticForSearch);

            return this;
        }

        [AllureStep("SearchOneTwoEightSixSevenGatesAvenue")]
        public ListOfBuildings SearchOneTwoEightSixSevenGatesAvenue()
        {
            WaitUntil.CustomElementIsVisible(LoaderHidden, 10);
            WaitUntil.WaitSomeInterval(10000);
            WaitUntil.CustomElementIsVisible(FieldInputSearch);
            WaitUntil.CustomElementIsClickable(FieldInputSearch);
            InputGeneral.InputFunctionWithClear(FieldInputSearch, building.DeanStreet.NumberNameAddressStaticForSearch);

            return this;
        }

        [AllureStep("SelectItemFirst")]
        public ListOfBuildings SelectItemFirst()
        {
            WaitUntil.WaitSomeInterval(3000);
            WaitUntil.CustomElementIsVisible(ItemFirstBuildingOnPage);
            WaitUntil.CustomElementIsClickable(ItemFirstBuildingOnPage);
            Button.Click(ItemFirstBuildingOnPage);

            return this;
        }

        [AllureStep("SelectOneWashingtonSquare")]
        public ListOfBuildings SelectOneWashingtonSquare()
        {
            WaitUntil.WaitSomeInterval(3000);
            WaitUntil.CustomElementIsVisible(ItemOneWashingtonSquare);
            WaitUntil.CustomElementIsClickable(ItemOneWashingtonSquare);
            Button.Click(ItemOneWashingtonSquare);

            return this;
        }

        [AllureStep("SelectOneTwoEightSixSevenGatesAvenue")]
        public ListOfBuildings SelectOneTwoEightSixSevenGatesAvenue()
        {
            WaitUntil.WaitSomeInterval(3000);
            WaitUntil.CustomElementIsVisible(ItemOneTwoEightSixSevenGatesAvenue);
            WaitUntil.CustomElementIsClickable(ItemOneTwoEightSixSevenGatesAvenue);
            Button.Click(ItemOneTwoEightSixSevenGatesAvenue);

            return this;
        }

        [AllureStep("SelectNineNineNineEightSaintJohnsonPlace")]
        public ListOfBuildings SelectNineNineNineEightSaintJohnsonPlace()
        {
            WaitUntil.WaitSomeInterval(3000);
            WaitUntil.CustomElementIsVisible(ItemNineNineNineEightSaintJohnsonPlace);
            WaitUntil.CustomElementIsClickable(ItemNineNineNineEightSaintJohnsonPlace);
            Button.Click(ItemNineNineNineEightSaintJohnsonPlace);

            return this;
        }

        [AllureStep("SelectThirtyDashThirtyNineCrownSt")]
        public ListOfBuildings SelectThirtyDashThirtyNineCrownSt()
        {
            WaitUntil.WaitSomeInterval(3000);
            WaitUntil.CustomElementIsVisible(ItemThirtyDashThirtyNineCrownSt);
            WaitUntil.CustomElementIsClickable(ItemThirtyDashThirtyNineCrownSt);
            Button.Click(ItemThirtyDashThirtyNineCrownSt);

            return this;
        }

        [AllureStep("SelectOneOneOneAEastStPerestrian")]
        public ListOfBuildings SelectOneOneOneAEastStPerestrian()
        {
            WaitUntil.WaitSomeInterval(3000);
            WaitUntil.CustomElementIsVisible(ItemOneOneOneAEastStPerestrian);
            WaitUntil.CustomElementIsClickable(ItemOneOneOneAEastStPerestrian);
            Button.Click(ItemOneOneOneAEastStPerestrian);

            return this;
        }

        [AllureStep("SelectItemNineAAlbermaleRd")]
        public ListOfBuildings SelectItemNineAAlbermaleRd()
        {
            WaitUntil.WaitSomeInterval(3000);
            WaitUntil.CustomElementIsVisible(ItemNineAAlbermaleRd);
            WaitUntil.CustomElementIsClickable(ItemNineAAlbermaleRd);
            Button.Click(ItemNineAAlbermaleRd);

            return this;
        }

        [AllureStep("SelectOneTwoFiveSixSevenDeanStreet")]
        public ListOfBuildings SelectOneTwoFiveSixSevenDeanStreet()
        {
            WaitUntil.WaitSomeInterval(3000);
            WaitUntil.CustomElementIsVisible(ItemOneTwoFiveSixSevenDeanStreet);
            WaitUntil.CustomElementIsClickable(ItemOneTwoFiveSixSevenDeanStreet);
            Button.Click(ItemOneTwoFiveSixSevenDeanStreet);

            return this;
        }

        [AllureStep("OpenPageApartmentView")]
        public ListOfBuildings OpenPageApartmentView()
        {
            Pages.SidebarLandlord
               .ClickButtonBuildings();
            WaitUntil.CustomElementIsVisible(TitleListOfBuildingsPage);
            VerifyTitleListOfBuildings();
            WaitUntil.WaitSomeInterval(3000);
            WaitUntil.CustomElementIsVisible(FieldInputSearch);
            //InputGeneral.InputFunctionWithClear(FieldInputSearch, buildingAddress);
            WaitUntil.CustomElementIsVisible(ItemFirstBuildingOnPage);
            Button.Click(ItemFirstBuildingOnPage);
            WaitUntil.WaitSomeInterval(3000);
            Pages.BuildingView
                .ClickButtonAddInTabApartments();
            KeyBoardActions.ScrollToDown();
            Pages.BuildingView
                .SelectUnitFourInTabApartments();


            return this;
        }

        //[AllureStep("DemoTables")]
        //public ListOfBuildings DemoTables()
        //{
        //    var building = new TableElementProvider().GetCellElement(BuildingsTable.Name, 1);
        //    Console.WriteLine(building.Text);

        //    return this;
        //}
    }
}
