using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.PageObjects.AdminPages.MarketplacePage
{
    public partial class Marketplace
    {
        [AllureStep("VerifyTitleMarketplacePg")]
        public Marketplace VerifyTitleMarketplacePg()
        {
            Assert.IsTrue(Successfully.IsVisible(TitleMarketplacePage));

            return this;
        }
    }
}
