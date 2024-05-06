using CazamioNewProject.GuiHelpers;

namespace CazamioNewProject.Objects
{
    public class SuperAdmin
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string ShortEmail { get; set; }
        public SubdomainsInfo Subdomains { get; set; }
        public string EmailAddressSuperAdmin { get; set; }
        public string FullNameSuperAdmin { get; set; }
        public string DeviceFingerprint { get; set; }

        public class SubdomainsInfo
        {
            public string MySpace { get; set; }
            public string Evergreen { get; set; }
            public string DoorWay { get; set; }
        }

        public SuperAdmin Generate()
        {
            string firsName = "Super";
            string lastName = "User";
            string shortEmail = GenerateRandomData.RandomEmail(5) + GenerateRandomData.RandomNumberWithoutZero(3) + GenerateRandomData.RandomEmail(2);
            string emailAddressSuperAdmin = "superadmin123@putsbox.com";
            string fullNameSuperAdmin = "Super User";
            string deviceFingerprint = "d86d2f3b2f8e0030f57cfb1ce82f3f25";
            string subDomainMySpace = "testlandlord15-demo";
            string subDomainEvergreen = "testlandlord17-demo";
            string subDomainDoorway = "testlandlord18-demo";

            var marketplaceAdmin = new SuperAdmin()
            {
                FirstName = firsName,
                LastName = lastName,
                EmailAddress = shortEmail + EmailNameDomen.PUTS_BOX,
                ShortEmail = shortEmail,
                Subdomains = new SubdomainsInfo
                {
                    MySpace = subDomainMySpace,
                    Evergreen = subDomainEvergreen,
                    DoorWay = subDomainDoorway
                },
                EmailAddressSuperAdmin = emailAddressSuperAdmin,
                FullNameSuperAdmin = fullNameSuperAdmin,
                DeviceFingerprint = deviceFingerprint,
            };
            return marketplaceAdmin;
        }
    }
}
