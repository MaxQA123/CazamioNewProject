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

        #endregion
    }
}
