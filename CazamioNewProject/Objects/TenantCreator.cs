using CazamioNewProject.GuiHelpers;
using RimuTec.Faker;

namespace CazamioNewProject.Objects
{
    public class TenantCreator
    {
        public FirstLastNameDataInfo FirstLastNameData { get; set; }
        public EmailMySpaceInfo EmailMySpace { get; set; }

        public static TenantCreator Generate()
        {
            return new TenantCreator
            {
                FirstLastNameData = CreateFirstLastNameDataInfo(),
                EmailMySpace = CreateEmailMySpaceInfo(),
            };
        }

        public class FirstLastNameDataInfo
        {
            public string ConstantFirstName { get; set; }
            public string ConstantLastName { get; set; }
            public string ConstantFirstLastName { get; set; }
            public string ConstantFirstNameTenant { get; set; }
            public string ConstantLastNameTenant { get; set; }
            public string ConstantFirstLastNameTenant { get; set; }
            public string RandomFirstName { get; set; }
            public string RandomLastName { get; set; }
            public string CreatedLastName { get; set; }
        }

        public class EmailMySpaceInfo
        {
            public string RandomEmail { get; set; }
            public string ConstantEmail { get; set; }
            public string EmailAlreadyCreated { get; set; }
        }

        private static FirstLastNameDataInfo CreateFirstLastNameDataInfo()
        {
            return new FirstLastNameDataInfo
            {
                ConstantFirstName = "MainAppl",
                ConstantLastName = "JoeMainQA",
                ConstantFirstLastName = "MainAppl JoeMainQA",
                ConstantFirstNameTenant = "Tenant",
                ConstantLastNameTenant = "Generated",
                ConstantFirstLastNameTenant = "Tenant Generated",
                RandomFirstName = "Appl" + Name.FirstName(),
                RandomLastName = "Main" + Name.LastName(),
            };
        }

        private static EmailMySpaceInfo CreateEmailMySpaceInfo()
        {
            return new EmailMySpaceInfo
            {
                RandomEmail = "appl-myspace1-" + GenerateRandomData.RandomEmail(5) + EmailNameDomen.PUTS_BOX,
                EmailAlreadyCreated = "appl-qaautotest15@putsbox.com",
            };
        }
    }
}
