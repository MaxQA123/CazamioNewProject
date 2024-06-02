
namespace CazamioNewProject.Objects
{
    public class PaymentSettingsApiKey
    {
        public PaymentSystemInfo PaymentSystem { get; set; }
        public ApiKeyInfo ApiKey { get; set; }
        public string EmailAddress { get; set; }
        public string ShortEmail { get; set; }
        public string EmailAddressBroker { get; set; }
        public string FullUserNameBroker { get; set; }

        public class PaymentSystemInfo
        {
            public string Cardknox { get; set; }
            public string AuthorizeNet { get; set; }
        }

        public class ApiKeyInfo
        {
            public string DefaultCardknoxMySpace { get; set; }
        }

        public PaymentSettingsApiKey Generate()
        {
            string cardknox = "Cardknox";
            string authorizeNet = "AuthorizeNet";
            string defaultCardknoxMySpace = "czmodev359376936c0543b58126c97f9ff55c68";

            var paymentSettings = new PaymentSettingsApiKey()
            {
                PaymentSystem = new PaymentSystemInfo
                {
                    Cardknox = cardknox,
                    AuthorizeNet = authorizeNet
                },
                ApiKey = new ApiKeyInfo
                {
                    DefaultCardknoxMySpace = defaultCardknoxMySpace
                },

            };
            return paymentSettings;
        }
    }
}
