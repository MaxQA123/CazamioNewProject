using CazamioNewProject.GuiHelpers;
using RimuTec.Faker;

namespace CazamioNewProject.Objects
{
    public class MarketplaceAdmin
    {
        public MarkAdmNameInfo MarkAdmName { get; set; }
        public MarkAdmEmailInfo MarkAdmEmail { get; set; }
        public SubdomainMarketplaceInfo SubdomainMarketplace { get; set; }
        public CreatedMarkAdmMySpaceInfo CreatedMarkAdmMySpace { get; set; }
        public BasicDataApiInfo BasicDataApi { get; set; }

        public static MarketplaceAdmin Generate()
        {
            return new MarketplaceAdmin
            {
                MarkAdmName = CreateMarkAdmNameInfo(),
                MarkAdmEmail = CreateMarkAdmEmailInfo(),
                SubdomainMarketplace = CreateSubdomainMarketplaceInfo(),
                CreatedMarkAdmMySpace = CreateCreatedMarkAdmMySpaceInfo(),
                BasicDataApi = CreateBasicDataApiInfo(),
            };
        }

        public class MarkAdmNameInfo
        {
            public string FirstNameRandom { get; set; }
            public string LastNameRandom { get; set; }
            public string FirstLastNameRandom { get; set; }
        }

        public class MarkAdmEmailInfo
        {
            public string FullEmailRandom { get; set; }
        }

        public class SubdomainMarketplaceInfo
        {
            public string MySpace { get; set; }
        }

        public class CreatedMarkAdmMySpaceInfo
        {
            public string FullName { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
        }

        public class BasicDataApiInfo
        {
            public string DeviceFingerprint { get; set; }
        }

        private static MarkAdmNameInfo CreateMarkAdmNameInfo()
        {
            return new MarkAdmNameInfo
            {
                FirstNameRandom = Name.FirstName(),
                LastNameRandom = Name.LastName(),
                FirstLastNameRandom = Name.FirstName() + " " + Name.LastName(),
            };
        }

        private static MarkAdmEmailInfo CreateMarkAdmEmailInfo()
        {
            return new MarkAdmEmailInfo
            {
                FullEmailRandom = GenerateRandomData.RandomEmail(5) + GenerateRandomData.RandomNumberWithoutZero(3) + GenerateRandomData.RandomEmail(2) + EmailNameDomen.PUTS_BOX,
            };
        }

        private static SubdomainMarketplaceInfo CreateSubdomainMarketplaceInfo()
        {
            return new SubdomainMarketplaceInfo
            {
                MySpace = "testlandlord15-demo",
            };
        }

        private static CreatedMarkAdmMySpaceInfo CreateCreatedMarkAdmMySpaceInfo()
        {
            return new CreatedMarkAdmMySpaceInfo
            {
                FullName = "Mark Adm",
                FirstName = "Mark",
                LastName = "Adm",
                Email = "marketplaceadmin15@putsbox.com",
            };
        }

        private static BasicDataApiInfo CreateBasicDataApiInfo()
        {
            return new BasicDataApiInfo
            {
                DeviceFingerprint = "4f09dee986d77232105bed94285eafe7",
            };
        }
    }
}
