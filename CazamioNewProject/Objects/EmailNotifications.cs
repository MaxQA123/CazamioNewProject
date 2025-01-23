using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.Objects
{
    public class EmailNotifications
    {
        public SubjectsTenantGeneralInfo SubjectsTenantGeneral { get; set; }

        public static EmailNotifications Generate()
        {
            return new EmailNotifications
            {
                SubjectsTenantGeneral = CreateSubjectsTenantGeneralInfo(),
            };
        }

        public class SubjectsTenantGeneralInfo
        {
            public string CreateTenantViaGetLinkWithoutAgent { get; set; }
            public string CreateTenantViaPlusAppWithAgent { get; set; }
        }

        private static SubjectsTenantGeneralInfo CreateSubjectsTenantGeneralInfo()
        {
            return new SubjectsTenantGeneralInfo
            {
                CreateTenantViaGetLinkWithoutAgent = "Welcome to Noyo Properties NYC! Let's begin your application process for 9998 Saint Johnson Place #1 now!",
                CreateTenantViaPlusAppWithAgent = "Welcome to Noyo Properties NYC! Lula AgentQA created you an application for 1 Washington Square #8R.",
            };
        }
    }
}
