using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using NUnit.Allure.Attributes;
using System;
using System.Text.RegularExpressions;

namespace CazamioNewProject.PageObjects.AdminPages.CreateANewMarketplaceAdminMdlWndw
{
    public partial class CreateANewMarketplaceAdminMdlWindow
    {
        MarketplaceAdmin marketplaceAdmin = MarketplaceAdmin.Generate();
        BasicDataForProject basicDataForProject = BasicDataForProject.Generate();

        [AllureStep("ClickButtonCreate")]
        public CreateANewMarketplaceAdminMdlWindow ClickButtonCreate()
        {
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonCreate);

            return this;
        }

        [AllureStep("GetSymbolsBeforeDogFromFieldInputEmail")]
        public string GetSymbolsBeforeDogFromFieldInputEmail()
        {
            try
            {
                WaitUntil.WaitSomeInterval(500);
                string fullEmail = FieldInputEmail.GetAttribute("value");

                if (string.IsNullOrEmpty(fullEmail))
                {
                    throw new Exception("Email поле пустое");
                }

                Match match = Regex.Match(fullEmail, @"^([^@]+)");

                if (match.Success)
                {
                    return match.Groups[1].Value;
                }

                throw new Exception("Не удалось извлечь часть email до символа @");
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при получении части email: {ex.Message}");
            }
        }

        [AllureStep("CopyFullEmailFromFieldInputEmail")]
        public string CopyFullEmailFromFieldInputEmail()
        {
            WaitUntil.WaitSomeInterval(500);
            string copyFullEmail = FieldInputEmail.GetAttribute("value");

            return copyFullEmail;
        }

        [AllureStep("GetEmailFromFieldInputEmail")]
        public string GetEmailFromFieldInputEmail()
        {
            WaitUntil.WaitSomeInterval(100);
            string getUserName = FieldInputEmail.GetAttribute("value");
            string getUserNameActual = getUserName.ToString();

            return getUserNameActual;
        }
    }
}
