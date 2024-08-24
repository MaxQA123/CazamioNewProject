using CazamioNewProject.GuiHelpers;

namespace CazamioNewProject.Objects
{
    public class Demo
    {
        public SaintJohnsonPlInfo SaintJohnsonPl { get; set; }

        public static Demo Generate()
        {
            return new Demo
            {
                SaintJohnsonPl = CreateSaintJohnsonPlInfo(),
            };
        }

        public class SaintJohnsonPlInfo
        {
            public string NumberAddress { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Zip { get; set; }
            public string Neighborhood { get; set; }
            public string BuildingName { get; set; }
            public string LlcName { get; set; }
        }

        private static SaintJohnsonPlInfo CreateSaintJohnsonPlInfo()
        {
            return new SaintJohnsonPlInfo
            {
                NumberAddress = "9997",
                Address = "Saint Johnson Place",
                City = "Brooklyn",
                State = "NY",
                Zip = "11213",
                Neighborhood = "Crown Heights",
                BuildingName = "Building Name",
                LlcName = "LLC Name",
            };
        }
    }
}
