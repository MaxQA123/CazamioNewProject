using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.ToasterMessages
{
    public partial class ToasterMessages
    {
        #region Success toasters

        [AllureStep("VerifyMessageApartmentsWereSavedSuccessfully")]
        public ToasterMessages VerifyMessageApartmentsWereSavedSuccessfully()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageSuccess));
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageApartmentsWereSavedSuccessfully));

            return this;
        }

        [AllureStep("VerifyMessagePaymentMethodsSelected")]
        public ToasterMessages VerifyMessagePaymentMethodsSelected()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageSuccess));
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessagePaymentMethodsSelected));

            return this;
        }

        [AllureStep("VerifyChangingLogoImageLandlord")]
        public ToasterMessages VerifyChangingLogoImageLandlord()
        {
            WaitUntil.CustomElementIsVisible(MessageChangeImageLogoLandlordSuccess);
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageChangeImageLogoLandlordSuccess));

            return this;
        }

        [AllureStep("VerifyChangingAvatarImageLandlord")]
        public ToasterMessages VerifyChangingAvatarImageLandlord()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageChangeImageAvatarUserSuccess));

            return this;
        }

        [AllureStep("VerifyRewmoveAvatarImageLandlord")]
        public ToasterMessages VerifyRewmoveAvatarImageLandlord()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageRemoveImageAvatarUserSuccess));

            return this;
        }

        [AllureStep("VerifyMessageSavedSuccessfullyIfCreatedBuilding")]
        public ToasterMessages VerifyMessageSavedSuccessfullyIfCreatedBuilding()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageSuccess));
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageSavedSuccessfullyIfCreatedBuilding));

            return this;
        }

        #endregion
    }
}
