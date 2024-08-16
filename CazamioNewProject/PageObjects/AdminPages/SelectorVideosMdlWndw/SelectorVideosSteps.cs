using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.PageObjects.AdminPages.SelectorVideosMdlWndw
{
    public partial class SelectorVideosMdlWndw
    {
        [AllureStep("UplodFileEnterLinksYouTubeVimeo")]
        public SelectorVideosMdlWndw UplodFileEnterLinksYouTubeVimeo()
        {
            WaitUntil.CustomElementIsVisible(FieldInputYouTubeShareLink);
            InputGeneral.InputFunctionWithClear(FieldInputYouTubeShareLink, apartment.LinksToVideos.LinkYouTube);

            return this;
        }
    }
}
