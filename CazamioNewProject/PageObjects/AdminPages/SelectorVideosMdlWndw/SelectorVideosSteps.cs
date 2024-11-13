using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using System.IO;

namespace CazamioNewProject.PageObjects.AdminPages.SelectorVideosMdlWndw
{
    public partial class SelectorVideosMdlWndw
    {
        [AllureStep("UploadFileEnterLinksYouTubeVimeo")]
        public SelectorVideosMdlWndw UploadFileEnterLinksYouTubeVimeo()
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

        [AllureStep("UploadFileVideo")]
        public SelectorVideosMdlWndw UploadFileVideo()
        {
            WaitUntil.CustomElementIsVisible(ButtonSelectFile);
            ButtonSelectFile.SendKeys(Path.GetFullPath(Path.Combine(Browser.RootPath() + UploadVideos.VIDEO_FIRST_APARTMENT)));
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonSave);
            WaitUntil.WaitSomeInterval(5000);

            return this;
        }
    }
}
