using CazamioNewProject.GuiHelpers;
using RimuTec.Faker;

namespace CazamioNewProject.Objects
{
    public class TenantOccupantMySpace
    {
        public FirstLastNameGeneralDataInfo FirstLastNameGeneralData { get; set; }
        public EmailsInfo Emails { get; set; }
        public CreatedWitoutCreditReportInfo CreatedWitoutCreditReport { get; set; }
        public CreatedWithCreditReportInfo CreatedWithCreditReport { get; set; }

        public static TenantOccupantMySpace Generate()
        {
            return new TenantOccupantMySpace
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
                RandomFirstName = "Occupant-MySpace" + Name.FirstName(),
                RandomLastName = "Occup-MySp" + Name.LastName(),
            };
        }

        private static EmailsInfo CreateEmailsInfo()
        {
            return new EmailsInfo
            {
                RandomEmail = "ocup-myspace-" + GenerateRandomData.RandomNumberByDateTime() + EmailNameDomen.PUTS_BOX,
            };
        }

        private static CreatedWitoutCreditReportInfo CreateCreatedWitoutCreditReportInfo()
        {
            return new CreatedWitoutCreditReportInfo
            {
                ConstantFirstName = "OccupMySpace-WithoutCR",
                ConstantLastName = "KaraOcupMyspaceQA",
                ConstantFirstLastName = "OccupMySpace-WithoutCR KaraOcupMyspaceQA",
                Email = "occup-1myspace@putsbox.com",
            };
        }

        private static CreatedWithCreditReportInfo CreateCreatedWithCreditReportInfo()
        {
            return new CreatedWithCreditReportInfo
            {
                ConstantFirstName = "OccupMySpace-WithCR",
                ConstantLastName = "DeniOcupMyspaceQA",
                ConstantFirstLastName = "OccupMySpace-WithCR DeniOcupMyspaceQA",
                Email = "occup-2myspace@putsbox.com",
            };
        }
    }
}
