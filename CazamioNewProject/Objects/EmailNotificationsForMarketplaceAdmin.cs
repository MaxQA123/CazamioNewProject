using System;

namespace CazamioNewProject.Objects
{
    public class EmailNotificationsForMarketplaceAdmin
    {
        public SubjectsAndBodiesBasicInfo SubjectsAndBodiesBasic { get; set; }

        public static EmailNotificationsForMarketplaceAdmin Generate()
        {
            return new EmailNotificationsForMarketplaceAdmin
            {
                SubjectsAndBodiesBasic = CreateSubjectsAndBodiesBasicInfo(),
            };
        }

        public class SubjectsAndBodiesBasicInfo
        {
            public string SubjectCreatingNewMarketplaceAdminMySpace { get; set; }
            public string FrstRwBodyCreatingNewMarketplaceAdminMySpace { get; set; }
        }

        private static SubjectsAndBodiesBasicInfo CreateSubjectsAndBodiesBasicInfo()
        {
            return new SubjectsAndBodiesBasicInfo
            {
                SubjectCreatingNewMarketplaceAdminMySpace = "Welcome Aboard as a Marketplace Admin at Noyo Properties NYC!",
                FrstRwBodyCreatingNewMarketplaceAdminMySpace = "Dear BaryQa,",
            };
        }
    }
}
