using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfApplicationsApplicationsTbls
{
    public partial class ListOfApplicationsApplicationsTbl
    {
        [AllureStep("VerifyFullDataByApplicationTenantsMainOccupant")]
        public ListOfApplicationsApplicationsTbl VerifyFullDataByApplicationTenantsMainOccupant
            (string fullNameMainTenantEx, string fullNameTenantMainApplicantFromAppAr,
             string fullNameOccupantEx, string fullNameTenantOccupantFromAppAr,
             string leasePriceEx, string leasePriceFromApp,
             string dateCurrentEx, string dateCreatedFromApp,
             string notAssignetLabelEx, string agentFromApp,
             string draftEx, string statusFromApp,
             string closeBtnEx, string btnNameFromApp)
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(fullNameMainTenantEx, fullNameTenantMainApplicantFromAppAr);
                Assert.AreEqual(fullNameOccupantEx, fullNameTenantOccupantFromAppAr);
                Assert.AreEqual(leasePriceEx, leasePriceFromApp);
                Assert.AreEqual(dateCurrentEx, dateCreatedFromApp);
                Assert.AreEqual(notAssignetLabelEx, agentFromApp);
                Assert.AreEqual(draftEx, statusFromApp);
                Assert.AreEqual(closeBtnEx, btnNameFromApp);
            });

            return this;
        }

        [AllureStep("VerifyDataWitoutAgentByApplicationTenantMain")]
        public ListOfApplicationsApplicationsTbl VerifyDataWitoutAgentByApplicationTenantMain
            (string fullNameMainTenantEx, string fullNameTenantMainApplicantFromAppAr,
             string leasePriceEx, string leasePriceFromApp,
             string dateCurrentEx, string dateCreatedFromApp,
             string draftEx, string statusFromApp,
             string closeBtnEx, string btnNameFromApp)
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(fullNameMainTenantEx, fullNameTenantMainApplicantFromAppAr);
                Assert.AreEqual(leasePriceEx, leasePriceFromApp);
                Assert.AreEqual(dateCurrentEx, dateCreatedFromApp);
                Assert.AreEqual(draftEx, statusFromApp);
                Assert.AreEqual(closeBtnEx, btnNameFromApp);
            });

            return this;
        }
    }
}
