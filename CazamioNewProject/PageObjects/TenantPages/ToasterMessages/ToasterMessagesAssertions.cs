using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.TenantPages.ToasterMessages
{
    public partial class ToasterMessagesTenants
    {
        [AllureStep("VerifyChangingAvatarImageLandlord")]
        public ToasterMessagesTenants VerifyMessageAccountWasSuccessfullyActivated()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageAccountWasSuccessfullyActivated));

            return this;
        }
    }
}
