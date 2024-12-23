﻿using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            InputGeneral.InputFunctionWithClear(FieldInputSearch, apartment.BuildingShortAddress.OneWashingtonSquare);

            return this;
        }

        [AllureStep("SearchNineNineNineEightSaintJohnsonPlace")]
        public ListOfBuildings SearchNineNineNineEightSaintJohnsonPlace()
        {
            WaitUntil.CustomElementIsVisible(LoaderHidden, 10);
            WaitUntil.WaitSomeInterval(10000);
            WaitUntil.CustomElementIsVisible(FieldInputSearch);
            WaitUntil.CustomElementIsClickable(FieldInputSearch);
            InputGeneral.InputFunctionWithClear(FieldInputSearch, apartment.BuildingShortAddress.NineNineNineEightSaintJohnsonPlace);

            return this;
        }

        [AllureStep("SearchOneOneOneAEastStPerestrian")]
        public ListOfBuildings SearchOneOneOneAEastStPerestrian()
        {
            WaitUntil.CustomElementIsVisible(LoaderHidden, 10);
            WaitUntil.WaitSomeInterval(10000);
            WaitUntil.CustomElementIsVisible(FieldInputSearch);
            WaitUntil.CustomElementIsClickable(FieldInputSearch);
            InputGeneral.InputFunctionWithClear(FieldInputSearch, apartment.BuildingShortAddress.OneOneOneAEastFiftyOneStStreetPedestrianCrossing);

            return this;
        }

        [AllureStep("SelectItemFirst")]
        public ListOfBuildings SelectItemFirst()
        {
            WaitUntil.WaitSomeInterval(2000);
            WaitUntil.CustomElementIsVisible(ItemFirstBuildingOnPage);
            WaitUntil.CustomElementIsClickable(ItemFirstBuildingOnPage);
            Button.Click(ItemFirstBuildingOnPage);

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
