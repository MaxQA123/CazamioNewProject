using System;

namespace CazamioNewProject.Objects
{
    public class BasicDataForProject
    {
        public PasswordsInfo Passwords { get; set; }
        public UserRolesInfo UserRoles { get; set; }
        public SubdomainMarketplaceInfo SubdomainMarketplace { get; set; }
        public IdOfMarketplacesInfo IdOfMarketplaces { get; set; }
        public SettingsMarketplaceMySpaceInfo SettingsMarketplaceMySpace { get; set; }

        public static BasicDataForProject Generate()
        {
            return new BasicDataForProject
            {
                Passwords = CreatePasswordsInfo(),
                UserRoles = CreateUserRolesInfo(),
                SubdomainMarketplace = CreateSubdomainMarketplaceInfo(),
                IdOfMarketplaces = CreateIdOfMarketplacesInfo(),
                SettingsMarketplaceMySpace = CreateSettingsMarketplaceMySpaceInfo(),
            };
        }

        public class PasswordsInfo
        {
            public string BasicStaticFirst { get; set; }
        }

        public class UserRolesInfo
        {
            public string SuperAdmin { get; set; }
            public string MarketplaceAdmin { get; set; }
            public string Broker { get; set; }
            public string Agent { get; set; }
        }

        public class SubdomainMarketplaceInfo
        {
            public string MySpace { get; set; }
            public string Evergreen { get; set; }
            public string Doorway { get; set; }
            public string Jrzee { get; set; }
        }

        public class IdOfMarketplacesInfo
        {
            public string MySpace { get; set; }
            public string Evergreen { get; set; }
            public string Doorway { get; set; }
            public string Jrzee { get; set; }
        }

        public class SettingsMarketplaceMySpaceInfo
        {
            public string BrandNameFirst { get; set; }
            public string BrandNameSecond { get; set; }
            public string Ownername { get; set; }
            public string CompanyFullLegalName { get; set; }
            public string Address { get; set; }
            public string PhoneNumber { get; set; }
            public string FacebookLink { get; set; }
            public string TwitterLink { get; set; }
            public string YouTubeLink { get; set; }
            public string LinkedInLink { get; set; }
            public string InstagramLink { get; set; }
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
                MarketplaceAdmin = "Marketplace Admin",
                Broker = "Broker",
                Agent = "Agent",
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

        private static IdOfMarketplacesInfo CreateIdOfMarketplacesInfo()
        {
            return new IdOfMarketplacesInfo
            {
                MySpace = "15",
                Evergreen = "17",
                Doorway = "18",
                Jrzee = "19",
            };
        }

        private static SettingsMarketplaceMySpaceInfo CreateSettingsMarketplaceMySpaceInfo()
        {
            return new SettingsMarketplaceMySpaceInfo
            {
                BrandNameFirst = "Noyo Properties NYC",
                BrandNameSecond = "MySpace NYC",
                Ownername = "Owner-MySpace Erik",
                CompanyFullLegalName = "LLC MySpace NYC",
                Address = "340-350 Patchen Avenue, Brooklyn, Bedford-Stuyvesant, NY, 15002",
                PhoneNumber = "2120981234",
                FacebookLink = "",
                TwitterLink = "",
                YouTubeLink = "",
                LinkedInLink = "",
                InstagramLink = "",
            };
        }
    }
}
