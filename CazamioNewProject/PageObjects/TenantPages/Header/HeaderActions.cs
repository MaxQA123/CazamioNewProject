using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.TenantPages.Header
{
    public partial class Header
    {
        [AllureStep("ClickButtonSignUp")]
        public Header ClickButtonSignUp()
        {
            WaitUntil.CustomElementIsVisible(ButtonSignUp);
            WaitUntil.CustomElementIsClickable(ButtonSignUp);
            Button.Click(ButtonSignUp);

            return this;
        }

        [AllureStep("ClickButtonLogIn")]
        public Header ClickButtonLogIn()
        {
            WaitUntil.CustomElementIsVisible(ButtonLogIn);
            WaitUntil.CustomElementIsClickable(ButtonLogIn);
            Button.Click(ButtonLogIn);

            return this;
        }

        [AllureStep("ClickButtonMyApplications")]
        public Header ClickButtonMyApplications()
        {
            WaitUntil.CustomElementIsVisible(ButtonMyApplications);
            WaitUntil.CustomElementIsClickable(ButtonMyApplications);
            Button.Click(ButtonMyApplications);

            return this;
        }

        //[AllureStep("SctollToButtonMyApplications")]
        //public Header SctollToButtonMyApplications()
        //{
        //    WaitUntil.WaitSomeInterval(250);
        //    ScrollingJScriptExecutorHelper.ScrollToElement(ButtonMyApplications);

        //    return this;
        //}
    }
}
