using CazamioNewProject.GuiHelpers;
using RimuTec.Faker;

namespace CazamioNewProject.Objects
{
    public class Demo
    {
        public MarkAdmNameInfo MarkAdmName { get; set; }

        public static Demo Generate()
        {
            return new Demo
            {
                MarkAdmName = CreateMarkAdmNameInfo(),
            };
        }

        public class MarkAdmNameInfo
        {
            public string FirstNameRandom { get; set; }
            public string LastNameRandom { get; set; }
            public string FirstLastNameRandom { get; set; }
        }

        private static MarkAdmNameInfo CreateMarkAdmNameInfo()
        {
            return new MarkAdmNameInfo
            {
                FirstNameRandom = Name.FirstName(),
                LastNameRandom = Name.LastName(),
                FirstLastNameRandom = Name.FirstName() + " " + Name.LastName(),
            };
        }
    }
}
