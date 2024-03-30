using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.PageObjects.AdminPages.TemplatesPage
{
    public partial class Templates
    {
        [AllureStep("VerifyTitleTemplatesPage")]
        public Templates VerifyTitleTemplatesPage()
        {
            Assert.IsTrue(Successfully.IsVisible(TitleTemplatesPage));

            return this;
        }
    }
}
