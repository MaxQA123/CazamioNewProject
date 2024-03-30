using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfApplicationsPage
{
    public partial class ListOfApplications
    {
        [AllureStep("VerifyTitleListOfApplications")]
        public ListOfApplications VerifyTitleListOfApplications()
        {
            WaitUntil.WaitSomeInterval(1000);
            Assert.IsTrue(Successfully.IsVisible(TitleListOfApplications));

            return this;
        }
    }
}
