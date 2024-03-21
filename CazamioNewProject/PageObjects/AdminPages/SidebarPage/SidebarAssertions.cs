﻿using CazamioNewProject.GuiHelpers;
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
        //[AllureStep("VerifyBrokerUserName")]
        //public Sidebar VerifyBrokerUserName(string getUserNameActual, string getUserNameRoleActual)
        //{
        //    WaitUntil.WaitSomeInterval(1500);
        //    string getUserNameExpected = broker.FullUserNameBroker;
        //    string getUserNameRoleExpected = TestDataForWebSiteAdmin.USER_NAME_ROLE_BROKER;

        //    Assert.Multiple(() =>
        //    {
        //        Assert.AreEqual(getUserNameExpected, getUserNameActual);
        //        Assert.AreEqual(getUserNameRoleExpected, getUserNameRoleActual);

        //        Console.WriteLine($"First Last name EX: {getUserNameExpected} First Last name AC: {getUserNameActual}");
        //        Console.WriteLine($"Name Role EX: {getUserNameRoleExpected} Name Role AC: {getUserNameRoleActual}");
        //    });
        //    return this;
        //}

        [AllureStep("VerifyMarketplaceAdminUserName")]
        public Sidebar VerifyMarketplaceAdminUserName(string getUserNameActual, string getUserNameRoleActual)
        {
            WaitUntil.WaitSomeInterval(1500);
            string getUserNameExpected = marketplaceAdmin.FullNameMarketplaceAdmin;
            string getUserNameRoleExpected = TestDataForWebSiteAdmin.USER_NAME_ROLE_MARKETPLACE_ADMIN;

            Assert.Multiple(() =>
            {
                Assert.AreEqual(getUserNameExpected, getUserNameActual);
                Assert.AreEqual(getUserNameRoleExpected, getUserNameRoleActual);

                Console.WriteLine($"First Last name EX: {getUserNameExpected} First Last name AC: {getUserNameActual}");
                Console.WriteLine($"Name Role EX: {getUserNameRoleExpected} Name Role AC: {getUserNameRoleActual}");
            });
            return this;
        }

        //[AllureStep("VerifyMarketplaceAdminUserNameRole")]
        //public Sidebar VerifyMarketplaceAdminUserNameRole(string getUserNameRoleActual)
        //{
        //    WaitUntil.WaitSomeInterval(1500);

        //    string getUserNameRoleExpected = TestDataForWebSiteAdmin.USER_NAME_ROLE_MARKETPLACE_ADMIN;

        //    Assert.AreEqual(getUserNameRoleExpected, getUserNameRoleActual);

        //    Console.WriteLine($"Name Role EX: {getUserNameRoleExpected} Name Role AC: {getUserNameRoleActual}");

        //    return this;
        //}

        //[AllureStep("VerifyOnlyBrokerUserNameRole")]
        //public Sidebar VerifyOnlyBrokerUserNameRole(string getUserNameRoleActual)
        //{
        //    WaitUntil.WaitSomeInterval(1500);
        //    string getUserNameRoleExpected = TestDataForWebSiteAdmin.USER_NAME_ROLE_BROKER;


        //    Assert.AreEqual(getUserNameRoleExpected, getUserNameRoleActual);

        //    Console.WriteLine($"Name Role EX: {getUserNameRoleExpected} Name Role AC: {getUserNameRoleActual}");

        //    return this;
        //}

        //[AllureStep("VerifyOnlyAgentUserNameRole")]
        //public Sidebar VerifyOnlyAgentUserNameRole(string getUserNameRoleActual)
        //{
        //    WaitUntil.WaitSomeInterval(500);
        //    string getUserNameRoleExpected = TestDataForWebSiteAdmin.USER_NAME_ROLE_AGENT;

        //    Assert.AreEqual(getUserNameRoleExpected, getUserNameRoleActual);

        //    Console.WriteLine($"Name Role EX: {getUserNameRoleExpected} Name Role AC: {getUserNameRoleActual}");

        //    return this;
        //}

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

        //[AllureStep("VerifySuperAdminUserName")]
        //public Sidebar VerifySuperAdminUserName(string getUserNameActual, string getUserNameRoleActual)
        //{
        //    WaitUntil.WaitSomeInterval(1500);
        //    string getUserNameExpected = TestDataForWebSiteAdmin.USER_NAME_SUPER_ADMIN;
        //    string getUserNameRoleExpected = TestDataForWebSiteAdmin.USER_NAME_ROLE_SUPER_ADMIN;

        //    Assert.Multiple(() =>
        //    {
        //        Assert.AreEqual(getUserNameExpected, getUserNameActual);
        //        Assert.AreEqual(getUserNameRoleExpected, getUserNameRoleActual);

        //        Console.WriteLine($"First Last name EX: {getUserNameExpected} First Last name AC: {getUserNameActual}");
        //        Console.WriteLine($"Name role EX: {getUserNameRoleExpected} Name role AC: {getUserNameRoleActual}");
        //    });

        //    return this;
        //}

        //[AllureStep("VerifyAgentUserName")]
        //public Sidebar VerifyAgentUserName(string getUserNameActual, string getUserNameRoleActual)
        //{
        //    WaitUntil.WaitSomeInterval(3000);
        //    string getUserNameExpected = agent.FullNameAgent;
        //    string getUserNameRoleExpected = TestDataForWebSiteAdmin.USER_NAME_ROLE_AGENT;

        //    Assert.Multiple(() =>
        //    {
        //        Assert.AreEqual(getUserNameExpected, getUserNameActual);
        //        Assert.AreEqual(getUserNameRoleExpected, getUserNameRoleActual);

        //        Console.WriteLine($"First Last name EX: {getUserNameExpected} First Last name AC: {getUserNameActual}");
        //        Console.WriteLine($"Name role EX: {getUserNameRoleExpected} Name role AC: {getUserNameRoleActual}");
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
