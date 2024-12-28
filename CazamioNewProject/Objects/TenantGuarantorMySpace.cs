using CazamioNewProject.GuiHelpers;
using RimuTec.Faker;

namespace CazamioNewProject.Objects
{
    public class TenantGuarantorMySpace
    {
        public FirstLastNameGeneralDataInfo FirstLastNameGeneralData { get; set; }
        public EmailsInfo Emails { get; set; }
        public CreatedWitoutCreditReportInfo CreatedWitoutCreditReport { get; set; }
        public CreatedWithCreditReportInfo CreatedWithCreditReport { get; set; }

        public static TenantGuarantorMySpace Generate()
        {
            return new TenantGuarantorMySpace
            {
                FirstLastNameGeneralData = CreateFirstLastNameGeneralDataInfo(),
                Emails = CreateEmailsInfo(),
                CreatedWitoutCreditReport = CreateCreatedWitoutCreditReportInfo(),
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
            public string RandomEmail { get; set; }
        }

        public class CreatedWitoutCreditReportInfo
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
                RandomFirstName = "Guarantor-MySpace" + Name.FirstName(),
                RandomLastName = "GuarantorMySp" + Name.LastName(),
            };
        }

        private static EmailsInfo CreateEmailsInfo()
        {
            return new EmailsInfo
            {
                RandomEmail = "guar-myspace-" + GenerateRandomData.RandomNumberByDateTime() + EmailNameDomen.PUTS_BOX,
            };
        }

        private static CreatedWitoutCreditReportInfo CreateCreatedWitoutCreditReportInfo()
        {
            return new CreatedWitoutCreditReportInfo
            {
                ConstantFirstName = "GuarMySpace-WithoutCR",
                ConstantLastName = "MikaGuarMyspaceQA",
                ConstantFirstLastName = "GuarMySpace-WithoutCR MikaGuarMyspaceQA",
                Email = "guar-1myspace@putsbox.com",
            };
        }

        private static CreatedWithCreditReportInfo CreateCreatedWithCreditReportInfo()
        {
            return new CreatedWithCreditReportInfo
            {
                ConstantFirstName = "GuarMySpace-WithCR",
                ConstantLastName = "MagaGuarMyspaceQA",
                ConstantFirstLastName = "GuarMySpace-WithCR MagaGuarMyspaceQA",
                Email = "guar-2myspace@putsbox.com",
            };
        }
    }
}
