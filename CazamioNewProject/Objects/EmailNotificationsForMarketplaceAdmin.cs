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
            public string SubjectCreatingNewMarketplaceAdmin { get; set; }
            public string BodyCreatingNewMarketplaceAdmin { get; set; }
        }

        private static SubjectsAndBodiesBasicInfo CreateSubjectsAndBodiesBasicInfo()
        {
            return new SubjectsAndBodiesBasicInfo
            {
                SubjectCreatingNewMarketplaceAdmin = "Welcome Aboard as a Marketplace Admin at Noyo Properties NYC!",
                BodyCreatingNewMarketplaceAdmin = "",
            };
        }
    }
}
