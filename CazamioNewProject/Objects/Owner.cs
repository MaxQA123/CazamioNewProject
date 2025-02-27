using CazamioNewProject.GuiHelpers;
using RimuTec.Faker;

namespace CazamioNewProject.Objects
{
    public class Owner
    {
        public CompanyNameInfo CompanyName { get; set; }
        public OwnerNameInfo OwnerName { get; set; }
        public OwnerEmailInfo OwnerEmail { get; set; }
        public OfficeLocationInfo OfficeLocation { get; set; }
        public UserAssignedInfo UserAssigned { get; set; }
        public InternalNotesInfo InternalNotes { get; set; }
        public PhoneNumberInfo PhoneNumber { get; set; }
        public CommissionStructureInfo CommissionStructure { get; set; }
        public CreatedOwnerNoCommissioMySpaceInfo CreatedOwnerNoCommissioMySpace { get; set; }
        public CreatedOwnerOwnerAndTenantPaysMySpaceInfo CreatedOwnerOwnerAndTenantPaysMySpace { get; set; }
        public CreatedOwnerOwnerPaysMySpaceInfo CreatedOwnerOwnerPaysMySpace { get; set; }
        public CreatedOwnerTenantPaysMySpaceInfo CreatedOwnerTenantPaysMySpace { get; set; }

        public static Owner Generate()
        {
            return new Owner
            {
                CompanyName = CreateCompanyNameInfo(),
                OwnerName = CreateOwnerNameInfo(),
                OwnerEmail = CreateOwnerEmailInfo(),
                OfficeLocation = CreateOfficeLocationInfo(),
                UserAssigned = CreateUserAssignedInfo(),
                InternalNotes = CreateInternalNotesInfo(),
                PhoneNumber = CreatePhoneNumberInfo(),
                CommissionStructure = CreateCommissionStructureInfo(),
                CreatedOwnerNoCommissioMySpace = CreateCreatedOwnerNoCommissioMySpaceInfo(),
                CreatedOwnerOwnerAndTenantPaysMySpace = CreateCreatedOwnerOwnerAndTenantPaysMySpaceInfo(),
                CreatedOwnerOwnerPaysMySpace = CreateCreatedOwnerOwnerPaysMySpaceInfo(),
                CreatedOwnerTenantPaysMySpace = CreateCreatedOwnerTenantPaysMySpaceInfo(),
            };
        }

        public class CompanyNameInfo
        {
            public string OneLetter { get; set; }
            public string AssignedBrokerMaxSymbols { get; set; }
            public string AssignedAgentMaxSymbols { get; set; }
        }

        public class OwnerNameInfo
        {
            public string OneLetter { get; set; }
            public string FirstNameRandom { get; set; }
            public string LastNameRandom { get; set; }
            public string FirstLastNameRandom { get; set; }
        }

        public class OwnerEmailInfo
        {
            public string yahoo { get; set; }
            public string putsbox { get; set; }
            public string xitroo { get; set; }
            public string gmail { get; set; }
            public string EmailAddressOwnerForBroker { get; set; }
            public string EmailAddressOwnerForAgent { get; set; }
        }

        public class OfficeLocationInfo
        {
            public string NewYork { get; set; }
            public string Dallas { get; set; }
            public string Washington { get; set; }
        }

        public class UserAssignedInfo
        {
            public long OwnerIdWithBroker { get; set; }
            public long OwnerIdWithAgent { get; set; }
        }

        public class InternalNotesInfo
        {
            public string Long { get; set; }
            public string Short { get; set; }
        }

        public class PhoneNumberInfo
        {
            public string BasicFirst { get; set; }
            public string ExtensionFirst { get; set; }
            public string BasicSecond { get; set; }
            public string ExtensionSecond { get; set; }
            public long BasicApi { get; set; }
            public long ExtensionApi { get; set; }
        }

        public class CommissionStructureInfo
        {
            public long NoCommissionIdApi { get; set; }
            public long OwnerPaysComissionIdApi { get; set; }
            public string NoCommissionName { get; set; }
            public string OwnerPaysName { get; set; }
            public string TenantPaysName { get; set; }
            public string OwnerAndTenantPaysName { get; set; }
            public string OwnerNumberOfMonthsMin { get; set; }
            public string TenantNumberOfMonthsMin { get; set; }
            public string OwnerPercentageMin { get; set; }
            public string TenantPercentageMin { get; set; }
            public string TakeOffMin { get; set; }
            public string TenantNumberOfMonthsMax { get; set; }
            public string TakeOffMax { get; set; }
            public string OwnerNumberOfMonthsStatic { get; set; }
            public string TenantNumberOfMonthsStatic { get; set; }
            public string OwnerPercentageStatic { get; set; }
            public string TenantPercentageStatic { get; set; }
            public string TakeOffStatic { get; set; }
            public long OwnerNumberOfMonthsApi { get; set; }
            public long TenantNumberOfMonthsApi { get; set; }
            public long OwnerPercentageApi { get; set; }
            public long TenantPercentageApi { get; set; }
        }

        public class CreatedOwnerNoCommissioMySpaceInfo
        {
            public string OwnerName { get; set; }
            public long OwnerIdApi { get; set; }
        }

        public class CreatedOwnerOwnerAndTenantPaysMySpaceInfo
        {
            public string OwnerName { get; set; }
        }

        public class CreatedOwnerOwnerPaysMySpaceInfo
        {
            public string OwnerName { get; set; }
        }

        public class CreatedOwnerTenantPaysMySpaceInfo
        {
            public string OwnerName { get; set; }
        }

        private static CompanyNameInfo CreateCompanyNameInfo()
        {
            return new CompanyNameInfo
            {
                OneLetter = "L",
                AssignedBrokerMaxSymbols = "LLC assigned BROKER (!@#%$#) 12345 67890",
                AssignedAgentMaxSymbols = "LLC assigned AGENT W(!@#%$#) 12345 67890",
            };
        }

        private static OwnerNameInfo CreateOwnerNameInfo()
        {
            return new OwnerNameInfo
            {
                OneLetter = "T",
                FirstNameRandom = Name.FirstName(),
                LastNameRandom = Name.LastName(),
                FirstLastNameRandom = Name.FirstName() + " " + Name.LastName(),
            };
        }

        private static OwnerEmailInfo CreateOwnerEmailInfo()
        {
            return new OwnerEmailInfo
            {
                yahoo = GenerateRandomData.RandomEmail(1) + "@yahoo.com",
                putsbox = GenerateRandomData.RandomEmail(3) + "@putsbox.com",
                xitroo = GenerateRandomData.RandomEmail(10) + "@xitroo.com",
                gmail = GenerateRandomData.RandomEmail(15) + "@gmail.com",
                EmailAddressOwnerForBroker = "owner2for5broker@putsbox.com",
                EmailAddressOwnerForAgent = "owner2forag5bro@putsbox.com",
            };
        }

        private static OfficeLocationInfo CreateOfficeLocationInfo()
        {
            return new OfficeLocationInfo
            {
                NewYork = "New York",
                Dallas = "Dallas",
                Washington = "Washington",
            };
        }

        private static UserAssignedInfo CreateUserAssignedInfo()
        {
            return new UserAssignedInfo
            {
                OwnerIdWithBroker = 179, //Arnoldoni Columbini
                OwnerIdWithAgent = 178,
            };
        }

        private static InternalNotesInfo CreateInternalNotesInfo()
        {
            return new InternalNotesInfo
            {
                Long = "QA test owner INTERNAL NOTES Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus. Vivamus elementum semper nisi. Aenean vulputate eleifend tellus. Aenean leo ligula, porttitor eu, consequat vitae, eleifend ac, enim. Aliquam lorem ante, dapibus in, viverra quis, feugiat a, tellus. Phasellus viverra nulla ut metus varius laoreet. Quisque rutrum. Aenean imperdiet. Etiam ultricies nisi vel augue. Curabitur ullamcorper ultricies nisi. Nam eget dui. Etiam rhoncus. Maecenas tempus, tellus eget condimentum rhoncus, sem quam semper libero, sit amet adipiscing sem neque sed ipsum. Nam quam nunc, blandit vel, luctus pulvinar, hendrerit id, lorem. Maecenas nec odio et ante tincidunt tempus. Donec vitae sapien ut libero venenatis faucibus. Nullam quis ante. Etiam sit amet orci eget eros faucibus tincidunt. Duis leo. Sed fringilla mauris sit amet nibh. Donec sodales sagittis magna. Sed consequat, leo eget bibendum sodales, augue velit cursus nunc,",
                Short = "QA test owner INTERNAL NOTES",
            };
        }

        private static PhoneNumberInfo CreatePhoneNumberInfo()
        {
            return new PhoneNumberInfo
            {
                BasicFirst = "912" + GenerateRandomData.RandomPhoneNumber(7),
                ExtensionFirst = "320" + GenerateRandomData.RandomPhoneNumber(7),
                BasicSecond = "585" + GenerateRandomData.RandomPhoneNumber(7),
                ExtensionSecond = "325",
                BasicApi = long.Parse(GenerateRandomData.RandomNumberWithoutZero(10)),
                ExtensionApi = long.Parse(GenerateRandomData.RandomNumberWithoutZero(10)),
            };
        }

        private static CommissionStructureInfo CreateCommissionStructureInfo()
        {
            return new CommissionStructureInfo
            {
                NoCommissionIdApi = 1,
                OwnerPaysComissionIdApi = 2,
                NoCommissionName = "None",
                OwnerPaysName = "OwnerPays",
                TenantPaysName = "TenantPays",
                OwnerAndTenantPaysName = "OwnerAndTenantPays",
                OwnerNumberOfMonthsMin = "0.1",
                TenantNumberOfMonthsMin = "0.1",
                OwnerPercentageMin = "0.1",
                TenantPercentageMin = "0.1",
                TakeOffMin = "0.1",
                TenantNumberOfMonthsMax = "99.99",
                TakeOffMax = "99.99",
                OwnerNumberOfMonthsStatic = "1",
                TenantNumberOfMonthsStatic = "2",
                OwnerPercentageStatic = "55.99",
                TenantPercentageStatic = "79.8",
                TakeOffStatic = "15",
                OwnerNumberOfMonthsApi = long.Parse(GenerateRandomData.RandomNumberWithoutZero(10)),
                TenantNumberOfMonthsApi = long.Parse(GenerateRandomData.RandomNumberWithoutZero(10)),
                OwnerPercentageApi = long.Parse(GenerateRandomData.RandomNumberWithoutZero(10)),
                TenantPercentageApi = long.Parse(GenerateRandomData.RandomNumberWithoutZero(10)),
            };
        }

        private static CreatedOwnerNoCommissioMySpaceInfo CreateCreatedOwnerNoCommissioMySpaceInfo()
        {
            return new CreatedOwnerNoCommissioMySpaceInfo
            {
                OwnerName = "LLC Ag-Br Owner No commisions AutoTest",
                OwnerIdApi = 1,
            };
        }

        private static CreatedOwnerOwnerAndTenantPaysMySpaceInfo CreateCreatedOwnerOwnerAndTenantPaysMySpaceInfo()
        {
            return new CreatedOwnerOwnerAndTenantPaysMySpaceInfo
            {
                OwnerName = "LLC Br Owner OwnerAndTenantPaysCommissio",
            };
        }

        private static CreatedOwnerOwnerPaysMySpaceInfo CreateCreatedOwnerOwnerPaysMySpaceInfo()
        {
            return new CreatedOwnerOwnerPaysMySpaceInfo
            {
                OwnerName = "OOO Owner Assigned Broker OwnerPays Test",
            };
        }

        private static CreatedOwnerTenantPaysMySpaceInfo CreateCreatedOwnerTenantPaysMySpaceInfo()
        {
            return new CreatedOwnerTenantPaysMySpaceInfo
            {
                OwnerName = "Asig AgBr Owner TenantPays 12345 (!@#$%)",
            };
        }
    }
}
