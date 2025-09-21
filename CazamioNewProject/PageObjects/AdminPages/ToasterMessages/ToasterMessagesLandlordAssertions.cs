using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.ToasterMessages
{
    public partial class ToasterMessagesLandlord
    {
        #region Success toasters

        #region Sidebar

        [AllureStep("Verify Changing Logo Image Marketplace")]
        public ToasterMessagesLandlord VerifyChangingLogoImageLandlord()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageChangeImageLogoLandlordSuccess));
            Assert.IsTrue(ToasterSuccessfully.IsNotVisible(MessageChangeImageLogoLandlordSuccess));

            return this;
        }

        [AllureStep("Verify Changing User Avatar Image")]
        public ToasterMessagesLandlord VerifyChangingAvatarImageLandlord()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageChangeImageAvatarUserSuccess));
            Assert.IsTrue(ToasterSuccessfully.IsNotVisible(MessageChangeImageAvatarUserSuccess));

            return this;
        }

        [AllureStep("Verify Rewmove User Avatar Image")]
        public ToasterMessagesLandlord VerifyRewmoveAvatarImageLandlord()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageRemoveImageAvatarUserSuccess));
            Assert.IsTrue(ToasterSuccessfully.IsNotVisible(MessageRemoveImageAvatarUserSuccess));

            return this;
        }

        #endregion

        [AllureStep("Verify Toaster Message Apartments were saved Successfully")]
        public ToasterMessagesLandlord VerifyMessageApartmentsWereSavedSuccessfully()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageSuccess));
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageApartmentsWereSavedSuccessfully));
            WaitUntil.CustomElementIsInVisible(MessageApartmentsWereSavedSuccessfully);

            return this;
        }

        [AllureStep("Verify Toaster Message Payment methods selected")]
        public ToasterMessagesLandlord VerifyMessagePaymentMethodsSelected()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageSuccess));
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessagePaymentMethodsSelected));
            WaitUntil.CustomElementIsInVisible(MessagePaymentMethodsSelected);

            return this;
        }


        [AllureStep("Verify Toaster if created building Message Saved successfully")]
        public ToasterMessagesLandlord VerifyMessageSavedSuccessfullyIfCreatedBuilding()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageSuccess));
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageSavedSuccessfullyIfCreatedBuilding));
            WaitUntil.CustomElementIsInVisible(MessageSavedSuccessfullyIfCreatedBuilding);

            return this;
        }

        [AllureStep("Verify Toaster Message Screening fee saved")]
        public ToasterMessagesLandlord VerifMessageScreeningFeeSaved()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageSuccess));
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageScreeningFeeSaved));
            WaitUntil.CustomElementIsInVisible(MessageScreeningFeeSaved);

            return this;
        }

        [AllureStep("Verify Toaster MessageAddedApplicantsToApplication")]
        public ToasterMessagesLandlord VerifMessageAddedApplicantsToApplication()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageSuccess));
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageAddedApplicantsToApplication));
            WaitUntil.CustomElementIsInVisible(MessageAddedApplicantsToApplication);

            return this;
        }

        [AllureStep("Verify Toaster MessageTemplateWasDeleted")]
        public ToasterMessagesLandlord VerifyMessageTemplateWasDeleted()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageSuccess));
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageTemplateWasDeleted));
            WaitUntil.CustomElementIsInVisible(MessageTemplateWasDeleted);

            return this;
        }

        [AllureStep("Verify Toaster MessageTemplateWasSaved")]
        public ToasterMessagesLandlord VerifMessageTemplateWasSaved()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageSuccess));
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageTemplateWasSaved));
            WaitUntil.CustomElementIsInVisible(MessageTemplateWasSaved);

            return this;
        }

        [AllureStep("Verify Toaster MessageApplicationEditSuccessful")]
        public ToasterMessagesLandlord VerifyMessageApplicationEditSuccessful()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageSuccess));
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageApplicationEditSuccessful));
            WaitUntil.CustomElementIsInVisible(MessageApplicationEditSuccessful);

            return this;
        }

        [AllureStep("Verify Toaster MessageCopiedTheLinkToApplication")]
        public ToasterMessagesLandlord VerifyMessageCopiedTheLinkToApplication()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageSuccess));
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageCopiedTheLinkToApplication));
            Assert.IsTrue(ToasterSuccessfully.IsNotVisible(MessageSuccess));
            Assert.IsTrue(ToasterSuccessfully.IsNotVisible(MessageCopiedTheLinkToApplication));

            return this;
        }

        [AllureStep("Verify Toaster Toaster Message brand name has been saved successfully")]
        public ToasterMessagesLandlord VerifyMessageBrandNameHasBeenSaveddSuccessfully()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageSuccess));
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageBrandNameHasBeenSaveddSuccessfully));
            Assert.IsTrue(ToasterSuccessfully.IsNotVisible(MessageSuccess));
            Assert.IsTrue(ToasterSuccessfully.IsNotVisible(MessageBrandNameHasBeenSaveddSuccessfully));

            return this;
        }

        [AllureStep("Verify Toaster Message disclosure saved successfully")]
        public ToasterMessagesLandlord VerifyMessageDisclosureЫavedЫuccessfully()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageSuccess));
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageDisclosureЫavedЫuccessfully));
            Assert.IsTrue(ToasterSuccessfully.IsNotVisible(MessageSuccess));
            Assert.IsTrue(ToasterSuccessfully.IsNotVisible(MessageDisclosureЫavedЫuccessfully));

            return this;
        }

        [AllureStep("Verify Toaster Message broker has been successfully created")]
        public ToasterMessagesLandlord VerifyMessageBrokerHasBeenSuccessfullyCreated()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageSuccess));
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageBrokerHasBeenSuccessfullyCreated));
            Assert.IsTrue(ToasterSuccessfully.IsNotVisible(MessageSuccess));
            Assert.IsTrue(ToasterSuccessfully.IsNotVisible(MessageBrokerHasBeenSuccessfullyCreated));

            return this;
        }

        #endregion

        #region

        [AllureStep("Verify Toaster Message Enter valid email and password")]
        public ToasterMessagesLandlord VerifyMessageEnterValidEmailAndPassword()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageWarningWithExclamationMark));
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageEnterValidEmailAndPassword));
            Assert.IsTrue(ToasterSuccessfully.IsNotVisible(MessageWarningWithExclamationMark));
            Assert.IsTrue(ToasterSuccessfully.IsNotVisible(MessageEnterValidEmailAndPassword));

            return this;
        }

        #endregion
    }
}
