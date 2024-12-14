﻿using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.ApartmentApplicationsTbls
{
    public partial class ApartmentApplicationsTbl
    {
        [AllureStep("VerifyFullDataByApplication")]
        public ApartmentApplicationsTbl VerifyFullDataByApplication(string getAddressBuildingViewActual, string apartmentAddressFromApp, string firstNameTenantMainApplicantFromUnit, string firstNameTenantMainApplicantFromApp, string lastNameTenantMainApplicantFromUnit, string lastNameTenantMainApplicantFromApp, string leasePriceFromUnit, string leasePriceFromApplication, string agentFromApplication, string AgentNotAssigned, string statusFromApplication, string statusDraft)
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(getAddressBuildingViewActual, apartmentAddressFromApp);
                Assert.AreEqual(firstNameTenantMainApplicantFromUnit, firstNameTenantMainApplicantFromApp);
                Assert.AreEqual(lastNameTenantMainApplicantFromUnit, lastNameTenantMainApplicantFromApp);
                Assert.AreEqual(leasePriceFromUnit, leasePriceFromApplication);
                Assert.AreEqual(agentFromApplication, AgentNotAssigned);
                Assert.AreEqual(statusFromApplication, statusDraft);
                Assert.IsTrue(Successfully.IsVisible(CloseNameBtnOfClmnStatusFrstRw));
            });

            return this;
        }
    }
}