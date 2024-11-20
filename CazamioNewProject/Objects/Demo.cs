using CazamioNewProject.GuiHelpers;
using RimuTec.Faker;

namespace CazamioNewProject.Objects
{
    public class Demo
    {
        public TenantsDataInfo TenantsData { get; set; }

        public static Demo Generate()
        {
            return new Demo
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
                EmailNewTenantMainApplicant = "appl-myspace1-" + GenerateRandomData.RandomEmail(5),
                FirstNameNewTenantMainApplicant = Name.FirstName(),
                LastNameNewTenantMainApplicant = Name.LastName(),
            };
        }
    }
}
