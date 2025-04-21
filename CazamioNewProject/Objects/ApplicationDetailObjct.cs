using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.Objects
{
    public class ApplicationDetailObjct
    {
        public AddressInfo Address { get; set; }

        public static ApplicationDetailObjct Generate()
        {
            return new ApplicationDetailObjct
            {
                Address = CreateAddressInfo(),
            };
        }

        public class AddressInfo
        {
            public string NineNineNineEightSaintJohnsonPlace { get; set; }
        }

        private static AddressInfo CreateAddressInfo()
        {
            return new AddressInfo
            {
                NineNineNineEightSaintJohnsonPlace = "",
            };
        }
    }
}
