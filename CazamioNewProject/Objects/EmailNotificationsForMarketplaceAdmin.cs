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
            public string SubjectExample { get; set; }
            public string Subject { get; set; }
            public string FrstRwBodyDear { get; set; }
            public string ScndRwBodyWelcome { get; set; }
            public string ThrdRwBodyWeAreDelighted { get; set; }
            public string FrthRwBodyToGetStarted { get; set; }
            public string FfthRwBodyOnlyTextCopyThePassword { get; set; }
            public string SxthRwBodyClickTheButtonGetStarted { get; set; }
            public string SvnthRwBodyOnlyTextPasteThePassword { get; set; }
            public string SvnthhRwBodyOnlyTextInThePasswordFieldForLogin { get; set; }
            public string EighthRwBodyOnlyTextPasteTheEmail { get; set; }
            public string EighthRwBodyOnlyTextInTheEmailFieldForLogin { get; set; }
            public string NineRwBodyClickTheLetsGoButtonToLogIn { get; set; }
            public string GetStartedBtnName { get; set; }
            public string TenthRwBodyPleaseContactOurSupportTeam { get; set; }
            public string EleventhRwBodyYourAccountWasCreated { get; set; }
        }

        private static SubjectAndBodyCreatingMarketplaceAdminInfo CreateSubjectAndBodyCreatingMarketplaceAdminInfo()
        {
            return new SubjectAndBodyCreatingMarketplaceAdminInfo
            {
                SubjectExample = "Welcome Aboard as a <User role who created> at <Brand name marketplace>!",
                Subject = "Welcome Aboard as a Marketplace Admin at Noyo Properties NYC!",
                FrstRwBodyDear = "Dear BaryQa,",
                ScndRwBodyWelcome = "Welcome to Noyo Properties NYC Real Estate!",
                ThrdRwBodyWeAreDelighted = "We are delighted to have you join us as a Marketplace Admin.",
                FrthRwBodyToGetStarted = "To get started:",
                FfthRwBodyOnlyTextCopyThePassword = "1. Copy the password:",
                SxthRwBodyClickTheButtonGetStarted = "2. Click the button \"Get started\".",
                SvnthRwBodyOnlyTextPasteThePassword = "3. Paste the password:",
                SvnthhRwBodyOnlyTextInThePasswordFieldForLogin = "in the \"Password\" field for login.",
                EighthRwBodyOnlyTextPasteTheEmail = "4. Paste the email",
                EighthRwBodyOnlyTextInTheEmailFieldForLogin = "in the \"Email\" field for login.",
                NineRwBodyClickTheLetsGoButtonToLogIn = "5. Click the \"LET'S GO\" button to log in.",
                GetStartedBtnName = "Get started",
                TenthRwBodyPleaseContactOurSupportTeam = "If you have any questions, please contact our support team or the user who created that account for you.",
                EleventhRwBodyYourAccountWasCreated = "Your account was created by Super User with the email superadmin123@putsbox.com.",
            };
        }
    }
}
