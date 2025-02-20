using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;

namespace CazamioNewProject.PageObjects.AdminPages.SidebarPage
{
    public partial class SidebarLandlord
    {
        [AllureStep("VerifySuperAdminUserNameAndRole")]
        public SidebarLandlord VerifySuperAdminUserNameAndRole(string getUserNameActual, string getUserNameRoleActual)
        {
            WaitUntil.WaitSomeInterval(500);
            string getUserNameExpected = superAdmin.FullNameSuperAdmin;
            string getUserNameRoleExpected = TestDataLandlord.USER_NAME_ROLE_SUPER_ADMIN;

            Assert.Multiple(() =>
            {
                Assert.AreEqual(getUserNameExpected, getUserNameActual, $"User Name not equal");
                Assert.AreEqual(getUserNameRoleExpected, getUserNameRoleActual, $"User Name Role not equal");

                Console.WriteLine($"Full name EX: {getUserNameExpected} AC: {getUserNameActual}");
                Console.WriteLine($"Name role EX: {getUserNameRoleExpected} AC: {getUserNameRoleActual}");
            });

            return this;
        }

        [AllureStep("VerifyMarketplaceAdminUserNameAndRole")]
        public SidebarLandlord VerifyMarketplaceAdminUserNameAndRole(string getUserNameActual, string getUserNameRoleActual)
        {
            WaitUntil.WaitSomeInterval(500);
            string getUserNameExpected = marketplaceAdmin.CreatedMarkAdmMySpace.FullName;
            string getUserNameRoleExpected = TestDataLandlord.USER_NAME_ROLE_MARKETPLACE_ADMIN;

            Assert.Multiple(() =>
            {
                Assert.AreEqual(getUserNameExpected, getUserNameActual, $"User Name not equal");
                Assert.AreEqual(getUserNameRoleExpected, getUserNameRoleActual, $"User Name Role not equal");

                Console.WriteLine($"Full name EX: {getUserNameExpected} AC: {getUserNameActual}");
                Console.WriteLine($"Name role EX: {getUserNameRoleExpected} AC: {getUserNameRoleActual}");
            });
            return this;
        }

        [AllureStep("VerifyMarketplaceAdminUserNameAndRoleCreating")]
        public SidebarLandlord VerifyMarketplaceAdminUserNameAndRoleCreating(string getUserNameRoleMarketplaceAdmin)
        {
            WaitUntil.WaitSomeInterval(100);
            string getUserNameRoleExpected = TestDataLandlord.USER_NAME_ROLE_MARKETPLACE_ADMIN;

            Assert.Multiple(() =>
            {
                Assert.AreEqual(getUserNameRoleExpected, getUserNameRoleMarketplaceAdmin, $"User Name Role not equal");
            });
            return this;
        }

        [AllureStep("VerifyBrokerUserNameAndRole")]
        public SidebarLandlord VerifyBrokerUserNameAndRole(string getUserNameActual, string getUserNameRoleActual)
        {
            WaitUntil.WaitSomeInterval(500);
            string getUserNameExpected = broker.CreatedBrokerMySpace.FullName;
            string getUserNameRoleExpected = TestDataLandlord.USER_NAME_ROLE_BROKER;

            Assert.Multiple(() =>
            {
                Assert.AreEqual(getUserNameExpected, getUserNameActual, $"User Name not equal");
                Assert.AreEqual(getUserNameRoleExpected, getUserNameRoleActual, $"User Name Role not equal");

                Console.WriteLine($"Full name EX: {getUserNameExpected} AC: {getUserNameActual}");
                Console.WriteLine($"Name Role EX: {getUserNameRoleExpected} AC: {getUserNameRoleActual}");
            });
            return this;
        }

        [AllureStep("VerifyBrokerUserNameAndRoleCreating")]
        public SidebarLandlord VerifyBrokerUserNameAndRoleCreating(string getUserNameRoleCompareBroker)
        {
            WaitUntil.WaitSomeInterval(100);
            string getUserNameRoleExpected = TestDataLandlord.USER_NAME_ROLE_BROKER;

            Assert.Multiple(() =>
            {
                Assert.AreEqual(getUserNameRoleExpected, getUserNameRoleCompareBroker, $"User Name Role not equal");
            });
            return this;
        }

        [AllureStep("VerifyAgentUserNameAndRole")]
        public SidebarLandlord VerifyAgentUserNameAndRole(string getUserNameActual, string getUserNameRoleActual)
        {
            WaitUntil.WaitSomeInterval(500);
            string getUserNameExpected = agent.CreatedAgentMySpace.FullName;
            string getUserNameRoleExpected = TestDataLandlord.USER_NAME_ROLE_AGENT;

            Assert.Multiple(() =>
            {
                Assert.AreEqual(getUserNameExpected, getUserNameActual, $"User Name not equal");
                Assert.AreEqual(getUserNameRoleExpected, getUserNameRoleActual, $"User Name Role not equal");

                Console.WriteLine($"Full name EX: {getUserNameExpected} AC: {getUserNameActual}");
                Console.WriteLine($"Name role EX: {getUserNameRoleExpected} AC: {getUserNameRoleActual}");
            });

            return this;
        }

        [AllureStep("VerifyAgentUserNameAndRoleCreating")]
        public SidebarLandlord VerifyAgentUserNameAndRoleCreating(string getUserNameRoleCompareAgent)
        {
            WaitUntil.WaitSomeInterval(500);
            string getUserNameExpected = agent.CreatedAgentMySpace.FullName;
            string getUserNameRoleExpected = TestDataLandlord.USER_NAME_ROLE_AGENT;

            Assert.Multiple(() =>
            {
                Assert.AreEqual(getUserNameRoleExpected, getUserNameRoleCompareAgent, $"User Name Role not equal");

                Console.WriteLine($"Name role EX: {getUserNameRoleExpected} AC: {getUserNameRoleCompareAgent}");
            });

            return this;
        }

        [AllureStep("VerifyAgentBrokerUserNameAndRole")]
        public SidebarLandlord VerifyAgentBrokerUserNameAndRole(string getUserNameActual, string getUserNameRoleActual)
        {
            WaitUntil.WaitSomeInterval(500);
            string getUserNameExpected = agentBroker.CreatedAgentMySpace.FullName;
            string getUserNameRoleExpected = TestDataLandlord.USER_NAME_ROLE_AGENT;

            Assert.Multiple(() =>
            {
                Assert.AreEqual(getUserNameExpected, getUserNameActual, $"User Name not equal");
                Assert.AreEqual(getUserNameRoleExpected, getUserNameRoleActual, $"User Name Role not equal");

                Console.WriteLine($"Full name EX: {getUserNameExpected} AC: {getUserNameActual}");
                Console.WriteLine($"Name Role EX: {getUserNameRoleExpected} AC: {getUserNameRoleActual}");
            });

            return this;
        }
    }
}
