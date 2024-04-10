using CazamioNewProject.GuiHelpers;
using RimuTec.Faker;

namespace CazamioNewProject.Objects
{
    public class TenantGuarantor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string ShortEmail { get; set; }
        public string EmailAddressTenant { get; set; }
        public string FirstNameTenant { get; set; }
        public string LastNameTenant { get; set; }
        public string FullNameTenant { get; set; }

        public TenantGuarantor Generate()
        {
            string firsName = "TenantQA";
            string lastName = Name.LastName();
            string shortEmail = GenerateRandomData.RandomEmail(5) + GenerateRandomData.RandomNumberWithoutZero(3) + GenerateRandomData.RandomEmail(2);
            string emailAddressTenant = "tenantgua123jim@putsbox.com";
            string firstNameTenant = "Jimmy";
            string lastNameTenant = "Todeski";
            string fullNameTenant = firstNameTenant + " " + lastNameTenant;

            var tenantGuarantor = new TenantGuarantor()
            {
                FirstName = firsName,
                LastName = lastName,
                EmailAddress = shortEmail + EmailNameDomen.PUTS_BOX,
                ShortEmail = shortEmail,
                EmailAddressTenant = emailAddressTenant,
                FirstNameTenant = firstNameTenant,
                LastNameTenant = lastNameTenant,
                FullNameTenant = fullNameTenant,
            };
            return tenantGuarantor;
        }
    }
}
