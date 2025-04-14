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

        [AllureStep("VerifyMessageSuccessfullyUpdatedNameAndPassword")]
        public ToasterMessagesTenants VerifyMessageSuccessfullyUpdatedNameAndPassword()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageSuccessfullyUpdatedNameAndPassword));

            return this;
        }

        [AllureStep("DissapearsMessageSuccessfullyUpdatedNameAndPassword")]
        public ToasterMessagesTenants DissapearsMessageSuccessfullyUpdatedNameAndPassword()
        {
            Assert.IsTrue(ToasterSuccessfully.IsNotVisible(MessageSuccessfullyUpdatedNameAndPassword));

            return this;
        }
    }
}
