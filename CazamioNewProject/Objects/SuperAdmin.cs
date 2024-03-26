using CazamioNewProject.GuiHelpers;
using RimuTec.Faker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public SuperAdmin Generate()
        {
            string firsName = "Super";
            string lastName = "User";
            string shortEmail = GenerateRandomData.RandomEmail(5) + GenerateRandomData.RandomNumberWithoutZero(3) + GenerateRandomData.RandomEmail(2);
            string subdomainMySpace = "testlandlord15-demo";
            string emailAddressSuperAdmin = "superadmin123@putsbox.com";
            string fullNameSuperAdmin = "Super User";

            var marketplaceAdmin = new SuperAdmin()
            {
                FirstName = firsName,
                LastName = lastName,
                EmailAddress = shortEmail + EmailNameDomen.PUTS_BOX,
                ShortEmail = shortEmail,
                SubdomainMySpace = subdomainMySpace,
                EmailAddressSuperAdmin = emailAddressSuperAdmin,
                FullNameSuperAdmin = fullNameSuperAdmin,
            };
            return marketplaceAdmin;
        }
    }
}
