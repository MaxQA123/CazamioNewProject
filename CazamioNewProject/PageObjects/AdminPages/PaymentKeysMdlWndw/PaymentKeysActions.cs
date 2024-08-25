using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.PageObjects.AdminPages.PaymentKeysMdlWndw
{
    public partial class PaymentKeysMdlWndw
    {
        Building building = Building.Generate();

        [AllureStep("GetItemCardknox")]
        public string GetItemCardknox()
        {
            WaitUntil.CustomElementIsVisible(ItemCardknox);
            string getItemCardknox = (ItemCardknox).Text;
            string getItemCardknoxActual = getItemCardknox.ToString();

            return getItemCardknoxActual;
        }

        [AllureStep("GetItemApiKeyCardknox")]
        public string GetItemApiKeyCardknox()
        {
            WaitUntil.CustomElementIsVisible(ItemApiKeyCardknox);
            string getItemApiKeyCardknox = (ItemApiKeyCardknox).Text;
            string getItemApiKeyCardknoxActual = getItemApiKeyCardknox.ToString();

            return getItemApiKeyCardknoxActual;
        }

        [AllureStep("GetItemAuthorizeNet")]
        public string GetItemAuthorizeNet()
        {
            WaitUntil.CustomElementIsVisible(ItemAuthorizeNet);
            string getItemCardknox = (ItemAuthorizeNet).Text;
            string getItemCardknoxActual = getItemCardknox.ToString();

            return getItemCardknoxActual;
        }

        [AllureStep("GetItemApiKeyAuthorizeNet")]
        public string GetItemApiKeyAuthorizeNet()
        {
            WaitUntil.CustomElementIsVisible(ItemApiKeyAuthorizeNet);
            string getItemApiKeyCardknox = (ItemApiKeyAuthorizeNet).Text;
            string getItemApiKeyCardknoxActual = getItemApiKeyCardknox.ToString();

            return getItemApiKeyCardknoxActual;
        }

        [AllureStep("ClickButtonCross")]
        public PaymentKeysMdlWndw ClickButtonSearchPaymentSystem()
        {
            WaitUntil.CustomElementIsVisible(ButtonSearchPaymentSystem);
            WaitUntil.CustomElementIsClickable(ButtonSearchPaymentSystem);
            Button.Click(ButtonSearchPaymentSystem);

            return this;
        }

        [AllureStep("SelectItemAuthorizeNet")]
        public PaymentKeysMdlWndw SelectItemAuthorizeNet()
        {
            WaitUntil.CustomElementIsVisible(ItemAuthorizeNet);
            WaitUntil.CustomElementIsClickable(ItemAuthorizeNet);
            Button.Click(ItemAuthorizeNet);

            return this;
        }

        [AllureStep("ClickButtonSave")]
        public PaymentKeysMdlWndw ClickButtonSave()
        {
            WaitUntil.CustomElementIsVisible(ButtonSave);
            WaitUntil.CustomElementIsClickable(ButtonSave);
            Button.Click(ButtonSave);

            return this;
        }

        [AllureStep("ClickButtonCross")]
        public PaymentKeysMdlWndw ClickButtonCross()
        {
            WaitUntil.CustomElementIsClickable(ButtonCross);
            Button.Click(ButtonCross);

            return this;
        }
    }
}
