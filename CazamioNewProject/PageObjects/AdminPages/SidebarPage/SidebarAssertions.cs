using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.PageObjects.AdminPages.SidebarPage
{
    public partial class Sidebar
    {
        [AllureStep("VerifySuperAdminUserNameAndRole")]
        public Sidebar VerifySuperAdminUserNameAndRole(string getUserNameActual, string getUserNameRoleActual)
        {
            WaitUntil.WaitSomeInterval(100);
            string getUserNameExpected = superAdmin.FullNameSuperAdmin;
            string getUserNameRoleExpected = TestDataLandlord.USER_NAME_ROLE_SUPER_ADMIN;

            Assert.Multiple(() =>
            {
                Assert.AreEqual(getUserNameExpected, getUserNameActual);
                Assert.AreEqual(getUserNameRoleExpected, getUserNameRoleActual);

                Console.WriteLine($"First Last name EX: {getUserNameExpected} First Last name AC: {getUserNameActual}");
                Console.WriteLine($"Name role EX: {getUserNameRoleExpected} Name role AC: {getUserNameRoleActual}");
            });

            return this;
        }

        [AllureStep("VerifyMarketplaceAdminUserNameAndRole")]
        public Sidebar VerifyMarketplaceAdminUserNameAndRole(string getUserNameActual, string getUserNameRoleActual)
        {
            WaitUntil.WaitSomeInterval(100);
            string getUserNameExpected = marketplaceAdmin.FullNameMarketplaceAdmin;
            string getUserNameRoleExpected = TestDataLandlord.USER_NAME_ROLE_MARKETPLACE_ADMIN;

            Assert.Multiple(() =>
            {
                Assert.AreEqual(getUserNameExpected, getUserNameActual);
                Assert.AreEqual(getUserNameRoleExpected, getUserNameRoleActual);

                Console.WriteLine($"First Last name EX: {getUserNameExpected} First Last name AC: {getUserNameActual}");
                Console.WriteLine($"Name Role EX: {getUserNameRoleExpected} Name Role AC: {getUserNameRoleActual}");
            });
            return this;
        }

        [AllureStep("VerifyBrokerUserNameAndRole")]
        public Sidebar VerifyBrokerUserNameAndRole(string getUserNameActual, string getUserNameRoleActual)
        {
            WaitUntil.WaitSomeInterval(100);
            string getUserNameExpected = broker.FullUserNameBroker;
            string getUserNameRoleExpected = TestDataLandlord.USER_NAME_ROLE_BROKER;

            Assert.Multiple(() =>
            {
                Assert.AreEqual(getUserNameExpected, getUserNameActual);
                Assert.AreEqual(getUserNameRoleExpected, getUserNameRoleActual);

                Console.WriteLine($"First Last name EX: {getUserNameExpected} First Last name AC: {getUserNameActual}");
                Console.WriteLine($"Name Role EX: {getUserNameRoleExpected} Name Role AC: {getUserNameRoleActual}");
            });
            return this;
        }

        [AllureStep("VerifyAgentUserNameAndRole")]
        public Sidebar VerifyAgentUserNameAndRole(string getUserNameActual, string getUserNameRoleActual)
        {
            WaitUntil.WaitSomeInterval(3000);
            string getUserNameExpected = agent.FullNameAgent;
            string getUserNameRoleExpected = TestDataLandlord.USER_NAME_ROLE_AGENT;

            Assert.Multiple(() =>
            {
                Assert.AreEqual(getUserNameExpected, getUserNameActual);
                Assert.AreEqual(getUserNameRoleExpected, getUserNameRoleActual);

                Console.WriteLine($"First Last name EX: {getUserNameExpected} First Last name AC: {getUserNameActual}");
                Console.WriteLine($"Name role EX: {getUserNameRoleExpected} Name role AC: {getUserNameRoleActual}");
            });

            return this;
        }

        //[AllureStep("VerifyAgentBrokerUserNameRole")]
        //public Sidebar VerifyAgentBrokerUserNameRole(string getUserNameActual, string getUserNameRoleActual)
        //{
        //    WaitUntil.WaitSomeInterval(500);
        //    string getUserNameExpected = agentBroker.FullNameAgentBroker;
        //    string getUserNameRoleExpected = TestDataForWebSiteAdmin.USER_NAME_ROLE_AGENT;

        //    Assert.Multiple(() =>
        //    {
        //        Assert.AreEqual(getUserNameExpected, getUserNameActual);
        //        Assert.AreEqual(getUserNameRoleExpected, getUserNameRoleActual);

        //        Console.WriteLine($"First Last name EX: {getUserNameExpected} AC: {getUserNameActual}");
        //        Console.WriteLine($"Name Role EX: {getUserNameRoleExpected} AC: {getUserNameRoleActual}");
        //    });

        //    return this;
        //}

        [AllureStep("VerifyChangingLogoImageLandlord")]
        public Sidebar VerifyChangingLogoImageLandlord()
        {
            WaitUntil.CustomElementIsVisible(MessageChangeImageLogoLandlordSuccess);
            Assert.IsTrue(Successfully.IsVisible(MessageChangeImageLogoLandlordSuccess));

            return this;
        }

        [AllureStep("VerifyChangingAvatarImageLandlord")]
        public Sidebar VerifyChangingAvatarImageLandlord()
        {
            Assert.IsTrue(Successfully.IsVisible(MessageChangeImageAvatarUserSuccess));

            return this;
        }

        [AllureStep("VerifyRewmoveAvatarImageLandlord")]
        public Sidebar VerifyRewmoveAvatarImageLandlord()
        {
            Assert.IsTrue(Successfully.IsVisible(MessageRemoveImageAvatarUserSuccess));

            return this;
        }
    }
}
