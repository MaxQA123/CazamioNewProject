using CazamioNewProject.GuiHelpers;
using RimuTec.Faker;

namespace CazamioNewProject.Objects
{
    public class Broker
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string ShortEmail { get; set; }
        public string EmailAddressBroker { get; set; }
        public string FullUserNameBroker { get; set; }
        public string DeviceFingerprint { get; set; }

        public Broker Generate()
        {
            string firsName = "BrokerQA";
            string lastName = Name.LastName();
            string shortEmail = GenerateRandomData.RandomEmail(5) + GenerateRandomData.RandomNumberWithoutZero(3) + GenerateRandomData.RandomEmail(2);
            string emailAddressBroker = "broker3autotest@putsbox.com";
            string fullUserNameBroker = "Leoautotest Feabroker";
            string deviceFingerprint = "d86d2f3b2f8e0030f57cfb1ce82f3f25";

            var broker = new Broker()
            {
                FirstName = firsName,
                LastName = lastName,
                EmailAddress = shortEmail + EmailNameDomen.PUTS_BOX,
                ShortEmail = shortEmail,
                EmailAddressBroker = emailAddressBroker,
                FullUserNameBroker = fullUserNameBroker,
                DeviceFingerprint = deviceFingerprint,
            };
            return broker;
        }
    }
}
