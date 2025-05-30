using System;

namespace CazamioNewProject.Objects
{
    public class EmailNotificationsForMarketplaceAdmin
    {
        public SubjectAndBodyCreatingMarketplaceAdminInfo SubjectAndBodyCreatingMarketplaceAdmin { get; set; }

        public static EmailNotificationsForMarketplaceAdmin Generate()
        {
            return new EmailNotificationsForMarketplaceAdmin
            {
                SubjectAndBodyCreatingMarketplaceAdmin = CreateSubjectAndBodyCreatingMarketplaceAdminInfo(),
            };
        }

        public class SubjectAndBodyCreatingMarketplaceAdminInfo
        {
            public string Subject { get; set; }
            public string FrstRwBodyDear { get; set; }
            public string ScndRwBodyWelcome { get; set; }
            public string ThrdRwBodyWeAreDelighted { get; set; }
            public string FrthRwBodyToGetStarted { get; set; }
            public string FfthRwBodyCopyThePassword { get; set; }
            public string SxthRwBodyClickTheButtonGetStarted { get; set; }
            //public string FrthRwBodyWeAreDelighted { get; set; }
            //public string FrthRwBodyWeAreDelighted { get; set; }
        }

        private static SubjectAndBodyCreatingMarketplaceAdminInfo CreateSubjectAndBodyCreatingMarketplaceAdminInfo()
        {
            return new SubjectAndBodyCreatingMarketplaceAdminInfo
            {
                Subject = "Welcome Aboard as a Marketplace Admin at Noyo Properties NYC!",
                FrstRwBodyDear = "Dear BaryQa,",
                ScndRwBodyWelcome = "Welcome to Noyo Properties NYC Real Estate!",
                ThrdRwBodyWeAreDelighted = "We are delighted to have you join us as a Marketplace Admin.",
                FrthRwBodyToGetStarted = "To get started:",
                FfthRwBodyCopyThePassword = "1. Copy the password:",
                SxthRwBodyClickTheButtonGetStarted = "2. Click the button \"Get started\".",
            };
        }
    }
}
