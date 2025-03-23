using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.AddApplicantMdlWndw
{
    public partial class AddApplicantMdlWndw
    {
        [FindsBy(How = How.XPath, Using = "//app-prepare-application//h2[text() = 'Add Applicant']")]
        public IWebElement TitleAddApplicantMdlWndw;

        [FindsBy(How = How.XPath, Using = "//app-prepare-application//div[@class = 'step applicants']//div[@class = 'email-input no-margin']//input")]
        public IWebElement FirstFieldInputEmailAddress;

        [FindsBy(How = How.XPath, Using = "//app-prepare-application//div[@class = 'step applicants']//div[@class = 'checkbox-input']//input[@id = 'is-guarantor-input']")]
        public IWebElement CheckBoxThisIsAGuarantorFirstEmailAddressField;

        [FindsBy(How = How.XPath, Using = "//app-prepare-application//div[@class = 'step applicants']//div[@class = 'email-input no-margin'][2]//input")]
        public IWebElement SecondFieldInputEmailAddress;

        [FindsBy(How = How.XPath, Using = "//app-prepare-application//div[@class = 'step applicants']//div[@class = 'checkbox-input'][2]//input[@id = 'is-guarantor-input']")]
        public IWebElement CheckBoxThisIsAGuarantorSecondEmailAddressField;

        [FindsBy(How = How.XPath, Using = "//app-prepare-application//div[text() = ' + Add another applicant ']")]
        public IWebElement BtnPlusAddAnotherApplicant;

        [FindsBy(How = How.XPath, Using = "//app-prepare-application//span[text() = 'Close']")]
        public IWebElement BtnClose;

        [FindsBy(How = How.XPath, Using = "//app-prepare-application//span[text() = 'Add']")]
        public IWebElement BtnAdd;
    }
}
