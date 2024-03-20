using CazamioNewProject.GuiHelpers;
using RimuTec.Faker;

namespace CazamioNewProject.Objects
{
    public class MarketplaceAdmin
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string ShortEmail { get; set; }
        public string SubdomainMySpace { get; set; }
        public string EmailAddressMarketplaceAdmin { get; set; }
        public string FullNameMarketplaceAdmin { get; set; }

        public MarketplaceAdmin Generate()
        {
            string firsName = "Mark-admin";
            string lastName = Name.LastName();
            string shortEmail = GenerateRandomData.RandomEmail(5) + GenerateRandomData.RandomNumberWithoutZero(3) + GenerateRandomData.RandomEmail(2);
            string subdomainMySpace = "testlandlord15-demo";
            string emailAddressMarketplaceAdmin = "marketplaceadmin15@putsbox.com";
            string fullNameMarketplaceAdmin = "Mark Adm";

            var marketplaceAdmin = new MarketplaceAdmin()
            {
                FirstName = firsName,
                LastName = lastName,
                EmailAddress = shortEmail + EmailNameDomen.PUTS_BOX,
                ShortEmail = shortEmail,
                SubdomainMySpace = subdomainMySpace,
                EmailAddressMarketplaceAdmin = emailAddressMarketplaceAdmin,
                FullNameMarketplaceAdmin = fullNameMarketplaceAdmin,
            };
            return marketplaceAdmin;
        }
    }
}
