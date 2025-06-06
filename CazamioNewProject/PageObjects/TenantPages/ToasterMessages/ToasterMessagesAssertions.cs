﻿using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.TenantPages.ToasterMessages
{
    public partial class ToasterMessagesTenants
    {
        #region Success toasters when creating a new tenant plus application

        [AllureStep("VerifyMessageAccountWasSuccessfullyActivated")]
        public ToasterMessagesTenants VerifyMessageAccountWasSuccessfullyActivated()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageSuccessSecondVersion));
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageAccountWasSuccessfullyActivated));
            Assert.IsTrue(ToasterSuccessfully.IsNotVisible(MessageSuccessSecondVersion));
            Assert.IsTrue(ToasterSuccessfully.IsNotVisible(MessageAccountWasSuccessfullyActivated));

            return this;
        }

        [AllureStep("VerifyMessageAccountWasSuccessfullyActivatedWithDiv")]
        public ToasterMessagesTenants VerifyMessageAccountWasSuccessfullyActivatedWithDiv()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageSuccessSecondVersion));
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageAccountWasSuccessfullyActivated));
            Assert.IsTrue(ToasterSuccessfully.IsNotVisible(MessageSuccessSecondVersion));
            Assert.IsTrue(ToasterSuccessfully.IsNotVisible(MessageAccountWasSuccessfullyActivated));

            return this;
        }

        [AllureStep("VerifyMessageSuccessfullyUpdatedNameAndPassword")]
        public ToasterMessagesTenants VerifyMessageSuccessfullyUpdatedNameAndPassword()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageSuccessfullyUpdatedNameAndPassword));
            Assert.IsTrue(ToasterSuccessfully.IsNotVisible(MessageSuccessfullyUpdatedNameAndPassword));

            return this;
        }

        [AllureStep("VerifyMessageThirdLeasePriceWasAgreedOnSuccessfully")]
        public ToasterMessagesTenants VerifyMessageThirdLeasePriceWasAgreedOnSuccessfully()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageThirdLeasePriceWasAgreedOnSuccessfully));
            Assert.IsTrue(ToasterSuccessfully.IsNotVisible(MessageThirdLeasePriceWasAgreedOnSuccessfully));

            return this;
        }

        #endregion

        #region Warning toasters when creating a new tenant plus application

        [AllureStep("VerifyMessageAccountWasSuccessfullyActivatedWarningNoAccessToViewThisApplication")]
        public ToasterMessagesTenants VerifyMessageAccountWasSuccessfullyActivatedWarningNoAccessToViewThisApplication()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageAccountWasSuccessfullyActivated));
            Assert.IsTrue(ToasterWarning.IsVisible(MessageWarning));
            Assert.IsTrue(ToasterWarning.IsVisible(MessageNoAccessToViewThisApplication));
            Assert.IsTrue(ToasterSuccessfully.IsNotVisible(MessageAccountWasSuccessfullyActivated));
            Assert.IsTrue(ToasterWarning.IsNotVisible(MessageWarning));
            Assert.IsTrue(ToasterWarning.IsNotVisible(MessageNoAccessToViewThisApplication));

            return this;
        }

        #endregion
    }
}
