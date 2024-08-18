using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.IO;
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
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputVimeoShareLink, apartment.LinksToVideos.LinkVimeo);
            ButtonSelectFile.SendKeys(Path.GetFullPath(Path.Combine(Browser.RootPath() + UploadVideos.VIDEO_FIRST_APARTMENT)));
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonSave);
            WaitUntil.WaitSomeInterval(5000);

            return this;
        }
    }
}
