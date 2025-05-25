using System;

namespace CazamioNewProject.Objects
{
    public class BasicDataForProject
    {
        public PasswordsInfo Passwords { get; set; }
        public UserRolesInfo UserRoles { get; set; }
        public SubdomainMarketplaceInfo SubdomainMarketplace { get; set; }

        public static BasicDataForProject Generate()
        {
            return new BasicDataForProject
            {
                Passwords = CreatePasswordsInfo(),
                UserRoles = CreateUserRolesInfo(),
                SubdomainMarketplace = CreateSubdomainMarketplaceInfo(),
            };
        }

        public class PasswordsInfo
        {
            public string BasicStaticFirst { get; set; }
        }

        public class UserRolesInfo
        {
            public string SuperAdmin { get; set; }
        }

        public class SubdomainMarketplaceInfo
        {
            public string MySpace { get; set; }
            public string Evergreen { get; set; }
            public string Doorway { get; set; }
            public string Jrzee { get; set; }
        }

        private static PasswordsInfo CreatePasswordsInfo()
        {
            return new PasswordsInfo
            {
                BasicStaticFirst = "Qwerty123!",
            };
        }

        private static UserRolesInfo CreateUserRolesInfo()
        {
            return new UserRolesInfo
            {
                SuperAdmin = "Super Admin",
            };
        }

        private static SubdomainMarketplaceInfo CreateSubdomainMarketplaceInfo()
        {
            return new SubdomainMarketplaceInfo
            {
                MySpace = "testlandlord15-demo",
                Evergreen = "testlandlord17-demo",
                Doorway = "testlandlord18-demo",
                Jrzee = "",
            };
        }
    }
}
