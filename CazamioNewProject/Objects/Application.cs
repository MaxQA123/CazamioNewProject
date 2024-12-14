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
            public string FirstNameNewTenantMainApplicant { get; set; }
            public string LastNameNewTenantMainApplicant { get; set; }
        }

        private static TenantsDataInfo CreateTenantsDataInfo()
        {
            return new TenantsDataInfo
            {
                EmailNewTenantMainApplicant = "appl-myspace1-" + GenerateRandomData.RandomEmail(5) + EmailNameDomen.PUTS_BOX,
                FirstNameNewTenantMainApplicant = "Main" + Name.FirstName(),
                LastNameNewTenantMainApplicant = "Appl" + Name.LastName(),
            };
        }
    }
}
