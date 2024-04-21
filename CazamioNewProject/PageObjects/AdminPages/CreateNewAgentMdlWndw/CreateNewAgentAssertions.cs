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
        //[AllureStep("VerifyFieldsOnMdlWndwCreateBroker")]
        //public CreateNewAgentMdlWndw VerifyFieldsOnMdlWndwCreateBroker()
        //{
        //    Assert.IsTrue(Errors.IsInvisible(ErrorFirstNameCrtNwBrkrOnMdlwndw));

        //    return this;
        //}

        [AllureStep("VerifyMessageNewAgentCreatedSuccessfully")]
        public CreateNewAgentMdlWndw VerifyMessageNewAgentCreatedSuccessfully()
        {
            WaitUntil.CustomElementIsVisible(MessageNewAgentCreatedSuccessfully);
            Assert.IsTrue(Successfully.IsVisible(MessageNewAgentCreatedSuccessfully));


            return this;
        }
    }
}
