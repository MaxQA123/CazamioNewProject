using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.TenantPages.ToasterMessages
{
    public partial class ToasterMessagesTenants
    {
        [FindsBy(How = How.XPath, Using = "//div[text()= ' Account was successfully activated ']")]
        public IWebElement MessageAccountWasSuccessfullyActivated;

        [FindsBy(How = How.XPath, Using = "//div[text()= ' Successfully updated password. ']")]
        public IWebElement MessageFirstSuccessfullUpdatedPassword;

        [FindsBy(How = How.XPath, Using = "//div[text()= ' Successfully updated name. ']")]
        public IWebElement MessageSecondSuccessfullyUpdatedName;

        [FindsBy(How = How.XPath, Using = "//div[text()= ' Lease price was agreed on successfully. ']")]
        public IWebElement MessageThirdLeasePriceWasAgreedOnSuccessfully;
    }
}
