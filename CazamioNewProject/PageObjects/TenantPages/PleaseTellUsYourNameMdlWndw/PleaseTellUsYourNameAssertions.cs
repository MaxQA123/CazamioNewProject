using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.PageObjects.TenantPages.PleaseTellUsYourNameMdlWndw
{
    public partial class PleaseTellUsYourNameMdlWndw
    {
        [AllureStep("VerifyTitle")]
        public PleaseTellUsYourNameMdlWndw VerifyTitle()
        {
            Assert.IsTrue(TitlesCheck.IsVisible(TitlePleaseTellUsYourName));

            return this;
        }
    }
}
