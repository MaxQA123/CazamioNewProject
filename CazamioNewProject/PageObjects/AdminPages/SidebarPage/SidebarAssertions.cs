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

                Console.WriteLine($"First Last name EX: {getUserNameExpected} First Last name AC: {getUserNameActual}");
                Console.WriteLine($"Name role EX: {getUserNameRoleExpected} Name role AC: {getUserNameRoleActual}");
            });

            return this;
        }

        [AllureStep("VerifyMarketplaceAdminUserNameAndRole")]
        public SidebarLandlord VerifyMarketplaceAdminUserNameAndRole(string getUserNameActual, string getUserNameRoleActual)
        {
            WaitUntil.WaitSomeInterval(500);
            string getUserNameExpected = marketplaceAdmin.FullNameMarketplaceAdmin;
            string getUserNameRoleExpected = TestDataLandlord.USER_NAME_ROLE_MARKETPLACE_ADMIN;

            Assert.Multiple(() =>
            {
                Assert.AreEqual(getUserNameExpected, getUserNameActual, $"User Name not equal");
                Assert.AreEqual(getUserNameRoleExpected, getUserNameRoleActual, $"User Name Role not equal");

                Console.WriteLine($"First Last name EX: {getUserNameExpected} First Last name AC: {getUserNameActual}");
                Console.WriteLine($"Name Role EX: {getUserNameRoleExpected} Name Role AC: {getUserNameRoleActual}");
            });
            return this;
        }

        [AllureStep("VerifyMarketplaceAdminUserNameAndRoleCreating")]
        public SidebarLandlord VerifyMarketplaceAdminUserNameAndRoleCreating(string getUserNameRoleMarketplaceAdmin)
        {
            WaitUntil.WaitSomeInterval(500);
            string getUserNameExpected = marketplaceAdmin.FullNameMarketplaceAdmin;
            string getUserNameRoleExpected = TestDataLandlord.USER_NAME_ROLE_MARKETPLACE_ADMIN;

            Assert.Multiple(() =>
            {
                Assert.AreEqual(getUserNameRoleExpected, getUserNameRoleMarketplaceAdmin, $"User Name Role not equal");

                Console.WriteLine($"Name Role EX: {getUserNameRoleExpected} Name Role AC: {getUserNameRoleMarketplaceAdmin}");
            });
            return this;
        }

        [AllureStep("VerifyBrokerUserNameAndRole")]
        public SidebarLandlord VerifyBrokerUserNameAndRole(string getUserNameActual, string getUserNameRoleActual)
        {
            WaitUntil.WaitSomeInterval(500);
            string getUserNameExpected = broker.FullUserNameBroker;
            string getUserNameRoleExpected = TestDataLandlord.USER_NAME_ROLE_BROKER;

            Assert.Multiple(() =>
            {
                Assert.AreEqual(getUserNameExpected, getUserNameActual, $"User Name not equal");
                Assert.AreEqual(getUserNameRoleExpected, getUserNameRoleActual, $"User Name Role not equal");

                Console.WriteLine($"First Last name EX: {getUserNameExpected} First Last name AC: {getUserNameActual}");
                Console.WriteLine($"Name Role EX: {getUserNameRoleExpected} Name Role AC: {getUserNameRoleActual}");
            });
            return this;
        }

        [AllureStep("VerifyBrokerUserNameAndRoleCreating")]
        public SidebarLandlord VerifyBrokerUserNameAndRoleCreating(string getUserNameRoleCompareBroker)
        {
            WaitUntil.WaitSomeInterval(500);
            string getUserNameExpected = broker.FullUserNameBroker;
            string getUserNameRoleExpected = TestDataLandlord.USER_NAME_ROLE_BROKER;

            Assert.Multiple(() =>
            {
                Assert.AreEqual(getUserNameRoleExpected, getUserNameRoleCompareBroker, $"User Name Role not equal");

                Console.WriteLine($"Name Role EX: {getUserNameRoleExpected} Name Role AC: {getUserNameRoleCompareBroker}");
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

                Console.WriteLine($"First Last name EX: {getUserNameExpected} First Last name AC: {getUserNameActual}");
                Console.WriteLine($"Name role EX: {getUserNameRoleExpected} Name role AC: {getUserNameRoleActual}");
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

                Console.WriteLine($"Name role EX: {getUserNameRoleExpected} Name role AC: {getUserNameRoleCompareAgent}");
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

                Console.WriteLine($"First Last name EX: {getUserNameExpected} AC: {getUserNameActual}");
                Console.WriteLine($"Name Role EX: {getUserNameRoleExpected} AC: {getUserNameRoleActual}");
            });

            return this;
        }

        [AllureStep("VerifyChangingLogoImageLandlord")]
        public SidebarLandlord VerifyChangingLogoImageLandlord()
        {
            WaitUntil.CustomElementIsVisible(MessageChangeImageLogoLandlordSuccess);
            Assert.IsTrue(Successfully.IsVisible(MessageChangeImageLogoLandlordSuccess));

            return this;
        }

        [AllureStep("VerifyChangingAvatarImageLandlord")]
        public SidebarLandlord VerifyChangingAvatarImageLandlord()
        {
            Assert.IsTrue(Successfully.IsVisible(MessageChangeImageAvatarUserSuccess));

            return this;
        }

        [AllureStep("VerifyRewmoveAvatarImageLandlord")]
        public SidebarLandlord VerifyRewmoveAvatarImageLandlord()
        {
            Assert.IsTrue(Successfully.IsVisible(MessageRemoveImageAvatarUserSuccess));

            return this;
        }
    }
}
