﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.EmailPutsBoxPage
{
    public partial class EmailPutsBox
    {
        #region PageListOfLetters

        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'HTML')]")]
        public IWebElement ButtonBodyHtml;

        #endregion

        #region BodyLetterOfTenant

        [FindsBy(How = How.XPath, Using = "//td[text() = 'You’re (Almost) In!']")]
        public IWebElement TitleLetterCreateTenant;

        [FindsBy(How = How.XPath, Using = "//a[contains(@href, 'https://u28342774.ct.sendgrid.net/ls/click')]")]
        public IWebElement ButtonConfirmEmailForTenant;

        [FindsBy(How = How.XPath, Using = "//table[@class ='es-content']//tbody//tr[3]//table[@class = 'es-content-body']//a[contains(@href, 'https://u28342774.ct.sendgrid.net/ls/click')]")]
        public IWebElement ButtonResetPasswordForTenant;

        #endregion

        #region BodyLetterOfAdmin

        [FindsBy(How = How.XPath, Using = "//table[@class ='es-content']//tbody//tr[3]//table[@class = 'es-content-body']//a[contains(@href, 'https://u28342774.ct.sendgrid.net/ls/click')]")]
        public IWebElement ButtonResetPasswordForAdmin;

        [FindsBy(How = How.XPath, Using = "//td[text() = 'Welcome Aboard as a Marketplace Admin at MySpace NYC LLC!']")]
        public IWebElement TitleLetterCreateAdminMySpace;

        [FindsBy(How = How.XPath, Using = "//td[text() = 'Welcome Aboard as a Broker at MySpace NYC LLC!']")]
        public IWebElement TitleLetterCreateBrokerMySpace;

        [FindsBy(How = How.XPath, Using = "//td[text() = 'Welcome Aboard as an Agent at MySpace NYC LLC!']")]
        public IWebElement TitleLetterCreateAgentMySpace;

        [FindsBy(How = How.XPath, Using = "//td[@class = 'esd-block-text']//p[contains(text(), 'Password:')]")]
        public IWebElement TextPasswordForConfirmAdmin;

        [FindsBy(How = How.XPath, Using = "//tbody//tr[3]//a[contains(@href, 'https://u28342774.ct.sendgrid.net/ls/click')]")]
        public IWebElement BtnCofirmEmailLandlord;

        #endregion
    }
}
