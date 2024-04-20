using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.AreYouSureLogOutMdlWndw
{
    public partial class AreYouSureLogOutLandlordMdlWndw
    {
        [FindsBy(How = How.XPath, Using = "//button[@class = 'swal2-confirm btn btn-success']")]
        public IWebElement ButtonYesIAmSureOnMdlwndw;

        [FindsBy(How = How.XPath, Using = "//button[@class = 'swal2-cancel btn btn-danger']")]
        public IWebElement ButtonCancelOnMdlwndw;
    }
}
