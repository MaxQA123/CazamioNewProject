using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.PageObjects.AdminPages.BuildingViewPage
{
    public partial class BuildingView
    {
        #region TabsLine

        [AllureStep("ClickTabApartments")]
        public BuildingView ClickTabApartments()
        {
            WaitUntil.CustomElementIsVisible(TabApartments);
            WaitUntil.CustomElementIsClickable(TabApartments);
            Button.Click(TabApartments);

            return this;
        }

        [AllureStep("GetValueFromFieldNotInputAddress")]
        public string GetValueFromFieldNotInputAddress()
        {
            WaitUntil.WaitSomeInterval(2000);
            WaitUntil.CustomElementIsVisible(FieldNotInputAddress);
            string getValue = FieldNotInputAddress.Text;
            string getValueActual = getValue.ToString();

            return getValueActual;
        }

        [AllureStep("GetValueFromFieldNotInputBuildingName")]
        public string GetValueFromFieldNotInputBuildingName()
        {
            WaitUntil.CustomElementIsVisible(FieldNotInputBuildingName);
            string getValue = FieldNotInputBuildingName.Text;
            string getValueActual = getValue.ToString();

            return getValueActual;
        }

        #endregion

        #region InTabApartments

        [AllureStep("ClickButtonAddInTabApartments")]
        public BuildingView ClickButtonAddInTabApartments()
        {
            WaitUntil.CustomElementIsVisible(ButtonAddInTabApartments);
            WaitUntil.CustomElementIsClickable(ButtonAddInTabApartments);
            Button.Click(ButtonAddInTabApartments);

            return this;
        }

        [AllureStep("SelectUnitFourInTabApartments")]
        public BuildingView SelectUnitFourInTabApartments()
        {
            WaitUntil.CustomElementIsVisible(UnitFourInTabApartments);
            Button.Click(UnitFourInTabApartments);

            return this;
        }

        #endregion
    }
}
