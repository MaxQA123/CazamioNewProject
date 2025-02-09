using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.ToasterMessages
{
    public partial class ToasterMessages
    {
        #region Common Success toasters 

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Success']")]
        public IWebElement MessageSuccess;

        //Appeared if selected and saved a payment method in Payment Options modal window
        [FindsBy(How = How.XPath, Using = "//span[text() = 'Payment methods selected, Click save to confirm']")]
        public IWebElement MessagePaymentMethodsSelected;

        #endregion

        #region Sidebar Success toasters

        //Appeared if an image of a logo marketplace has been changed
        [FindsBy(How = How.XPath, Using = "//span[text()= 'Logo image was changed']")]
        public IWebElement MessageChangeImageLogoLandlordSuccess;

        //Appeared if an image of a user avatar has been changed
        [FindsBy(How = How.XPath, Using = "//span[text()= 'Profile image was changed']")]
        public IWebElement MessageChangeImageAvatarUserSuccess;

        //Appeared if an image of a user avatar has been removed
        [FindsBy(How = How.XPath, Using = "//span[text()= 'Profile image was removed']")]
        public IWebElement MessageRemoveImageAvatarUserSuccess;

        #endregion

        #region For building Success toasters 

        //Appeared if created a new building
        [FindsBy(How = How.XPath, Using = "//span[text() ='Saved successfully!']")]
        public IWebElement MessageSavedSuccessfullyIfCreatedBuilding;

        //Appeared if created a new building
        [FindsBy(How = How.XPath, Using = "//span[text() ='Screening Fee Saved']")]
        public IWebElement MessageScreeningFeeSaved;

        #endregion

        #region For building Success toasters 

        //Appeared if created a new apartment
        [FindsBy(How = How.XPath, Using = "//span[text() = 'Apartments were saved successfully.']")]
        public IWebElement MessageApartmentsWereSavedSuccessfully;

        #endregion
    }
}
