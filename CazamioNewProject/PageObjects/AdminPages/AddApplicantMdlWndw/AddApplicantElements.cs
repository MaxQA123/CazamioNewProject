using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.AddApplicantMdlWndw
{
    public partial class AddApplicantMdlWndw
    {
        [FindsBy(How = How.XPath, Using = "//app-prepare-application//h2[text() = 'Add Applicant']")]
        public IWebElement TitleAddApplicantMdlWndw;

        [FindsBy(How = How.XPath, Using = "//app-prepare-application//div[@class = 'step applicants ng-star-inserted']//div[@class = 'email-input no-margin ng-star-inserted']//input")]
        public IWebElement FirstFieldInputEmailAddress;

        [FindsBy(How = How.XPath, Using = "//app-prepare-application//div[@class = 'step applicants ng-star-inserted']//div[@class = 'checkbox-input ng-star-inserted']//input[@id = 'is-guarantor-input']")]
        public IWebElement CheckBoxThisIsAGuarantorFirstEmailAddressField;

        [FindsBy(How = How.XPath, Using = "//app-prepare-application//div[@class = 'step applicants ng-star-inserted']//div[@class = 'email-input no-margin ng-star-inserted'][2]//input")]
        public IWebElement SecondFieldInputEmailAddress;

        [FindsBy(How = How.XPath, Using = "//app-prepare-application//div[@class = 'step applicants ng-star-inserted']//div[@class = 'checkbox-input ng-star-inserted'][2]//input[@id = 'is-guarantor-input']")]
        public IWebElement CheckBoxThisIsAGuarantorSecondEmailAddressField;

        [FindsBy(How = How.XPath, Using = "//app-prepare-application//div[text() = ' + Add another applicant ']")]
        public IWebElement BtnPlusAddAnotherApplicant;

        [FindsBy(How = How.XPath, Using = "//app-prepare-application//span[text() = 'Close']")]
        public IWebElement BtnClose;

        [FindsBy(How = How.XPath, Using = "//app-prepare-application//span[text() = 'Add']")]
        public IWebElement BtnAdd;
    }
}
