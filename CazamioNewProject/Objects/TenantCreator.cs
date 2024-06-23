using CazamioNewProject.GuiHelpers;
using RimuTec.Faker;

namespace CazamioNewProject.Objects
{
    public class TenantCreator
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FirstNameTenant { get; set; }
        public string LastNameTenant { get; set; }
        public string FullNameTenant { get; set; }
        public string RandomFirstName { get; set; }
        public EmailInfo Email { get; set; }
        public NameDataInfo NameData { get; set; }

        public class EmailInfo
        {
            public string RandomEmailAddressPutsBox { get; set; }
            public string RandomShortEmail { get; set; }
            public string CreatedEmailTenant { get; set; }
        }

        public class NameDataInfo
        {
            public string ConstantFirstName { get; set; }
            public string ConstantLastName { get; set; }
            public string RandomFirstName { get; set; }
            public string RandomLastName { get; set; }
            public string CreatedFirstName { get; set; }
            public string CreatedLastName { get; set; }
            public string ConstantFirstLastName { get; set; }
        }

        public TenantCreator Generate()
        {
            string constantFirstName = "Appl Tenant QA";
            string constantLastName = "Lee Wu Alabanesku";
            string randomFirstName = Name.FirstName();
            string randomLastName = Name.LastName();
            string randomShortEmail = GenerateRandomData.RandomEmail(5) + GenerateRandomData.RandomNumberWithoutZero(3) + GenerateRandomData.RandomEmail(2);
            string createdEmailTenant = "appl-qaautotest15@putsbox.com";
            string createdFirstName = "Magdolina";
            string createdLastName = "Feofanovna";
            string constantFirstLastName = createdFirstName + " " + createdLastName;
           
            var tenantApplicant = new TenantCreator()
            {
                Email = new EmailInfo
                {
                    RandomEmailAddressPutsBox = randomShortEmail + EmailNameDomen.PUTS_BOX,
                    RandomShortEmail = randomShortEmail,
                    CreatedEmailTenant = createdEmailTenant
                },
                NameData = new NameDataInfo
                {
                    ConstantFirstName = constantFirstName,
                    ConstantLastName = constantLastName,
                    RandomFirstName = randomFirstName,
                    RandomLastName = randomLastName,
                    CreatedFirstName = createdFirstName,
                    CreatedLastName = createdLastName,
                    ConstantFirstLastName = constantFirstLastName
                },
            };
            return tenantApplicant;
        }
    }
}
