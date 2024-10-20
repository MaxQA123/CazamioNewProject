using CazamioNewProject.GuiHelpers;
using RimuTec.Faker;

namespace CazamioNewProject.Objects
{
    public class Owner
    {
        public string CompanyName { get; set; }
        public string CompanyNameWithBroker { get; set; }
        public string CompanyNameWithAgent { get; set; }
        public ListOwnersCompanyNameInfo ListOwnersCompanyName { get; set; }
        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string ShortEmail { get; set; }
        public string OfficeLocation { get; set; }
        public string InternalNotes { get; set; }
        public string PhoneNumber { get; set; }
        public long PhoneNumberApi { get; set; }
        public string ExtensionNumber { get; set; }
        public long ExtensionNumberApi { get; set; }
        public string OwnerNumberOfMonths { get; set; }
        public string TenantNumberOfMonths { get; set; }
        public string OwnerPercentage { get; set; }
        public string TenantPercentage { get; set; }
        public string TakeOff { get; set; }
        public long OwnerNumberOfMonthsApi { get; set; }
        public long TenantNumberOfMonthsApi { get; set; }
        public long OwnerPercentageApi { get; set; }
        public long TenantPercentageApi { get; set; }
        public long TakeOffApi { get; set; }
        public string EmailAddressOwnerForAgent { get; set; }
        public string EmailAddressOwnerForBroker { get; set; }
        public TypesCommissionStructureInfo TypesCommissionStructure{ get; set; }
        public OwnerIdInfo OwnerId { get; set; }

        public class TypesCommissionStructureInfo
        {
            public string None { get; set; }
            public string OwnerPays { get; set; }
            public string TenantPays { get; set; }
            public string OwnerAndTenantPays { get; set; }
        }

        public class OwnerIdInfo
        {
            public long WithBroker { get; set; }
            public long WithAgent { get; set; }
        }

        public class ListOwnersCompanyNameInfo
        {
            public string OwnerNoCommission { get; set; }
            public string OwnerWithOwnerPaysComission { get; set; }
            public string OwnerWithTenantPaysCommission { get; set; }
            public string OwnerWithOwnerAndTenantPaysCommission { get; set; }
        }

        public Owner Generate()
        {
            string companyName = "OOO assigned role";
            string roleBroker = "Broker";
            string roleAgent = "Agent";
            string lLCBrOwnerOwnerAndTenantPaysCommissio = "LLC Br Owner OwnerAndTenantPaysCommissio";
            string lLCAgBrOwnerNocommisionsAutoTest = "LLC Ag-Br Owner No commisions AutoTest";
            string ownerOwnerPaysAutotest = "Owner OwnerPays Autotest";
            string ownerTenantPays = "Ibrah Owner TenantPays LLC 12345 (!@#$%)";
            string FullName = Name.FirstName() + " " + Name.LastName();
            string firstName = Name.FirstName();
            string lastName = Name.LastName();
            string shortEmail = GenerateRandomData.RandomEmail(5) + GenerateRandomData.RandomNumberWithoutZero(3) + GenerateRandomData.RandomEmail(2);
            string officeLocation = Address.City();
            string internalNotes = "Owner lorem ipsum (12345) (&%$#@!)";
            string phoneNumber = "585" + GenerateRandomData.RandomPhoneNumber(7);
            long phoneNumberApi = long.Parse(GenerateRandomData.RandomNumberWithoutZero(10));
            long extensionNumberApi = long.Parse(GenerateRandomData.RandomNumberWithoutZero(1));
            string extensionNumber = "325" + GenerateRandomData.RandomPhoneNumber(7);
            string ownerNumberOfMonths = GenerateRandomData.RandomNumberWithoutZero(1);
            string tenantNumberOfMonths = GenerateRandomData.RandomNumberWithoutZero(1);
            string ownerPercentage = GenerateRandomData.RandomNumberWithoutZero(2);
            string tenantPercentage = GenerateRandomData.RandomNumberWithoutZero(2);
            string takeOff = GenerateRandomData.RandomNumberWithoutZero(2);
            string emailAddressOwnerForAgent = "owner2forag5bro@putsbox.com";
            string emailAddressOwnerForBroker = "owner2for5broker@putsbox.com";
            string noneCommissionStructure = "None";
            string ownerPays = "OwnerPays";
            string tenantPays = "TenantPays";
            string ownerAndTenantPays = "OwnerAndTenantPays";
            long ownerNumberOfMonthsApi = long.Parse(GenerateRandomData.RandomNumberWithoutZero(1));
            long tenantNumberOfMonthsApi = long.Parse(GenerateRandomData.RandomNumberWithoutZero(1));
            long ownerPercentageApi = long.Parse(GenerateRandomData.RandomNumberWithoutZero(2));
            long tenantPercentageApi = long.Parse(GenerateRandomData.RandomNumberWithoutZero(2));
            long takeOffApi = long.Parse(GenerateRandomData.RandomNumberWithoutZero(1));
            long noCommission = 1;
            long ownerPaysComission = 2;
            long ownerIdWithBroker = 179;//Arnoldoni Columbini
            long ownerIdWithAgent = 178;

            var owner = new Owner()
            {
                CompanyName = companyName,
                CompanyNameWithAgent = companyName + " " + roleAgent,
                CompanyNameWithBroker = companyName + " " + roleBroker,
                FullName = FullName,
                FirstName = firstName,
                LastName = lastName,
                EmailAddress = shortEmail + EmailNameDomen.PUTS_BOX,
                ShortEmail = shortEmail,
                OfficeLocation = officeLocation,
                InternalNotes = internalNotes,
                PhoneNumber = phoneNumber,
                ExtensionNumber = extensionNumber,
                OwnerNumberOfMonths = ownerNumberOfMonths,
                TenantNumberOfMonths = tenantNumberOfMonths,
                OwnerPercentage = ownerPercentage,
                TenantPercentage = tenantPercentage,
                TakeOff = takeOff,
                EmailAddressOwnerForAgent = emailAddressOwnerForAgent,
                EmailAddressOwnerForBroker = emailAddressOwnerForBroker,
                TypesCommissionStructure = new TypesCommissionStructureInfo
                {
                    None = noneCommissionStructure,
                    OwnerPays = ownerPays,
                    TenantPays = tenantPays,
                    OwnerAndTenantPays = ownerAndTenantPays
                },
                OwnerNumberOfMonthsApi = ownerNumberOfMonthsApi,
                TenantNumberOfMonthsApi = tenantNumberOfMonthsApi,
                OwnerPercentageApi = ownerPercentageApi,
                TenantPercentageApi = tenantPercentageApi,
                TakeOffApi = takeOffApi,
                ExtensionNumberApi = extensionNumberApi,
                PhoneNumberApi = phoneNumberApi,
                OwnerId = new OwnerIdInfo
                {
                    WithBroker = ownerIdWithBroker,
                    WithAgent = ownerIdWithAgent,
                },
                ListOwnersCompanyName = new ListOwnersCompanyNameInfo
                {
                    OwnerNoCommission = lLCAgBrOwnerNocommisionsAutoTest,
                    OwnerWithOwnerPaysComission = ownerOwnerPaysAutotest,
                    OwnerWithTenantPaysCommission = ownerTenantPays,
                    OwnerWithOwnerAndTenantPaysCommission = lLCBrOwnerOwnerAndTenantPaysCommissio
                },
            };
            return owner;
        }
    }
}
