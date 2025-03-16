using CazamioNewProject.GuiHelpers;
using RimuTec.Faker;

namespace CazamioNewProject.Objects
{
    public class TenantCreatorMySpace
    {
        public FirstLastNameGeneralDataInfo FirstLastNameGeneralData { get; set; }
        public EmailsInfo Emails { get; set; }
        public CreatedWithoutCreditReportInfo CreatedWithoutCreditReport { get; set; }
        public CreatedWithCreditReportInfo CreatedWithCreditReport { get; set; }

        public static TenantCreatorMySpace Generate()
        {
            return new TenantCreatorMySpace
            {
                FirstLastNameGeneralData = CreateFirstLastNameGeneralDataInfo(),
                Emails = CreateEmailsInfo(),
                CreatedWithoutCreditReport = CreateCreatedWithoutCreditReportInfo(),
                CreatedWithCreditReport = CreateCreatedWithCreditReportInfo(),
            };
        }

        public class FirstLastNameGeneralDataInfo
        {
            public string ConstantFirstNameTenant { get; set; }
            public string ConstantLastNameTenant { get; set; }
            public string ConstantFirstLastNameTenant { get; set; }
            public string RandomFirstName { get; set; }
            public string RandomLastName { get; set; }
        }

        public class EmailsInfo
        {
            public string RandomMainApplicantEmail { get; set; }
        }

        public class CreatedWithoutCreditReportInfo
        {
            public string ConstantFirstName { get; set; }
            public string ConstantLastName { get; set; }
            public string ConstantFirstLastName { get; set; }
            public string Email { get; set; }
        }

        public class CreatedWithCreditReportInfo
        {
            public string ConstantFirstName { get; set; }
            public string ConstantLastName { get; set; }
            public string ConstantFirstLastName { get; set; }
            public string Email { get; set; }
        }

        private static FirstLastNameGeneralDataInfo CreateFirstLastNameGeneralDataInfo()
        {
            return new FirstLastNameGeneralDataInfo
            {
                ConstantFirstNameTenant = "Tenant",
                ConstantLastNameTenant = "Generated",
                ConstantFirstLastNameTenant = "Tenant Generated",
                RandomFirstName = "Appl-MySpace" + Name.FirstName(),
                RandomLastName = "Main-MySpace" + Name.LastName(),
            };
        }

        private static EmailsInfo CreateEmailsInfo()
        {
            return new EmailsInfo
            {
                RandomMainApplicantEmail = "appl-myspace-" + GenerateRandomData.RandomNumberByDateTime() + EmailNameDomen.PUTS_BOX,
            };
        }

        private static CreatedWithoutCreditReportInfo CreateCreatedWithoutCreditReportInfo()
        {
            return new CreatedWithoutCreditReportInfo
            {
                ConstantFirstName = "MainApplMySpace-WithoutCR",
                ConstantLastName = "JoeMainMyspaceQA",
                ConstantFirstLastName = "MainApplMySpace JoeMainMyspaceQA",
                Email = "main-appl-1myspace@putsbox.com",
            };
        }

        private static CreatedWithCreditReportInfo CreateCreatedWithCreditReportInfo()
        {
            return new CreatedWithCreditReportInfo
            {
                ConstantFirstName = "MainApplMySpace-WithCR",
                ConstantLastName = "SaraMainMyspaceQA",
                ConstantFirstLastName = "MainApplMySpace-WithCR SaraMainMyspaceQA",
                Email = "main-appl-2myspace@putsbox.com",
            };
        }
    }
}
