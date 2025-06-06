﻿using CazamioNewProject.GuiHelpers;
using RimuTec.Faker;

namespace CazamioNewProject.Objects
{
    public class Agent
    {
        public AgentNameInfo AgentName { get; set; }
        public AgentEmailInfo AgentEmail { get; set; }
        public PhoneNumberInfo PhoneNumber { get; set; }
        public CommissionPercentageInfo CommissionPercentage { get; set; }
        public CreatedAgentLulaMySpaceInfo CreatedAgentLulaMySpace { get; set; }
        public BasicDataApiInfo BasicDataApi { get; set; }

        public static Agent Generate()
        {
            return new Agent
            {
                AgentName = CreateAgentNameInfo(),
                AgentEmail = CreateAgentEmailInfo(),
                PhoneNumber = CreatePhoneNumberInfo(),
                CommissionPercentage = CreateCommissionPercentageInfo(),
                CreatedAgentLulaMySpace = CreateCreatedAgentLulaMySpaceInfo(),
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
            public string FullEmailRandom { get; set; }
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

        public class CreatedAgentLulaMySpaceInfo
        {
            public string FullName { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            public string Cell { get; set; }
            public string BrokerCommission { get; set; }
            public string AgentCommission { get; set; }
            public long AgentIdApi { get; set; }
            public string UserId { get; set; }
            public long MarketplaceId { get; set; }
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
                FullEmailRandom = "agent15" + GenerateRandomData.RandomNumberByDateTime() + EmailNameDomen.PUTS_BOX,
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
                BrokerCommissionApi = 33,
                AgentCommissionApi = 67,
            };
        }

        private static CreatedAgentLulaMySpaceInfo CreateCreatedAgentLulaMySpaceInfo()
        {
            return new CreatedAgentLulaMySpaceInfo
            {
                FullName = "Lula AgentQA",
                FirstName = "Lula",
                LastName = "AgentQA",
                Email = "agent5lula@putsbox.com",
                PhoneNumber = "(212) 345-8765",
                Cell = "(518) 123-0089",
                BrokerCommission = "70",
                AgentCommission = "30",
                AgentIdApi = 154,
                UserId = "23d56fe2-f7f8-4d5f-89cf-31fe72b0e43a",
                MarketplaceId = 15,
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
