using Allure.Commons;
using CazamioNewProject.PageObjects;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsEmailsLandlord
{
    [TestFixture]
    [AllureNUnit]

    public class EmailsLandlordTests : EmailsLandlordBase
    {
        //Amount order 8 next must be 9
        [Test]
        [Order(1)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("EmailsNotificationsLandlordsMySpace")]
        [AllureSubSuite("EmailWhenCreatingMarketplaceadmin")]

        public void EmailWhenCreatingMarketplaceadmin()
        {
            #region Test data



            #endregion

            #region Preconditions API



            #endregion

            #region Preconditions GUI



            #endregion


            #region Test

            Pages.LogInLandlord
                .LogInAsMarketplaceAdminMySpace();

            #endregion
        }
    }
}
