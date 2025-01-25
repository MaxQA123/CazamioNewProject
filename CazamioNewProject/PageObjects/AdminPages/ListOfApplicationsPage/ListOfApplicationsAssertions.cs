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
            Assert.IsTrue(TitlesCheck.IsVisible(TitleListOfApplications));

            return this;
        }
    }
}
