using CazamioNewProject.GuiHelpers;
using RimuTec.Faker;

namespace CazamioNewProject.Objects
{
    public class Agent
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string ShortEmail { get; set; }
        public string PhoneNumber { get; set; }
        public string Cell { get; set; }
        public string BrokerCommission { get; set; }
        public string AgentCommission { get; set; }
        public string EmailAddressAgent { get; set; }
        public string FullNameAgent { get; set; }

        public Agent Generate()
        {
            string firsName = "AgentQA";
            string lastName = Name.LastName();
            string shortEmail = GenerateRandomData.RandomEmail(5) + GenerateRandomData.RandomNumberWithoutZero(3) + GenerateRandomData.RandomEmail(2);
            string phoneNumber = "212" + GenerateRandomData.RandomPhoneNumber(7);
            string cell = "518" + GenerateRandomData.RandomPhoneNumber(7);
            string brokerCommission = GenerateRandomData.RandomNumberWithoutZero(2);
            string agentCommission = GenerateRandomData.RandomNumberWithoutZero(2);
            string emailAddressAgent = "agent5lula@putsbox.com";
            string fullNameAgent = "Lula AgentQA";

            var agent = new Agent()
            {
                FirstName = firsName,
                LastName = lastName,
                EmailAddress = shortEmail + EmailNameDomen.PUTS_BOX,
                ShortEmail = shortEmail,
                PhoneNumber = phoneNumber,
                Cell = cell,
                BrokerCommission = brokerCommission,
                AgentCommission = agentCommission,
                EmailAddressAgent = emailAddressAgent,
                FullNameAgent = fullNameAgent,
            };
            return agent;
        }
    }
}
