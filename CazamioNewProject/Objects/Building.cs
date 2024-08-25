using CazamioNewProject.GuiHelpers;

namespace CazamioNewProject.Objects
{
    public class Building
    {
        public TextLoremInfo TextLorem { get; set; }
        public NameLocationInfo NameLocation { get; set; }
        public ConcessionsInfo Concessions { get; set; }
        public FreeStuffInfo FreeStuff { get; set; }
        public AdditionalInfoInfo AdditionalInfo { get; set; }

        public class TextLoremInfo
        {
            public string TextLoremCommon { get; set; }
            public string TextLoremForPinCode { get; set; }
            public string TextLoremForNote { get; set; }
        }

        public class NameLocationInfo
        {
            public string MainEntrance { get; set; }
            public string Apartment { get; set; }
        }

        public class ConcessionsInfo
        {
            public string NameFirst { get; set; }
            public string RandomMonthsFree { get; set; }
            public string OneMonthYearFree { get; set; }
            public string TwoMonthsFree { get; set; }
            public string RandomLeaseTerms { get; set; }
            public string TwelveMonthsLeaseTerms { get; set; }
            public string OneYearLeaseTerms { get; set; }
        }

        public class FreeStuffInfo
        {
            public string NameFirst { get; set; }
        }

        public class AdditionalInfoInfo
        {
            public string ShortInfo { get; set; }
            public string LongInfo { get; set; }
        }

        public Building Generate()
        {
            string textLoremCommon = "Lorem BUILDING ipsum dolor sit amet, 12345 67890 !@# $%^ &*() adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus. Vivamus elementum semper nisi. Aenean vulputate eleifend tellus. Aenean leo ligula, porttitor eu, consequat vitae, eleifend ac, enim. Aliquam lorem ante, dapibus in, viverra quis, feugiat a, tellus. Phasellus viverra nulla ut metus varius laoreet. Quisque rutrum. Aenean imperdiet. Etiam ultricies nisi vel augue. Curabitur ullamcorper ultricies nisi. Nam eget dui. Etiam rhoncus. Maecenas tempus, tellus eget condimentum rhoncus, sem quam semper libero, sit amet adipiscing sem neque sed ipsum. Nam quam nunc, blandit vel, luctus pulvinar, hendrerit id, lorem. Maecenas nec odio et ante tincidunt tempus. Donec vitae sapien ut libero venenatis faucibus. Nullam quis ante. Etiam sit amet orci eget eros faucibus tincidunt. Duis leo. Sed fringilla mauris sit amet nibh. Donec sodales sagittis magna. Sed consequat, leo eget bibendum sodales, augue velit cursus nunc,";
            string textLoremForPinCode = "Lorem PinCode Building (12345) (&%$#@!)";
            string textLoremForNote = "Lorem NOTE Building (12345) (&%$#@!)";
            string firstLocationMainEntrance = "Main Entrance";
            string secondLocationApartment = "Apartment";

            string defaultRentalTerms = "12 months";
            string nameConcessionFirst = "Conces Building 1";
            string randomMonthsFree = GenerateRandomData.RandomNumberWithoutZero(1);
            string oneMonthYearFree = "1";
            string twoMonthsFree = "2";
            string randomLeaseTerms = GenerateRandomData.RandomNumberWithoutZero(1);
            string twelveMonthsLeaseTerms = "12";

            string nameFirst = "Free Stuff Building 1";
            string shortInfo = "Lorem ADDITIONAL INFO BUILDING 12345 (09876) (*&%$#@!)";
            string longInfo = "Lorem ADDITIONAL INFO BUILDING 12345 (09876) Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus. Vivamus elementum semper nisi. Aenean vulputate eleifend tellus. Aenean leo ligula, porttitor eu, consequat vitae, eleifend ac, enim. Aliquam lorem ante, dapibus in, viverra quis, feugiat a, tellus. Phasellus viverra nulla ut metus varius laoreet. Quisque rutrum. Aenean imperdiet. Etiam ultricies nisi vel augue. Curabitur ullamcorper ultricies nisi. Nam eget dui. Etiam rhoncus. Maecenas tempus, tellus eget condimentum rhoncus, sem quam semper libero, sit amet adipiscing sem neque sed ipsum. Nam quam nunc, blandit vel, luctus pulvinar, hendrerit id, lorem. Maecenas nec odio et ante tincidunt tempus. Donec vitae sapien ut libero venenatis faucibus. Nullam quis ante. Etiam sit amet orci eget eros faucibus tincidunt. Duis leo. Sed fringilla mauris sit amet nibh. Donec sodales sagittis magna. Sed consequat, leo eget bibendum sodales, augue velit cursus nunc,";

            var building = new Building()
            {
                TextLorem = new TextLoremInfo
                {
                    TextLoremCommon = textLoremCommon,
                    TextLoremForPinCode = textLoremForPinCode,
                    TextLoremForNote = textLoremForNote
                },
                NameLocation = new NameLocationInfo
                {
                    MainEntrance = firstLocationMainEntrance,
                    Apartment = secondLocationApartment
                },
                Concessions = new ConcessionsInfo
                {
                    NameFirst = nameConcessionFirst,
                    RandomMonthsFree = randomMonthsFree,
                    OneMonthYearFree = oneMonthYearFree,
                    TwoMonthsFree = twoMonthsFree,
                    RandomLeaseTerms = randomLeaseTerms,
                    TwelveMonthsLeaseTerms = twelveMonthsLeaseTerms,
                    OneYearLeaseTerms = oneMonthYearFree
                },
                FreeStuff = new FreeStuffInfo
                {
                    NameFirst = nameFirst
                },
                AdditionalInfo = new AdditionalInfoInfo
                {
                    ShortInfo = shortInfo,
                    LongInfo = longInfo
                },
            };
            return building;
        }
    }
}
