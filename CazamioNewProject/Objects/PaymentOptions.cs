
namespace CazamioNewProject.Objects
{
    public class PaymentOptions
    {
        public PaymentMethodsNameInfo PaymentMethodsName { get; set; }

        public static PaymentOptions Generate()
        {
            return new PaymentOptions
            {
                PaymentMethodsName = CreatePaymentMethodsNameInfo(),
            };
        }

        public class PaymentMethodsNameInfo
        {
            public string CreditCard { get; set; }
            public string Ach { get; set; }
            public string DeliverCheck { get; set; }
            public string Zelle { get; set; }
            public string Venmo { get; set; }
        }

        private static PaymentMethodsNameInfo CreatePaymentMethodsNameInfo()
        {
            return new PaymentMethodsNameInfo
            {
                CreditCard = "CreditCard",
                Ach = "",
                DeliverCheck = "",
                Zelle = "",
                Venmo = "",
            };
        }
    }
}
