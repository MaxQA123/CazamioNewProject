using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using System.Collections.Generic;

namespace CazamioNewProject.PageObjects.EmailPutsBoxPage
{
    public partial class EmailPutsBox
    {
        #region Body of notification of tenant's website

        [AllureStep("ClickButtonStartYourApplicationNowForTenant")]
        public EmailPutsBox ClickButtonStartYourApplicationNowForTenant()
        {
            WaitUntil.WaitSomeInterval(3000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[2]);
            WaitUntil.WaitSomeInterval(1000);
            ButtonStartYourApplicationNow.Click();
            WaitUntil.WaitSomeInterval(3000);
            List<string> tabsListSecond = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsListSecond[3]);
            WaitUntil.WaitSomeInterval(3000);

            return this;
        }

        [AllureStep("ClickButtonConfirmEmailForTenant")]
        public EmailPutsBox ClickButtonConfirmEmailForTenant()
        {
            WaitUntil.WaitSomeInterval(3000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[2]);
            WaitUntil.WaitSomeInterval(1000);
            ButtonConfirmEmailForTenant.Click();
            WaitUntil.WaitSomeInterval(3000);
            List<string> tabsListSecond = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsListSecond[3]);
            WaitUntil.WaitSomeInterval(3000);

            return this;
        }

        [AllureStep("ClickButtonResetPasswordForTenant")]
        public EmailPutsBox ClickButtonResetPasswordForTenant()
        {
            WaitUntil.WaitSomeInterval(3000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[2]);
            WaitUntil.WaitSomeInterval(1000);
            ButtonResetPasswordForTenant.Click();
            WaitUntil.WaitSomeInterval(3000);
            List<string> tabsListSecond = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsListSecond[3]);
            WaitUntil.WaitSomeInterval(3000);

            return this;
        }

        #endregion

        #region Body of notification of landlord's website

        [AllureStep("ClickButtonResetPasswordForAdmin")]
        public EmailPutsBox ClickButtonResetPasswordForAdmin()
        {
            WaitUntil.WaitSomeInterval(3000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[2]);
            WaitUntil.WaitSomeInterval(1000);
            ButtonConfirmEmailForTenant.Click();
            WaitUntil.WaitSomeInterval(3000);
            List<string> tabsListSecond = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsListSecond[3]);
            WaitUntil.WaitSomeInterval(3000);

            return this;
        }

        [AllureStep("ClickButtonConfirmEmailForAdmin")]
        public EmailPutsBox ClickButtonConfirmEmailForAdmin()
        {
            WaitUntil.WaitSomeInterval(3000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[2]);
            WaitUntil.WaitSomeInterval(1000);
            BtnCofirmEmailLandlord.Click();
            WaitUntil.WaitSomeInterval(3000);
            List<string> tabsListSecond = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsListSecond[3]);
            WaitUntil.WaitSomeInterval(3000);

            return this;
        }

        public string GetPasswordFromEmailForCreaationUser()
        {
            WaitUntil.WaitSomeInterval(3000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[2]);
            string getTextPassword = PasswordFromTextForCreationAdminUser.Text;

            return getTextPassword;
        }

        //[AllureStep("GetFullBodyNotificationCreateMarketplaceAdmin")]
        //public string GetFullBodyNotificationCreateMarketplaceAdmin()
        //{
        //    string dearRow = FrstRwBodyCreateMarketplaceaAdmin.Text;
        //    string welcomeRow = ScndRwBodyCreateMarketplaceaAdmin.Text;

        //    return dearRow;
        //}

        [AllureStep("GetFullBodyNotificationCreateMarketplaceAdmin")]
        public (string DearRow, string WelcomeRow) GetFullBodyNotificationCreateMarketplaceAdmin()
        {
            string dearRow = FrstRwBodyCreateMarketplaceaAdmin.Text;
            string welcomeRow = ScndRwBodyCreateMarketplaceaAdmin.Text;

            return (dearRow, welcomeRow);
        }

        #endregion
    }
}
