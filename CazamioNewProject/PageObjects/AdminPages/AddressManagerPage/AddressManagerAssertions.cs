using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.PageObjects.AdminPages.AddressManagerPage
{
    public partial class AddressManager
    {
        [AllureStep("VerifyTitleAddressManagerPg")]
        public AddressManager VerifyTitleAddressManagerPg()
        {
            Assert.IsTrue(TitlesCheck.IsVisible(TitleAddressManagerPg));

            return this;
        }
    }
}
