﻿using CazamioNewProject.GuiHelpers;
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

        [AllureStep("VerifMessageScreeningFeeSaved")]
        public ToasterMessagesLandlord VerifMessageScreeningFeeSaved()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageSuccess));
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageScreeningFeeSaved));
            WaitUntil.CustomElementIsInVisible(MessageScreeningFeeSaved);

            return this;
        }

        [AllureStep("VerifMessageAddedApplicantsToApplication")]
        public ToasterMessagesLandlord VerifMessageAddedApplicantsToApplication()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageSuccess));
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageAddedApplicantsToApplication));
            WaitUntil.CustomElementIsInVisible(MessageAddedApplicantsToApplication);

            return this;
        }

        #endregion
    }
}
