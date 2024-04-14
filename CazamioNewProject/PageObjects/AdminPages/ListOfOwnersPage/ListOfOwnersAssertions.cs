using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfOwnersPage
{
    public partial class ListOfOwners
    {
        [AllureStep("VerifyTitleListOfOwnersPg")]
        public ListOfOwners VerifyTitleListOfOwnersPg()
        {
            Assert.IsTrue(Successfully.IsVisible(TitleListOfOwnersPg));

            return this;
        }
    }
}
