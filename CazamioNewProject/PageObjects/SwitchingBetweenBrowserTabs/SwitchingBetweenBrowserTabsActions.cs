using CazamioNewProject.GuiHelpers;

namespace CazamioNewProject.GuiHelpers
{
    public class SwitchingBetweenBrowserTabsActions
    {
        public SwitchingBetweenBrowserTabsActions SecondThirdTabCloseSecondTabSelect()
        {
            SwitchingBetweenBrowserTabs.SecondTabClose();
            SwitchingBetweenBrowserTabs.SecondTabClose();
            SwitchingBetweenBrowserTabs.SecondTabSelect();

            return this;
        }

        public SwitchingBetweenBrowserTabsActions SecondThirdFourthTabCloseSecondTabSelect()
        {
            SwitchingBetweenBrowserTabs.SecondTabClose();
            SwitchingBetweenBrowserTabs.SecondTabClose();
            SwitchingBetweenBrowserTabs.SecondTabClose();

            return this;
        }
    }
}
