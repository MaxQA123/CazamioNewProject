using System;

namespace CazamioNewProject.Objects
{
    public class EmailNotificationsForMarketplaceAdmin
    {
        public SubjectsBasicInfo SubjectsBasic { get; set; }

        public static EmailNotificationsForMarketplaceAdmin Generate()
        {
            return new EmailNotificationsForMarketplaceAdmin
            {
                SubjectsBasic = CreateSubjectsBasicInfo(),
            };
        }

        public class SubjectsBasicInfo
        {
            public string CreateTenantViaGetLinkWithoutAgentSaintJohnsonPlace { get; set; }
            public string CreateTenantViaGetLinkWithAgentBrokerSaintJohnsonPlace { get; set; }
            public string CreateTenantViaGetLinkWithoutAgentAlbermaleRd { get; set; }
            public string CreateTenantViaPlusAppWithAgentWashingtonSquare { get; set; }
            public string CreateTenantOccupantViaPlusAppWithoutAgentAlbermaleRd { get; set; }
            public string CreateTenantOccupantViaPlusAppWithoutAgentDeanStreet { get; set; }
        }

        private static SubjectsBasicInfo CreateSubjectsBasicInfo()
        {
            return new SubjectsBasicInfo
            {
                CreateTenantViaGetLinkWithoutAgentSaintJohnsonPlace = "Welcome to Noyo Properties NYC! Let's begin your application process for 9998 Saint Johnson Place #1 now!",
                CreateTenantViaGetLinkWithAgentBrokerSaintJohnsonPlace = "Welcome to Noyo Properties NYC! Agentus Brokerus created you an application for 9998 Saint Johnson Place #1.",
                CreateTenantViaGetLinkWithoutAgentAlbermaleRd = "Welcome to Noyo Properties NYC! Leoautotest Feabroker created you an application for 9A Albermale Rd #1.",
                CreateTenantViaPlusAppWithAgentWashingtonSquare = "Welcome to Noyo Properties NYC! Lula AgentQA created you an application for 1 Washington Square #8R.",
                CreateTenantOccupantViaPlusAppWithoutAgentAlbermaleRd = "Welcome to Noyo Properties NYC! Let's begin your application process for 9A Albermale Rd #1 now!",
                CreateTenantOccupantViaPlusAppWithoutAgentDeanStreet = "Welcome to Noyo Properties NYC! Let's begin your application process for 12567 Dean Street #1 now!",
            };
        }
    }
}
