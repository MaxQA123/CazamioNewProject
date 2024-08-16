using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.PageObjects.AdminPages.SelectorVideosMdlWndw
{
    public partial class SelectorVideosMdlWndw
    {
        [FindsBy(How = How.XPath, Using = "//app-select-uploading-video//div[@class = 'video-type']//div[@class = 'input-field']//input")]
        public IWebElement FieldInputYouTubeShareLink;

        [FindsBy(How = How.XPath, Using = "")]
        public IWebElement FieldInputVimeoShareLink;

        [FindsBy(How = How.XPath, Using = "")]
        public IWebElement FieldInputDailymotionShareLink;

        [FindsBy(How = How.XPath, Using = "")]
        public IWebElement ButtonSelectFile;

        [FindsBy(How = How.XPath, Using = "")]
        public IWebElement ButtonSave;
    }
}
