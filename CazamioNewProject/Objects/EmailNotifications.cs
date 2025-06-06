﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.Objects
{
    public class EmailNotifications
    {
        //public SubjectsTenantGeneralInfo SubjectsTenantGeneral { get; set; }
        public SubjectsCreateTenantPlusAppInfo SubjectsCreateTenantPlusApp { get; set; }

        public static EmailNotifications Generate()
        {
            return new EmailNotifications
            {
                //SubjectsTenantGeneral = CreateSubjectsTenantGeneralInfo(),
                SubjectsCreateTenantPlusApp = CreateSubjectsCreateTenantPlusAppInfo(),
            };
        }

        //public class SubjectsTenantGeneralInfo
        //{
        //    public string CreateTenantViaGetLinkWithoutAgent { get; set; }
        //    public string CreateTenantViaPlusAppWithAgent { get; set; }
        //}

        public class SubjectsCreateTenantPlusAppInfo
        {
            public string CreateTenantViaGetLinkWithoutAgentSaintJohnsonPlace { get; set; }
            public string CreateTenantViaGetLinkWithAgentBrokerSaintJohnsonPlace { get; set; }
            public string CreateTenantViaGetLinkWithoutAgentAlbermaleRd { get; set; }
            public string CreateTenantViaPlusAppWithAgentWashingtonSquare { get; set; }
            public string CreateTenantOccupantViaPlusAppWithoutAgentAlbermaleRd { get; set; }
            public string CreateTenantOccupantViaPlusAppWithoutAgentDeanStreet { get; set; }
        }

        //private static SubjectsTenantGeneralInfo CreateSubjectsTenantGeneralInfo()
        //{
        //    return new SubjectsTenantGeneralInfo
        //    {
        //        CreateTenantViaGetLinkWithoutAgent = "Welcome to Noyo Properties NYC! Let's begin your application process for 9998 Saint Johnson Place #1 now!",
        //        CreateTenantViaPlusAppWithAgent = "Welcome to Noyo Properties NYC! Lula AgentQA created you an application for 1 Washington Square #8R.",
        //    };
        //}

        private static SubjectsCreateTenantPlusAppInfo CreateSubjectsCreateTenantPlusAppInfo()
        {
            return new SubjectsCreateTenantPlusAppInfo
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
