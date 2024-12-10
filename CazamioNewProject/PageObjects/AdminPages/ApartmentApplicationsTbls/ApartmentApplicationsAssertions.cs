using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.PageObjects.AdminPages.ApartmentApplicationsTbls
{
    public partial class ApartmentApplicationsTbl
    {
        [AllureStep("VerifyFullDataByApplication")]
        public ApartmentApplicationsTbl VerifyFullDataByApplication(string getAddressBuildingViewActual, string apartmentAddressFromApp, string firstNameTenantMainApplicantFromUnit, string firstNameTenantMainApplicantFromApp, string lastNameTenantMainApplicantFromUnit, string lastNameTenantMainApplicantFromApp)
        {
            WaitUntil.WaitSomeInterval(100);
            //string getUserNameExpected = agentBroker.FullNameAgentBroker;
            //string getUserNameRoleExpected = TestDataLandlord.USER_NAME_ROLE_AGENT;

            Assert.Multiple(() =>
            {
                Assert.AreEqual(getAddressBuildingViewActual, apartmentAddressFromApp);
                Assert.AreEqual(firstNameTenantMainApplicantFromUnit, firstNameTenantMainApplicantFromApp);
                Assert.AreEqual(lastNameTenantMainApplicantFromUnit, lastNameTenantMainApplicantFromApp);
            });

            return this;
        }
    }
}
