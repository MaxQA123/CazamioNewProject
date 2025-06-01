using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.MarketplacePage
{
    public partial class Marketplace
    {
        [FindsBy(How = How.XPath, Using = ("//div[text()= 'Marketplace']"))]
        public IWebElement TitleMarketplacePage;

        [FindsBy(How = How.XPath, Using = ("//h3[text() = 'Brand Logo']"))]
        public IWebElement BrandLogoSectionName;

        [FindsBy(How = How.XPath, Using = (""))]
        public IWebElement BrowseFilesBtnBrandLogo;

        [FindsBy(How = How.XPath, Using = ("//h3[text() = 'Brand Name']"))]
        public IWebElement BrandNameSectionName;

        [FindsBy(How = How.XPath, Using = ("//div[@class = 'brand-name-input']//input"))]
        public IWebElement ChangeBrandNameInputField;

        [FindsBy(How = How.XPath, Using = ("//div[@class = 'brand-name-edit']//div[@class = 'save-btn']//button[@title = 'Save']"))]
        public IWebElement SaveBtnForChangeBrandNameInputField;

        [FindsBy(How = How.XPath, Using = ("//h3[text() = 'Disclosure Information']"))]
        public IWebElement DisclosureInformationSectionName;

        [FindsBy(How = How.XPath, Using = ("//app-disclosure//input[@formcontrolname = 'ownerName']"))]
        public IWebElement OwnerNameInputField;

        [FindsBy(How = How.XPath, Using = ("//app-disclosure//input[@formcontrolname = 'fullName']"))]
        public IWebElement CompanyFullLegalNameInputField;

        [FindsBy(How = How.XPath, Using = ("//app-disclosure//input[@formcontrolname = 'address']"))]
        public IWebElement AddressInputField;

        [FindsBy(How = How.XPath, Using = ("//app-disclosure//input[@formcontrolname = 'phoneNumber']"))]
        public IWebElement PhoneNumberInputField;

        [FindsBy(How = How.XPath, Using = (""))]
        public IWebElement SaveBtnForDisclosureInformationSection;

        [FindsBy(How = How.XPath, Using = ("//h3[text() = 'Social links']"))]
        public IWebElement SociallinksSectionName;

        [FindsBy(How = How.XPath, Using = (""))]
        public IWebElement FacebookInputField;

        [FindsBy(How = How.XPath, Using = (""))]
        public IWebElement TwitterInputField;

        [FindsBy(How = How.XPath, Using = (""))]
        public IWebElement YouTubeInputField;

        [FindsBy(How = How.XPath, Using = (""))]
        public IWebElement LinkedInInputField;

        [FindsBy(How = How.XPath, Using = (""))]
        public IWebElement InstagramInputField;

        [FindsBy(How = How.XPath, Using = (""))]
        public IWebElement SaveBtnForSociallinksSection;

        [FindsBy(How = How.XPath, Using = ("//h3[text() = 'Email branding']"))]
        public IWebElement EmailBrandingSectionName;

        [FindsBy(How = How.XPath, Using = ("//h3[text() = 'Terms & Conditions']"))]
        public IWebElement TermsConditionsSectionName;

        [FindsBy(How = How.XPath, Using = (""))]
        public IWebElement DownloadTermsConditionsBtn;

        [FindsBy(How = How.XPath, Using = (""))]
        public IWebElement BrowseFilesBtnTermsConditions;

        [FindsBy(How = How.XPath, Using = ("//h3[text() = 'Privacy Policy']"))]
        public IWebElement PrivacyPolicySectionName;

        [FindsBy(How = How.XPath, Using = (""))]
        public IWebElement BrowseFilesBtnPrivacyPolicy;

        [FindsBy(How = How.XPath, Using = (""))]
        public IWebElement DownloadPrivacyPolicyBtn;
    }
}
