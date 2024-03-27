﻿using Allure.Commons;
using CazamioNewProject.GuiHelpers;
using CazamioNewProject.PageObjects;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace SuperAdminGui
{
    [TestFixture]
    [AllureNUnit]

    public class TestsBaseGui : SuperAdminBase
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("SuperAdmin")]
        [AllureSubSuite("LogIn")]

        public void LogIn()
        {
            Pages.LogInLandlord
                .EnterEmailPasswordAsSuperAdmin()
                .ClickIconShow()
                .ClickButtonLetsGo();

            string getUserNameCompare = Pages.Sidebar.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.Sidebar.GetUserNameRoleFromSideBar();

            Pages.Sidebar
                .VerifySuperAdminUserNameAndRole(getUserNameCompare, getUserNameRoleCompare);

            WaitUntil.WaitSomeInterval(2000);
        }
    }
}
