using CazamioNewProject.GuiHelpers;
using RimuTec.Faker;

namespace CazamioNewProject.Objects
{
    public class Application
    {
        public TenantsDataInfo TenantsData { get; set; }

        public static Application Generate()
        {
            return new Application
            {
                TenantsData = CreateTenantsDataInfo(),
            };
        }

        public class TenantsDataInfo
        {
            public string EmailNewTenantMainApplicant { get; set; }
        }

        private static TenantsDataInfo CreateTenantsDataInfo()
        {
            return new TenantsDataInfo
            {
                EmailNewTenantMainApplicant = "appl-myspace-" + GenerateRandomData.RandomNumberByDateTime + EmailNameDomen.PUTS_BOX,
            };
        }
    }
}
