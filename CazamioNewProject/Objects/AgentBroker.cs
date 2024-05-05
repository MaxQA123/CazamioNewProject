using CazamioNewProject.GuiHelpers;
using RimuTec.Faker;

namespace CazamioNewProject.Objects
{
    public class AgentBroker
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string ShortEmail { get; set; }
        public string PhoneNumber { get; set; }
        public string Cell { get; set; }
        public string BrokerCommission { get; set; }
        public string AgentCommission { get; set; }
        public string EmailAddressAgentBroker { get; set; }
        public string FullNameAgentBroker { get; set; }
        public string DeviceFingerprint { get; set; }

        public AgentBroker Generate()
        {
            string firsName = "Agentus";
            string lastName = Name.LastName();
            string shortEmail = GenerateRandomData.RandomEmail(5) + GenerateRandomData.RandomNumberWithoutZero(3) + GenerateRandomData.RandomEmail(2);
            string phoneNumber = "212" + GenerateRandomData.RandomPhoneNumber(7);
            string cell = "518" + GenerateRandomData.RandomPhoneNumber(7);
            string brokerCommission = GenerateRandomData.RandomNumberWithoutZero(2);
            string agentCommission = GenerateRandomData.RandomNumberWithoutZero(2);
            string emailAddressAgentBroker = "agent1broker1auto@putsbox.com";
            string fullNameAgentBroker = "Agentus Brokerus";
            string deviceFingerprint = "d86d2f3b2f8e0030f57cfb1ce82f3f25";

            var agentBroker = new AgentBroker()
            {
                FirstName = firsName,
                LastName = lastName,
                EmailAddress = shortEmail + EmailNameDomen.PUTS_BOX,
                ShortEmail = shortEmail,
                PhoneNumber = phoneNumber,
                Cell = cell,
                BrokerCommission = brokerCommission,
                AgentCommission = agentCommission,
                EmailAddressAgentBroker = emailAddressAgentBroker,
                FullNameAgentBroker = fullNameAgentBroker,
                DeviceFingerprint = deviceFingerprint,
            };
            return agentBroker;
        }
    }
}
