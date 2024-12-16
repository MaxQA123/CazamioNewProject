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
            public string CreateTenantViaGetLink { get; set; }
        }

        private static SubjectsTenantGeneralInfo CreateSubjectsTenantGeneralInfo()
        {
            return new SubjectsTenantGeneralInfo
            {
                CreateTenantViaGetLink = "Welcome to Noyo Properties NYC! Let's begin your application process for 9998 Saint Johnson Place #1 now!",
            };
        }
    }
}
