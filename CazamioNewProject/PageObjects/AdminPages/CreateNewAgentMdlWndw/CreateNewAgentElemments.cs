using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.CreateNewAgentMdlWndw
{
    public partial class CreateNewAgentMdlWndw
    {
        [FindsBy(How = How.XPath, Using = "//input[@id = 'first-name']")]
        public IWebElement FieldInputFirstName;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'last-name']")]
        public IWebElement FieldInputLastName;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'email']")]
        public IWebElement FieldInputEmail;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'phoneNumber']")]
        public IWebElement FieldInputPhoneNumber;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'cell']")]
        public IWebElement FieldInputCell;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'broker-commission']")]
        public IWebElement FieldInputBrokerCommission;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'agent-commission']")]
        public IWebElement FieldInputAgentCommission;

        [FindsBy(How = How.XPath, Using = "//cazamio-button//span[text() = 'Save']")]
        public IWebElement ButtonSave;

        [FindsBy(How = How.XPath, Using = "//p[text() = 'New agent created successfully!']")]
        public IWebElement MessageNewAgentCreatedSuccessfully;

        [FindsBy(How = How.XPath, Using = "//div[@class= 'input-msgs-error']")]
        public IWebElement ErrorFirstName;

        //[FindsBy(How = How.XPath, Using = "//div[@class= 'input-msgs-error']")]
        //public IWebElement ErrorLastNameCrtNwBrkrOnMdlwndw;

        //[FindsBy(How = How.XPath, Using = "//div[@class= 'input-msgs-error']")]
        //public IWebElement ErrorEmailCrtNwBrkrOnMdlwndw;

        //[FindsBy(How = How.XPath, Using = "//div[@class= 'input-msgs-error']")]
        //public IWebElement ErrorPhoneNumberCrtNwBrkrOnMdlwndw;

        //[FindsBy(How = How.XPath, Using = "//div[@class= 'input-msgs-error']")]
        //public IWebElement ErrorCellNameCrtNwBrkrOnMdlwndw;
    }
}
