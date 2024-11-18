using OpenQA.Selenium;
using System.IO;
using System;

namespace CazamioNewProject.GuiHelpers
{
    public class ScreenShot
    {
        public static string MakeScreenShot()
        {
            ITakesScreenshot ssdriver = Browser._Driver as ITakesScreenshot;
            Screenshot screenshot = ssdriver.GetScreenshot();
            string timestampPath = DateTime.Now.ToString("yyyy-MM-dd");
            string timestampName = DateTime.UtcNow.ToString("dd-MMMM-yyyy' 'HH-mm-ss");
            string path = Browser.RootPath() + "ErrorImages\\" + timestampPath + "\\";
            string name = path + "Exception-" + timestampName + ".jpeg";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            screenshot.SaveAsFile(name, ScreenshotImageFormat.Jpeg);
            WaitUntil.WaitSomeInterval(2000);
            return name;
        }
    }
}

