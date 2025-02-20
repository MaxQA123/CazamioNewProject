using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.ApartmentApplicationsTbls
{
    public partial class ApartmentApplicationsTbl
    {
        [AllureStep("VerifyFullDataByApplicationTenantMain")]
        public ApartmentApplicationsTbl VerifyFullDataByApplicationTenantMain(string getAddressBuildingViewActual, string apartmentAddressFromApp, string firstNameTenantConstant, string firstNameTenantMainApplicantFromApp, string lastNameTenantConstant, string lastNameTenantMainApplicantFromApp, string leasePriceFromUnit, string leasePriceFromApplication, string agentFromApplication, string agentLulaAgentQA, string statusFromApplication, string statusDraft, string dateCurrentCreatedFromApplication, string dateCurrentCreatedExpectedResult)
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(getAddressBuildingViewActual, apartmentAddressFromApp);
                Assert.AreEqual(firstNameTenantConstant, firstNameTenantMainApplicantFromApp);
                Assert.AreEqual(lastNameTenantConstant, lastNameTenantMainApplicantFromApp);
                Assert.AreEqual(leasePriceFromUnit, leasePriceFromApplication);
                Assert.AreEqual(agentFromApplication, agentLulaAgentQA);
                Assert.AreEqual(statusFromApplication, statusDraft);
                Assert.AreEqual(dateCurrentCreatedFromApplication, dateCurrentCreatedExpectedResult);
                Assert.IsTrue(ButtonName.IsVisible(CloseNameBtnOfClmnStatusFrstRw));
            });

            return this;
        }

        [AllureStep("VerifyFullDataByApplicationCreatedTenantMain")]
        public ApartmentApplicationsTbl VerifyFullDataByApplicationCreatedTenantMain(string getAddressBuildingViewActual, string apartmentAddressFromApp, string fullNameTenantEx, string fullNameTenantMainApplicantFromAppArAc, string leasePriceFromUnit, string leasePriceFromApplication, string agentFromApplication, string agentLulaAgentQA, string statusFromApplication, string statusDraft, string dateCurrentCreatedFromApplication, string dateCurrentCreatedExpectedResult)
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(getAddressBuildingViewActual, apartmentAddressFromApp);
                Assert.AreEqual(fullNameTenantEx, fullNameTenantMainApplicantFromAppArAc);
                Assert.AreEqual(leasePriceFromUnit, leasePriceFromApplication);
                Assert.AreEqual(agentFromApplication, agentLulaAgentQA);
                Assert.AreEqual(statusFromApplication, statusDraft);
                Assert.AreEqual(dateCurrentCreatedFromApplication, dateCurrentCreatedExpectedResult);
                Assert.IsTrue(ButtonName.IsVisible(CloseNameBtnOfClmnStatusFrstRw));
            });

            return this;
        }

        [AllureStep("VerifyFullDataByApplicationTenantsMainOccupant")]
        public ApartmentApplicationsTbl VerifyFullDataByApplicationTenantsMainOccupant(string getAddressBuildingViewActual, string apartmentAddressFromApp, string firstNameTenantConstant, string firstNameTenantMainApplicantFromApp, string lastNameTenantConstant, string firstLastNameFromApp, string tenantOccupantMySpace, string lastNameTenantMainApplicantFromApp, string leasePriceFromUnit, string leasePriceFromApplication, string agentFromApplication, string agentLulaAgentQA, string statusFromApplication, string statusDraft, string dateCurrentCreatedFromApplication, string dateCurrentCreatedExpectedResult)
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(getAddressBuildingViewActual, apartmentAddressFromApp);
                Assert.AreEqual(firstNameTenantConstant, firstNameTenantMainApplicantFromApp);
                Assert.AreEqual(lastNameTenantConstant, lastNameTenantMainApplicantFromApp);
                Assert.AreEqual(firstLastNameFromApp, tenantOccupantMySpace);
                Assert.AreEqual(leasePriceFromUnit, leasePriceFromApplication);
                Assert.AreEqual(agentFromApplication, agentLulaAgentQA);
                Assert.AreEqual(statusFromApplication, statusDraft);
                Assert.AreEqual(dateCurrentCreatedFromApplication, dateCurrentCreatedExpectedResult);
                Assert.IsTrue(ButtonName.IsVisible(CloseNameBtnOfClmnStatusFrstRw));
            });

            return this;
        }
    }
}
