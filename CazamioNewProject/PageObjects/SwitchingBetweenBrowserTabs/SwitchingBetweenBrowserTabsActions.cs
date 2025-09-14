using CazamioNewProject.GuiHelpers;

namespace CazamioNewProject.GuiHelpers
{
    public class SwitchingBetweenBrowserTabsActions
    {
        public SwitchingBetweenBrowserTabsActions SecondThirdTabCloseSecondTabSelect()
        {
            SwitchingBetweenBrowserTabs.SecondTabCloseFirstTabSelect();
            SwitchingBetweenBrowserTabs.SecondTabCloseFirstTabSelect();
            SwitchingBetweenBrowserTabs.SecondTabSelect();

            return this;
        }

        public SwitchingBetweenBrowserTabsActions SecondThirdFourthTabCloseFirstTabSelect()
        {
            SwitchingBetweenBrowserTabs.SecondTabCloseFirstTabSelect();
            SwitchingBetweenBrowserTabs.SecondTabCloseFirstTabSelect();
            SwitchingBetweenBrowserTabs.SecondTabCloseFirstTabSelect();

            return this;
        }

        public SwitchingBetweenBrowserTabsActions SecondTabCloseThreeTimes()
        {
            SwitchingBetweenBrowserTabs.SecondTabClose();
            SwitchingBetweenBrowserTabs.SecondTabClose();
            SwitchingBetweenBrowserTabs.SecondTabClose();

            return this;
        }

        public SwitchingBetweenBrowserTabsActions SecondTabCloseTwoTimesFouthTabSelect()
        {
            SwitchingBetweenBrowserTabs.SecondTabClose();
            SwitchingBetweenBrowserTabs.SecondTabClose();
            SwitchingBetweenBrowserTabs.FouthTabSelect();

            return this;
        }

        public SwitchingBetweenBrowserTabsActions CloseSecondThirdFourthTabs()
        {
            SwitchingBetweenBrowserTabs.CloseSecondThirdFourthTabs();

            return this;
        }

        public SwitchingBetweenBrowserTabsActions CloseSecondTab()
        {
            SwitchingBetweenBrowserTabs.SecondTabClose();

            return this;
        }

        public SwitchingBetweenBrowserTabsActions CloseSecondTabAndSelectFirstTab()
        {
            SwitchingBetweenBrowserTabs.CloseSecondTabAndSelectFirstTab();

            return this;
        }
    }
}
