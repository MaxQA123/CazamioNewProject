using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.AdminPages.BuildingViewPage
{
    public partial class BuildingView
    {
        Building building = Building.Generate();

        #region TabsLine

        [AllureStep("ClickTabApartments")]
        public BuildingView ClickTabApartments()
        {
            WaitUntil.CustomElementIsVisible(TabApartments);
            WaitUntil.CustomElementIsClickable(TabApartments);
            Button.Click(TabApartments);
            WaitUntil.WaitSomeInterval(1000);

            return this;
        }

        [AllureStep("GetValueOfStringAddress")]
        public string GetValueOfStringAddress()
        {
            WaitUntil.WaitSomeInterval(2000);
            WaitUntil.CustomElementIsVisible(ValueOfStringAddress);
            string getValue = ValueOfStringAddress.Text;
            string getValueActual = getValue.ToString();

            return getValueActual;
        }

        [AllureStep("GetValueOfStringBuildingName")]
        public string GetValueOfStringBuildingName()
        {
            WaitUntil.CustomElementIsVisible(ValueOfStringBuildingName);
            string getValue = ValueOfStringBuildingName.Text;
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

        [AllureStep("ClickButtonClone")]
        public BuildingView ClickButtonClone()
        {
            WaitUntil.CustomElementIsVisible(ButtonCloneInTabApartments);
            WaitUntil.CustomElementIsClickable(ButtonCloneInTabApartments);
            Button.Click(ButtonCloneInTabApartments);

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
