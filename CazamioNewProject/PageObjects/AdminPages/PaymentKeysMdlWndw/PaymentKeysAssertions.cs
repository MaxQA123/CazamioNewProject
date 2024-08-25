using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.PageObjects.AdminPages.PaymentKeysMdlWndw
{
    public partial class PaymentKeysMdlWndw
    {
        public void VerifyApiKeyCardknox(string getApiKeyActual, string getItemApiKeyCardknoxActual)
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(getApiKeyActual, demo.PaymentSystems.Cardknox, $"Payment system not equal");
                Assert.AreEqual(getItemApiKeyCardknoxActual, demo.PaymentSystems.ApiKeyCardknox, $"Api key not equal");
            });
        }

        public void VerifyApiKeyAuthorizeNet(string getItemAuthorizeNetActual, string getItemApiKeyAuthorizeNetActual)
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(getItemAuthorizeNetActual, demo.PaymentSystems.AuthorizeNet, $"Payment system not equal");
                Assert.AreEqual(getItemApiKeyAuthorizeNetActual, demo.PaymentSystems.ApiKeyAuthorizeNet, $"Api key not equal");
            });
        }
    }
}
