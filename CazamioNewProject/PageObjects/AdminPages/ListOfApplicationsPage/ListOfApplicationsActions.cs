using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfApplicationsPage
{
    public partial class ListOfApplications
    {
        [AllureStep("ClickButtonPlusApplication")]
        public ListOfApplications ClickButtonPlusApplication()
        {
            WaitUntil.WaitSomeInterval(5000);
            WaitUntil.CustomElementIsVisible(ButtonPlusApplication);
            Button.Click(ButtonPlusApplication);

            return this;
        }

        [AllureStep("SelectFirstItemInLitsOFApplications")]
        public ListOfApplications SelectFirstItemInLitsOFApplications()
        {
            WaitUntil.CustomElementIsVisible(FirstItemInLitsOFApplications);
            Button.Click(FirstItemInLitsOFApplications);

            return this;
        }
    }
}
