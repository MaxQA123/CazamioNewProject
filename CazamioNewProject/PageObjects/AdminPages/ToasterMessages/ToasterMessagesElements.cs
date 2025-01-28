﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.ToasterMessages
{
    public partial class ToasterMessages
    {
        #region Success toasters

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Success']")]
        public IWebElement MessageSuccess;

        //Appeared if created a new apartment
        [FindsBy(How = How.XPath, Using = "//span[text() = 'Apartments were saved successfully.']")]
        public IWebElement MessageApartmentsWereSavedSuccessfully;

        //Appeared if selected and saved a payment method in Payment Options modal window
        [FindsBy(How = How.XPath, Using = "//span[text() = 'Payment methods selected, Click save to confirm']")]
        public IWebElement MessagePaymentMethodsSelected;

        #endregion
    }
}
