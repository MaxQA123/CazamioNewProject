using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.ApartmentApplicationsTbls
{
    public partial class ApartmentApplicationsTbl
    {
        [AllureStep("VerifyFullDataByApplication")]
        public ApartmentApplicationsTbl VerifyFullDataByApplication(string getAddressBuildingViewActual, string apartmentAddressFromApp, string firstNameTenantConstant, string firstNameTenantMainApplicantFromApp, string lastNameTenantConstant, string lastNameTenantMainApplicantFromApp, string leasePriceFromUnit, string leasePriceFromApplication, string agentFromApplication, string AgentNotAssigned, string statusFromApplication, string statusDraft, string dateCurrentCreatedFromApplication, string dateCurrentCreatedExpectedResult)
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(getAddressBuildingViewActual, apartmentAddressFromApp);
                Assert.AreEqual(firstNameTenantConstant, firstNameTenantMainApplicantFromApp);
                Assert.AreEqual(lastNameTenantConstant, lastNameTenantMainApplicantFromApp);
                Assert.AreEqual(leasePriceFromUnit, leasePriceFromApplication);
                Assert.AreEqual(agentFromApplication, AgentNotAssigned);
                Assert.AreEqual(statusFromApplication, statusDraft);
                Assert.AreEqual(dateCurrentCreatedFromApplication, dateCurrentCreatedExpectedResult);
                Assert.IsTrue(Successfully.IsVisible(CloseNameBtnOfClmnStatusFrstRw));
            });

            return this;
        }
    }
}
