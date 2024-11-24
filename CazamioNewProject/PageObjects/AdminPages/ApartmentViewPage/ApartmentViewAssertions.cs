using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.PageObjects.AdminPages.ApartmentViewPage
{
    public partial class ApartmentView
    {
        [AllureStep("VerifyTitleAddApartmentsPage")]
        public ApartmentView VerifyTitleApartmentViewPage()
        {
            WaitUntil.CustomElementIsVisible(LoaderHidden);
            WaitUntil.CustomElementIsVisible(TitleApartmentViewPage);
            Assert.IsTrue(Successfully.IsVisible(TitleApartmentViewPage));
            KeyBoardActions.ScrollToUp();

            return this;
        }
    }
}
