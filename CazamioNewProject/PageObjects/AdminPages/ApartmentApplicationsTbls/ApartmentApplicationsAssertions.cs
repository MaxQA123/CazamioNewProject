using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.ApartmentApplicationsTbls
{
    public partial class ApartmentApplicationsTbl
    {
        [AllureStep("VerifyFullDataByApplicationTenantMain")]
        public ApartmentApplicationsTbl VerifyFullDataByApplicationTenantMain
            (string getAddressBuildingView, string apartmentAddressFromApp,
             string tenantCreatorMySpaceFirstNameTenantEx, string firstNameTenantMainApplicantFromApp,
             string tenantCreatorMySpaceLastNameTenantEx, string lastNameTenantMainApplicantFromApp,
             string leasePriceFromUnit, string leasePriceFromApplication,
             string agentEx, string agentFromApplication,
             string statusDraftEx, string statusFromApplication,
             string DateCurrentEx, string dateCreatedFromApplication)
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(getAddressBuildingView, apartmentAddressFromApp);
                Assert.AreEqual(tenantCreatorMySpaceFirstNameTenantEx, firstNameTenantMainApplicantFromApp);
                Assert.AreEqual(tenantCreatorMySpaceLastNameTenantEx, lastNameTenantMainApplicantFromApp);
                Assert.AreEqual(leasePriceFromUnit, leasePriceFromApplication);
                Assert.AreEqual(agentEx, agentFromApplication);
                Assert.AreEqual(statusDraftEx, statusFromApplication);
                Assert.AreEqual(DateCurrentEx, dateCreatedFromApplication);
                Assert.IsTrue(ButtonName.IsVisible(CloseNameBtnOfClmnStatusFrstRw));
            });

            return this;
        }

        [AllureStep("VerifyFullDataByApplicationCreatedTenantMain")]
        public ApartmentApplicationsTbl VerifyFullDataByApplicationCreatedTenantMain
            (string getAddressBuildingViewActual, string apartmentAddressFromApp, 
            string fullNameTenantEx, string fullNameTenantMainApplicantFromAppArAc, 
            string leasePriceFromUnit, string leasePriceFromApplication, 
            string agentFromApplication, string agentLulaAgentQA, 
            string statusFromApplication, string statusDraft, 
            string dateCurrentCreatedFromApplication, string dateCurrentCreatedExpectedResult)
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

        [AllureStep("VerifyDataWitoutAgentByApplicationCreatedTenantMain")]
        public ApartmentApplicationsTbl VerifyDataWitoutAgentByApplicationCreatedTenantMain
            (string getAddressBuildingViewActual, string apartmentAddressFromAppAr,
            string fullNameTenantEx, string fullNameTenantMainApplicantFromAppArAc,
            string leasePriceFromUnit, string leasePriceFromApplication,
            string dateCurrentCreatedFromApplication, string dateCurrentCreatedExpectedResult,
            string statusFromApplication, string statusDraft)
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(getAddressBuildingViewActual, apartmentAddressFromAppAr);
                Assert.AreEqual(fullNameTenantEx, fullNameTenantMainApplicantFromAppArAc);
                Assert.AreEqual(leasePriceFromUnit, leasePriceFromApplication);
                Assert.AreEqual(dateCurrentCreatedFromApplication, dateCurrentCreatedExpectedResult);
                Assert.AreEqual(statusFromApplication, statusDraft);
                //Assert.IsTrue(ButtonName.IsVisible(CloseNameBtnOfClmnStatusFrstRw));
            });

            return this;
        }

        [AllureStep("VerifyDataWitoutAgentByApplicationCreatedTenantMainOccupant")]
        public ApartmentApplicationsTbl VerifyDataWitoutAgentByApplicationCreatedTenantMainOccupant
            (string getShortBuildingAddressEr, string getAddressBuildingViewAr,
            string fullNameTenantMainEx, string fullNameTenantMainApplicantFromAppArAc,
            string fullNameOccupantEx, string fullNameOccupantFromAppAr,
            string leasePriceFromUnit, string leasePriceFromApplication,
            string dateCurrentCreatedFromApplication, string dateCurrentCreatedExpectedResult,
            string statusFromApplication, string statusDraft,
            string closeBtnNameEr, string closeBtnNameFromApp)
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(getShortBuildingAddressEr, getAddressBuildingViewAr);
                Assert.AreEqual(fullNameTenantMainEx, fullNameTenantMainApplicantFromAppArAc);
                Assert.AreEqual(fullNameOccupantEx, fullNameOccupantFromAppAr);
                Assert.AreEqual(leasePriceFromUnit, leasePriceFromApplication);
                Assert.AreEqual(dateCurrentCreatedFromApplication, dateCurrentCreatedExpectedResult);
                Assert.AreEqual(statusFromApplication, statusDraft);
                Assert.AreEqual(closeBtnNameEr, closeBtnNameFromApp);
            });

            return this;
        }

        [AllureStep("VerifyFullDataByApplicationTenantsMainOccupant")]
        public ApartmentApplicationsTbl VerifyFullDataByApplicationTenantsMainOccupant
            (string getAddressBuildingView, string apartmentAddressFromApp,
             string tenantCreatorMySpaceFirstNameEx, string firstNameTenantMainApplicantFromApp,
             string tenantCreatorMySpaceLastNameTenantEx, string firstLastNameFromApp,
             string tenantOccupantMySpaceFirstLastNameEx, string firstLastNameOccupantFromApp,
             string leasePriceEx, string leasePriceFromApplication,
             string agentLabelEx, string agentFromApplication,
             string statusDraftEx, string statusFromApplication,
             string dateCurrentEx, string dateCreatedFromApplication)
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(getAddressBuildingView, apartmentAddressFromApp);
                Assert.AreEqual(tenantCreatorMySpaceFirstNameEx, firstNameTenantMainApplicantFromApp);
                Assert.AreEqual(tenantCreatorMySpaceLastNameTenantEx, firstLastNameFromApp);
                Assert.AreEqual(tenantOccupantMySpaceFirstLastNameEx, firstLastNameOccupantFromApp);
                Assert.AreEqual(leasePriceEx, leasePriceFromApplication);
                Assert.AreEqual(agentLabelEx, agentFromApplication);
                Assert.AreEqual(statusDraftEx, statusFromApplication);
                Assert.AreEqual(dateCurrentEx, dateCreatedFromApplication);
                Assert.IsTrue(ButtonName.IsVisible(CloseNameBtnOfClmnStatusFrstRw));
            });

            return this;
        }
    }
}
