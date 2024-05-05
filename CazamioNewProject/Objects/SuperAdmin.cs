using CazamioNewProject.GuiHelpers;

namespace CazamioNewProject.Objects
{
    public class SuperAdmin
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string ShortEmail { get; set; }
        public string SubdomainMySpace { get; set; }
        public string EmailAddressSuperAdmin { get; set; }
        public string FullNameSuperAdmin { get; set; }
        public string DeviceFingerprint { get; set; }

        public SuperAdmin Generate()
        {
            string firsName = "Super";
            string lastName = "User";
            string shortEmail = GenerateRandomData.RandomEmail(5) + GenerateRandomData.RandomNumberWithoutZero(3) + GenerateRandomData.RandomEmail(2);
            string subdomainMySpace = "testlandlord15-demo";
            string emailAddressSuperAdmin = "superadmin123@putsbox.com";
            string fullNameSuperAdmin = "Super User";
            string deviceFingerprint = "d86d2f3b2f8e0030f57cfb1ce82f3f25";

            var marketplaceAdmin = new SuperAdmin()
            {
                FirstName = firsName,
                LastName = lastName,
                EmailAddress = shortEmail + EmailNameDomen.PUTS_BOX,
                ShortEmail = shortEmail,
                SubdomainMySpace = subdomainMySpace,
                EmailAddressSuperAdmin = emailAddressSuperAdmin,
                FullNameSuperAdmin = fullNameSuperAdmin,
                DeviceFingerprint = deviceFingerprint,
            };
            return marketplaceAdmin;
        }
    }
}
