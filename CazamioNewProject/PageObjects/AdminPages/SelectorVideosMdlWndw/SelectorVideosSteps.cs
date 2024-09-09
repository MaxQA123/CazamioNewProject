using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using System.IO;

namespace CazamioNewProject.PageObjects.AdminPages.SelectorVideosMdlWndw
{
    public partial class SelectorVideosMdlWndw
    {
        [AllureStep("UplodFileEnterLinksYouTubeVimeo")]
        public SelectorVideosMdlWndw UplodFileEnterLinksYouTubeVimeo()
        {
            WaitUntil.CustomElementIsVisible(FieldInputYouTubeShareLink);
            InputGeneral.InputFunctionWithClear(FieldInputYouTubeShareLink, apartment.LinksForVideo.LinkYouTube);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputVimeoShareLink, apartment.LinksForVideo.LinkVimeo);
            ButtonSelectFile.SendKeys(Path.GetFullPath(Path.Combine(Browser.RootPath() + UploadVideos.VIDEO_FIRST_APARTMENT)));
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonSave);
            WaitUntil.WaitSomeInterval(5000);

            return this;
        }
    }
}
