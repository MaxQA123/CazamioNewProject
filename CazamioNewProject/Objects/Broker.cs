using CazamioNewProject.GuiHelpers;
using RimuTec.Faker;

namespace CazamioNewProject.Objects
{
    public class Broker
    {
        public BrokerNameInfo BrokerName { get; set; }
        public BrokerEmailInfo BrokerEmail { get; set; }
        public CreatedBrokerMySpaceInfo CreatedBrokerMySpace { get; set; }
        public BasicDataApiInfo BasicDataApi { get; set; }

        public static Broker Generate()
        {
            return new Broker
            {
                BrokerName = CreateBrokerNameInfo(),
                BrokerEmail = CreateBrokerEmailInfo(),
                CreatedBrokerMySpace = CreateCreatedBrokerMySpaceInfo(),
                BasicDataApi = CreateBasicDataApiInfo(),
            };
        }

        public class BrokerNameInfo
        {
            public string FirstNameRandom { get; set; }
            public string LastNameRandom { get; set; }
            public string FirstLastNameRandom { get; set; }
        }

        public class BrokerEmailInfo
        {
            public string FullEmail { get; set; }
        }

        public class CreatedBrokerMySpaceInfo
        {
            public string FullName { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public long BrokerIdApi { get; set; }
        }

        public class BasicDataApiInfo
        {
            public string DeviceFingerprint { get; set; }
        }

        private static BrokerNameInfo CreateBrokerNameInfo()
        {
            return new BrokerNameInfo
            {
                FirstNameRandom = Name.FirstName(),
                LastNameRandom = Name.LastName(),
                FirstLastNameRandom = Name.FirstName() + " " + Name.LastName(),
            };
        }

        private static BrokerEmailInfo CreateBrokerEmailInfo()
        {
            return new BrokerEmailInfo
            {
                FullEmail = GenerateRandomData.RandomEmail(5) + GenerateRandomData.RandomNumberWithoutZero(3) + GenerateRandomData.RandomEmail(2) + EmailNameDomen.PUTS_BOX,
            };
        }

        private static CreatedBrokerMySpaceInfo CreateCreatedBrokerMySpaceInfo()
        {
            return new CreatedBrokerMySpaceInfo
            {
                FullName = "Leoautotest Feabroker",
                FirstName = "Leoautotest",
                LastName = "Feabroker",
                Email = "broker3autotest@putsbox.com",
                BrokerIdApi = 103,
            };
        }

        private static BasicDataApiInfo CreateBasicDataApiInfo()
        {
            return new BasicDataApiInfo
            {
                DeviceFingerprint = "d86d2f3b2f8e0030f57cfb1ce82f3f25",
            };
        }
    }
}
