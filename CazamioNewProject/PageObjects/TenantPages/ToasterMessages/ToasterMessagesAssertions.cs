using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.TenantPages.ToasterMessages
{
    public partial class ToasterMessagesTenants
    {
        [AllureStep("VerifyMessageAccountWasSuccessfullyActivated")]
        public ToasterMessagesTenants VerifyMessageAccountWasSuccessfullyActivated()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageAccountWasSuccessfullyActivated));

            return this;
        }

        [AllureStep("VerifyMessageFirstSuccessfullUpdatedPassword")]
        public ToasterMessagesTenants VerifyMessageFirstSuccessfullUpdatedPassword()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageFirstSuccessfullUpdatedPassword));

            return this;
        }
    }
}
