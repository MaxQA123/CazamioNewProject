using CazamioNewProject.GuiHelpers;
using RimuTec.Faker;

namespace CazamioNewProject.Objects
{
    public class DemoTemplate
    {
        public FirstLastNameDataInfo FirstLastNameData { get; set; }

        public static DemoTemplate Generate()
        {
            return new DemoTemplate
            {
                FirstLastNameData = CreateFirstLastNameDataInfo(),
            };
        }

        public class FirstLastNameDataInfo
        {
            public string ConstantFirstName { get; set; }
        }

        private static FirstLastNameDataInfo CreateFirstLastNameDataInfo()
        {
            return new FirstLastNameDataInfo
            {
                ConstantFirstName = "MainAppl",
            };
        }
    }
}
