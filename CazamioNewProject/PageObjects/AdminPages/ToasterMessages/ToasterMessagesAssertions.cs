using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.ToasterMessages
{
    public partial class ToasterMessagesLandlord
    {
        #region Success toasters

        [AllureStep("VerifyMessageApartmentsWereSavedSuccessfully")]
        public ToasterMessagesLandlord VerifyMessageApartmentsWereSavedSuccessfully()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageSuccess));
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageApartmentsWereSavedSuccessfully));
            WaitUntil.CustomElementIsInVisible(MessageApartmentsWereSavedSuccessfully);

            return this;
        }

        [AllureStep("VerifyMessagePaymentMethodsSelected")]
        public ToasterMessagesLandlord VerifyMessagePaymentMethodsSelected()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageSuccess));
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessagePaymentMethodsSelected));
            WaitUntil.CustomElementIsInVisible(MessagePaymentMethodsSelected);

            return this;
        }

        [AllureStep("VerifyChangingLogoImageLandlord")]
        public ToasterMessagesLandlord VerifyChangingLogoImageLandlord()
        {
            WaitUntil.CustomElementIsVisible(MessageChangeImageLogoLandlordSuccess);
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageChangeImageLogoLandlordSuccess));

            return this;
        }

        [AllureStep("VerifyChangingAvatarImageLandlord")]
        public ToasterMessagesLandlord VerifyChangingAvatarImageLandlord()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageChangeImageAvatarUserSuccess));

            return this;
        }

        [AllureStep("VerifyRewmoveAvatarImageLandlord")]
        public ToasterMessagesLandlord VerifyRewmoveAvatarImageLandlord()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageRemoveImageAvatarUserSuccess));

            return this;
        }

        [AllureStep("VerifyMessageSavedSuccessfullyIfCreatedBuilding")]
        public ToasterMessagesLandlord VerifyMessageSavedSuccessfullyIfCreatedBuilding()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageSuccess));
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageSavedSuccessfullyIfCreatedBuilding));
            WaitUntil.CustomElementIsInVisible(MessageSavedSuccessfullyIfCreatedBuilding);

            return this;
        }

        [AllureStep("VerifyMessageScreeningFeeSaved")]
        public ToasterMessagesLandlord VerifMessageScreeningFeeSaved()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageSuccess));
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageScreeningFeeSaved));
            WaitUntil.CustomElementIsInVisible(MessageScreeningFeeSaved);

            return this;
        }

        [AllureStep("VerifyMessageAddedApplicantsToApplication")]
        public ToasterMessagesLandlord VerifMessageAddedApplicantsToApplication()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageSuccess));
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageAddedApplicantsToApplication));
            WaitUntil.CustomElementIsInVisible(MessageAddedApplicantsToApplication);

            return this;
        }

        [AllureStep("VerifyMessageTemplateWasDeleted")]
        public ToasterMessagesLandlord VerifyMessageTemplateWasDeleted()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageSuccess));
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageTemplateWasDeleted));
            WaitUntil.CustomElementIsInVisible(MessageTemplateWasDeleted);

            return this;
        }

        [AllureStep("VerifyMessageTemplateWasSaved")]
        public ToasterMessagesLandlord VerifMessageTemplateWasSaved()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageSuccess));
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageTemplateWasSaved));
            WaitUntil.CustomElementIsInVisible(MessageTemplateWasSaved);

            return this;
        }

        [AllureStep("VerifyMessageApplicationEditSuccessful")]
        public ToasterMessagesLandlord VerifyMessageApplicationEditSuccessful()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageSuccess));
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageApplicationEditSuccessful));
            WaitUntil.CustomElementIsInVisible(MessageApplicationEditSuccessful);

            return this;
        }

        [AllureStep("VerifyMessageCopiedTheLinkToApplication")]
        public ToasterMessagesLandlord VerifyMessageCopiedTheLinkToApplication()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageSuccess));
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageCopiedTheLinkToApplication));
            Assert.IsTrue(ToasterSuccessfully.IsNotVisible(MessageSuccess));
            Assert.IsTrue(ToasterSuccessfully.IsNotVisible(MessageCopiedTheLinkToApplication));

            return this;
        }

        [AllureStep("VerifyMessageBrandNameHasBeenSaveddSuccessfully")]
        public ToasterMessagesLandlord VerifyMessageBrandNameHasBeenSaveddSuccessfully()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageSuccess));
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageBrandNameHasBeenSaveddSuccessfully));
            Assert.IsTrue(ToasterSuccessfully.IsNotVisible(MessageSuccess));
            Assert.IsTrue(ToasterSuccessfully.IsNotVisible(MessageBrandNameHasBeenSaveddSuccessfully));

            return this;
        }

        [AllureStep("VerifyMessageDisclosureЫavedЫuccessfully")]
        public ToasterMessagesLandlord VerifyMessageDisclosureЫavedЫuccessfully()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageSuccess));
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageDisclosureЫavedЫuccessfully));
            Assert.IsTrue(ToasterSuccessfully.IsNotVisible(MessageSuccess));
            Assert.IsTrue(ToasterSuccessfully.IsNotVisible(MessageDisclosureЫavedЫuccessfully));

            return this;
        }

        #endregion
    }
}
