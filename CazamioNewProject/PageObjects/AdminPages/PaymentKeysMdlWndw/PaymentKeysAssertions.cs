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
                Assert.AreEqual(getApiKeyActual, building.PaymentSystem.Cardknox);
                Assert.AreEqual(getItemApiKeyCardknoxActual, building.ApiKey.ApiKeyCardknox);
            });
        }

        public void VerifyApiKeyAuthorizeNet(string getItemAuthorizeNetActual, string getItemApiKeyAuthorizeNetActual)
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(getItemAuthorizeNetActual, building.PaymentSystem.AuthorizeNet);
                Assert.AreEqual(getItemApiKeyAuthorizeNetActual, building.ApiKey.ApiKeyAuthorizeNet);
            });
        }
    }
}
