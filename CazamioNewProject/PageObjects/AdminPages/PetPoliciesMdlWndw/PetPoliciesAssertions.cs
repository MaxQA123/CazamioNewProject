using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.PageObjects.AdminPages.PetPoliciesMdlWndw
{
    public partial class PetPoliciesMdlWndw
    {
        [AllureStep("VerifyTitlePetPoliciesMdlWndw")]
        public PetPoliciesMdlWndw VerifyTitlePetPoliciesMdlWndw()
        {
            Assert.IsTrue(Successfully.IsVisible(TitlePetPolicies));

            return this;
        }
    }
}
