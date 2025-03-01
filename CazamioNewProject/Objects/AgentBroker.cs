using CazamioNewProject.GuiHelpers;
using RimuTec.Faker;

namespace CazamioNewProject.Objects
{
    public class AgentBroker
    {
        public AgentNameInfo AgentName { get; set; }
        public AgentEmailInfo AgentEmail { get; set; }
        public PhoneNumberInfo PhoneNumber { get; set; }
        public CommissionPercentageInfo CommissionPercentage { get; set; }
        public CreatedAgentMySpaceInfo CreatedAgentMySpace { get; set; }
        public BasicDataApiInfo BasicDataApi { get; set; }

        public static AgentBroker Generate()
        {
            return new AgentBroker
            {
                AgentName = CreateAgentNameInfo(),
                AgentEmail = CreateAgentEmailInfo(),
                PhoneNumber = CreatePhoneNumberInfo(),
                CommissionPercentage = CreateCommissionPercentageInfo(),
                CreatedAgentMySpace = CreateCreatedAgentMySpaceInfo(),
                BasicDataApi = CreateBasicDataApiInfo(),
            };
        }

        public class AgentNameInfo
        {
            public string FirstNameRandom { get; set; }
            public string LastNameRandom { get; set; }
            public string FirstLastNameRandom { get; set; }
        }

        public class AgentEmailInfo
        {
            public string FullEmail { get; set; }
            public string CreatedAgent { get; set; }
        }

        public class PhoneNumberInfo
        {
            public string BasicFirst { get; set; }
            public string CellFirst { get; set; }
        }

        public class CommissionPercentageInfo
        {
            public string ForBrokerRandom { get; set; }
            public string ForAgentRandom { get; set; }
            public long BrokerCommissionApi { get; set; }
            public long AgentCommissionApi { get; set; }
        }

        public class CreatedAgentMySpaceInfo
        {
            public string FullName { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            public string Cell { get; set; }
            public string BrokerCommission { get; set; }
            public string AgentCommission { get; set; }
            public string AssignedUserId { get; set; }
            public long AgentIdApi { get; set; }
        }

        public class BasicDataApiInfo
        {
            public string DeviceFingerprint { get; set; }
        }

        private static AgentNameInfo CreateAgentNameInfo()
        {
            return new AgentNameInfo
            {
                FirstNameRandom = Name.FirstName(),
                LastNameRandom = Name.LastName(),
                FirstLastNameRandom = Name.FirstName() + " " + Name.LastName(),
            };
        }

        private static AgentEmailInfo CreateAgentEmailInfo()
        {
            return new AgentEmailInfo
            {
                FullEmail = GenerateRandomData.RandomEmail(5) + GenerateRandomData.RandomNumberWithoutZero(3) + GenerateRandomData.RandomEmail(2) + EmailNameDomen.PUTS_BOX,
            };
        }

        private static PhoneNumberInfo CreatePhoneNumberInfo()
        {
            return new PhoneNumberInfo
            {
                BasicFirst = "912" + GenerateRandomData.RandomPhoneNumber(7),
                CellFirst = "320" + GenerateRandomData.RandomPhoneNumber(7),
            };
        }

        private static CommissionPercentageInfo CreateCommissionPercentageInfo()
        {
            return new CommissionPercentageInfo
            {
                ForBrokerRandom = GenerateRandomData.RandomNumberWithoutZero(2),
                ForAgentRandom = GenerateRandomData.RandomNumberWithoutZero(2),
                BrokerCommissionApi = long.Parse(GenerateRandomData.RandomNumberWithoutZero(2)),
                AgentCommissionApi = long.Parse(GenerateRandomData.RandomNumberWithoutZero(2)),
            };
        }

        private static CreatedAgentMySpaceInfo CreateCreatedAgentMySpaceInfo()
        {
            return new CreatedAgentMySpaceInfo
            {
                FullName = "Agentus Brokerus",
                FirstName = "Agentus",
                LastName = "Brokerus",
                Email = "agent1broker1auto@putsbox.com",
                PhoneNumber = "(518) 000-1239",
                Cell = "(212) 908-7321",
                BrokerCommission = "35.5",
                AgentCommission = "64.5",
                AssignedUserId = "85b076fa-1cfb-4f6d-888d-70ae7be1bc88",
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
