using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.PageObjects.TenantPages.SubmittingApplicationPage
{
    public partial class SubmittingApplication
    {
        [AllureStep("VerifyChangingAvatarImageLandlord")]
        public SubmittingApplication VerifyMessageAccountWasSuccessfullyActivated()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageAccountWasSuccessfullyActivated));

            return this;
        }
    }
}
