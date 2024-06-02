using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.ApiHelpers.ApiObjects.ModlesApiObjects
{
    public class PaymentSettingsApi
    {
        public IdInfo Id { get; set; }
        public PaymentSystemInfo PaymentSystem { get; set; }

        public class IdInfo
        {
            public long CardknoxByDefaultMySpace { get; set; }
        }

        public class PaymentSystemInfo
        {
            public long CardknoxType { get; set; }
        }

        public PaymentSettingsApi Generate()
        {
            long cardknoxByDefaultMySpace = 28;
            long cardknoxType = 1;

            var paymentSettingsApi = new PaymentSettingsApi()
            {
                Id = new IdInfo
                {
                    CardknoxByDefaultMySpace = cardknoxByDefaultMySpace
                },
                PaymentSystem = new PaymentSystemInfo
                {
                    CardknoxType = cardknoxType
                },

            };
            return paymentSettingsApi;
        }
    }
}
