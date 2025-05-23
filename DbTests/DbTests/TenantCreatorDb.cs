using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using System;
using CazamioNewProject.DbHelpers.AspNetUsersTable;
using CazamioNewProject.DbHelpers.BuildingsTable;
using CazamioNewProject.DbHelpers.ApartmentsTable;

namespace DbTests
{
    [TestFixture]
    [AllureNUnit]

    public class TenantCreatorDb : DbBase
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingDBAgent")]

        public void DispalyingIdAgentFromAspNetUsers()
        {
            int marketplaceId = 15;
            string email = "tenantswife@gmail.com";

            var IdAgent = AspNetUsersDbRequests.AspNetUsers.GetMarketplaceIdByEmailAndMarketplaceId(email, marketplaceId).MarketplaceId;
            Console.WriteLine($"{IdAgent} :Id for agent from table AspNetUsers");
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("GetAgentId")]

        public void GetAgentId()
        {
            var agentId = AspNetUsersDbRequests.AspNetUsers.GetAgentIdByEmailAndMarketplaceId();
            Console.WriteLine($"{agentId.Id}");
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("GetLastApartmentId")]

        public void GetLastApartmentId()
        {
            var apartmentId = ApartmentsDbRequests.ApartmentsDbTable.GetLastApartmentId();
            Console.WriteLine($"{apartmentId.Id}");
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("GetLastApartmentApplicationtId")]

        public void GetLastApartmentApplicationtId()
        {
            var apartmentApplicationId = ApartmentApplicationsDbRequests.ApartmentApplicationsDbTable.GetLastApartmentApplicationId();
            Console.WriteLine($"{apartmentApplicationId.Id}");
        }
    }
}