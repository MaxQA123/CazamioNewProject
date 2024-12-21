using CazamioNewProject.GuiHelpers;
using RimuTec.Faker;

namespace CazamioNewProject.Objects
{
    public class Demo
    {
        public CompanyNameInfo CompanyName { get; set; }
        public OwnerNameInfo OwnerName { get; set; }
        public OwnerEmailInfo OwnerEmail { get; set; }
        public OfficeLocationInfo OfficeLocation { get; set; }
        public InternalNotesInfo InternalNotes { get; set; }
        public PhoneNumberInfo PhoneNumber { get; set; }

        public static Demo Generate()
        {
            return new Demo
            {
                CompanyName = CreateCompanyNameInfo(),
                OwnerName = CreateOwnerNameInfo(),
                OwnerEmail = CreateOwnerEmailInfo(),
                OfficeLocation = CreateOfficeLocationInfo(),
                InternalNotes = CreateInternalNotesInfo(),
                PhoneNumber = CreatePhoneNumberInfo(),
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
        }

        public class OfficeLocationInfo
        {
            public string NewYork { get; set; }
            public string Dallas { get; set; }
            public string Washington { get; set; }
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
                putsbox = GenerateRandomData.RandomEmail(3) + "@putsbox",
                xitroo = GenerateRandomData.RandomEmail(10) + "@xitroo",
                gmail = GenerateRandomData.RandomEmail(15) + "@gmail",
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
                ExtensionFirst = "320",
                BasicSecond = "585" + GenerateRandomData.RandomPhoneNumber(7),
                ExtensionSecond = "325",
                BasicApi = long.Parse(GenerateRandomData.RandomNumberWithoutZero(10)),
                ExtensionApi = long.Parse(GenerateRandomData.RandomNumberWithoutZero(10)),
            };
        }
    }
}
