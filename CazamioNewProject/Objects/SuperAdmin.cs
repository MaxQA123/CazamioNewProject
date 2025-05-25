using CazamioNewProject.GuiHelpers;

namespace CazamioNewProject.Objects
{
    public class SuperAdmin
    { 
        public CreatedSuperAdminInfo CreatedSuperAdmin { get; set; }
        public ApiDataInfo ApiData { get; set; }

        public static SuperAdmin Generate()
        {
            return new SuperAdmin
            {
                CreatedSuperAdmin = CreateCreatedSuperAdminInfo(),
                ApiData = CreateApiDataInfo(),
            };
        }

        public class CreatedSuperAdminInfo
        {
            public string Email { get; set; }
            public string FullName { get; set; }
        }

        public class ApiDataInfo
        {
            public string DeviceFingerprint { get; set; }
            public bool True { get; set; }
        }

        private static CreatedSuperAdminInfo CreateCreatedSuperAdminInfo()
        {
            return new CreatedSuperAdminInfo
            {
                Email = "superadmin123@putsbox.com",
                FullName = "Super User",
            };
        }

        private static ApiDataInfo CreateApiDataInfo()
        {
            return new ApiDataInfo
            {
                DeviceFingerprint = "d86d2f3b2f8e0030f57cfb1ce82f3f25",
                True = true,
            };
        }
    }
}
