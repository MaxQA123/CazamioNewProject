using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace CazamioNewProject.GuiHelpers
{
    public class EmailHelper
    {
        public void OpenPutsBox(IWebElement element, string partEmailPutsBox)
        {
            WaitUntil.WaitSomeInterval(1000);
            WebDriverWait wait = new(Browser._Driver, TimeSpan.FromSeconds(10));
            wait.PollingInterval = TimeSpan.FromSeconds(2);
            try
            {
                wait.Until(e =>
                {
                    try
                    {
                        if (element.Enabled == true)
                        {

                            return true;
                        }

                        return false;

                    }
                    catch (Exception)
                    {
                        Browser._Driver.Navigate().GoToUrl(($"https://putsbox.com/{partEmailPutsBox}/inspect"));

                        return false;
                    }
                });
            }
            catch (NoSuchElementException) { }

            catch (StaleElementReferenceException) { }
        }
    }
}
