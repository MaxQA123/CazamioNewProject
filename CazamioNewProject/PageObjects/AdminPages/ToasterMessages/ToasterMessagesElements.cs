using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.ToasterMessages
{
    public partial class ToasterMessagesLandlord
    {
        //Common Success toasters 
        [FindsBy(How = How.XPath, Using = "//span[text() = 'Success']")]
        public IWebElement MessageSuccess;

        //Appeared if selected and saved a payment method in Payment Options modal window
        [FindsBy(How = How.XPath, Using = "//span[text() = 'Payment methods selected, Click save to confirm']")]
        public IWebElement MessagePaymentMethodsSelected;

        #region For actions of an application

        //Appeared if clicked the "Get Link" button on the "Apartment view page
        [FindsBy(How = How.XPath, Using = "//span[text() = 'Copied the link to application.']")]
        public IWebElement MessageCopiedTheLinkToApplication;

        #endregion

        #region For Temlates page Success toasters

        //Appeared if created a new template on the "Create tempalte" page
        [FindsBy(How = How.XPath, Using = "//span[text() = 'Template was saved.']")]
        public IWebElement MessageTemplateWasSaved;

        //Appeared if deleted already created template on the "Tempaltes" page
        [FindsBy(How = How.XPath, Using = "//span[text() = 'Template was deleted.']")]
        public IWebElement MessageTemplateWasDeleted;

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

        #region For apartment Success toasters 

        //Appeared if created a new apartment
        [FindsBy(How = How.XPath, Using = "//span[text() = 'Apartments were saved successfully.']")]
        public IWebElement MessageApartmentsWereSavedSuccessfully;

        #endregion

        #region For Add Applicant modal window Success toasters 

        //Appeared if created a new tenant-occupant and guarantor
        [FindsBy(How = How.XPath, Using = "//span[text() = 'Added applicants to application']")]
        public IWebElement MessageAddedApplicantsToApplication;

        #endregion

        #region For Edit application modal window Success toasters 

        //Appeared if updated the data in the Edit application modal window
        [FindsBy(How = How.XPath, Using = "//span[text() = 'Application edit successful']")]
        public IWebElement MessageApplicationEditSuccessful;

        #endregion
    }
}
