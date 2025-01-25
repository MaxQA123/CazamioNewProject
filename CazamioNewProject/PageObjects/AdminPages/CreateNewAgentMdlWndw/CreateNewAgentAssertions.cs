using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.PageObjects.AdminPages.CreateNewAgentMdlWndw
{
    public partial class CreateNewAgentMdlWndw
    {
        [AllureStep("VerifyMessageNewAgentCreatedSuccessfully")]
        public CreateNewAgentMdlWndw VerifyMessageNewAgentCreatedSuccessfully()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageNewAgentCreatedSuccessfully));


            return this;
        }
    }
}
