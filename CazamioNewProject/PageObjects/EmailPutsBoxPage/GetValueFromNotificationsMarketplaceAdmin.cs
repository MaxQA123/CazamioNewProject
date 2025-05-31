using NUnit.Allure.Attributes;
using System;
using System.Text.RegularExpressions;

namespace CazamioNewProject.PageObjects.EmailPutsBoxPage
{
    public partial class EmailPutsBox
    {
        [AllureStep("GetTexWeAreDelightedCreateMarketplaceaAdmin")]
        public string GetTexWeAreDelightedCreateMarketplaceaAdmin()
        {
            string fullText = ThrdRwBodyWeAreDelightedCreateMarketplaceaAdmin.Text;

            return fullText;
        }

        [AllureStep("GetTexToGetStartedCommon")]
        public string GetTexToGetStartedCommon()
        {
            string fullText = ToGetStartedCommon.Text;

            return fullText;
        }

        [AllureStep("GetOnlyTexCopyThePassword")]
        public string GetOnlyTexCopyThePassword()
        {
            try
            {
                string fullText = FfthRwBodyCopyThePasswordCreateMarketplaceaAdmin.Text;

                var match = Regex.Match(fullText, @"^(1\. Copy the password:)");

                if (match.Success)
                {
                    return match.Value.Trim();
                }

                throw new Exception("Не удалось извлечь текст '1. Copy the password:' из строки");
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при получении текста: {ex.Message}");
            }
        }

        [AllureStep("GetPasswordValueFromFfthRowTexCopyThePassword")]
        public string GetPasswordValueFromFfthRowTexCopyThePassword()
        {
            try
            {
                string fullText = FfthRwBodyCopyThePasswordCreateMarketplaceaAdmin.Text;

                var match = Regex.Match(fullText, @"1\. Copy the password:\s*(.+)$");

                if (match.Success && match.Groups.Count > 1)
                {
                    return match.Groups[1].Value.Trim();
                }

                throw new Exception("Не удалось извлечь значение пароля из строки");
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при получении значения пароля: {ex.Message}");
            }
        }

        [AllureStep("GetTexClickTheButtonGetStarted")]
        public string GetTexClickTheButtonGetStarted()
        {
            string fullText = SxthRwBodyClickTheButtonGetStartedCreateMarketplaceaAdmin.Text;

            return fullText;
        }

        [AllureStep("GetOnlyTexPasteThePassword")]
        public string GetOnlyTexPasteThePassword()
        {
            try
            {
                string fullText = SvnthRwBodyPasteThePasswordCreateMarketplaceaAdmin.Text;

                var match = Regex.Match(fullText, @"^(\d+\. Paste the password:)");

                if (match.Success)
                {
                    return match.Value.Trim();
                }

                throw new Exception("Не удалось извлечь текст '3. Paste the password:' из строки");
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при получении текста: {ex.Message}");
            }
        }

        [AllureStep("GetOnlyPasswordFromSvnRow")]
        public string GetOnlyPasswordFromSvnRow()
        {
            try
            {
                string fullText = SvnthRwBodyPasteThePasswordCreateMarketplaceaAdmin.Text;

                var match = Regex.Match(fullText, @"Paste the password:\s*(.+?)\s*in the ""Password"" field");

                if (match.Success && match.Groups.Count > 1)
                {
                    return match.Groups[1].Value.Trim();
                }

                throw new Exception("Не удалось извлечь значение пароля из строки");
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при получении пароля: {ex.Message}");
            }
        }

        [AllureStep("GetOnlyTexInThePasswordFieldForLogin")]
        public string GetOnlyTexInThePasswordFieldForLogin()
        {
            try
            {
                string fullText = SvnthRwBodyPasteThePasswordCreateMarketplaceaAdmin.Text;

                var match = Regex.Match(fullText, @"(in the ""Password"" field for login\.)$");

                if (match.Success)
                {
                    return match.Value.Trim();
                }

                throw new Exception("Не удалось извлечь текст 'in the \"Password\" field for login.' из строки");
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при получении текста: {ex.Message}");
            }
        }

        [AllureStep("GetOnlyTexPasteTheEmail")]
        public string GetOnlyTexPasteTheEmail()
        {
            try
            {
                string fullText = EightthRwBodyOnlyTextPasteTheEmailCreateMarketplaceaAdmin.Text;

                var match = Regex.Match(fullText, @"^(\d+\. Paste the email)");

                if (match.Success)
                {
                    return match.Value.Trim();
                }

                throw new Exception("Не удалось извлечь текст '4. Paste the email' из строки");
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при получении текста: {ex.Message}");
            }
        }

        [AllureStep("GetOnlyEmailAddressFromPasteTheEmail")]
        public string GetOnlyEmailAddressFromPasteTheEmail()
        {
            try
            {
                string fullText = EightthRwBodyOnlyTextPasteTheEmailCreateMarketplaceaAdmin.Text;

                var match = Regex.Match(fullText, @"Paste the email\s(.+?)\s*in the ""Email"" field");

                if (match.Success && match.Groups.Count > 1)
                {
                    return match.Groups[1].Value.Trim();
                }

                throw new Exception("Не удалось извлечь email из строки");
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при получении email: {ex.Message}");
            }
        }

        [AllureStep("GetOnlyTextInTheEmailFieldForLogin")]
        public string GetOnlyTextInTheEmailFieldForLogin()
        {
            try
            {
                string fullText = EightthRwBodyOnlyTextPasteTheEmailCreateMarketplaceaAdmin.Text;

                var match = Regex.Match(fullText, @"(in the ""Email"" field for login\.)$");

                if (match.Success)
                {
                    return match.Groups[0].Value.Trim();
                }

                throw new Exception("Не удалось извлечь текст 'in the \"Email\" field for login.'");
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при получении текста: {ex.Message}");
            }
        }

        [AllureStep("GetTextClickTheLetsGo")]
        public string GetTextClickTheLetsGo()
        {
            string fullText = NinethRwBodyClickTheLetsGoCreateMarketplaceaAdmin.Text;

            return fullText;
        }

        [AllureStep("GetTextPleaseContactOurSupportTeam")]
        public string GetTextPleaseContactOurSupportTeam()
        {
            string fullText = TenthRwBodyPleaseContactOurSupportTeamCreateMarketplaceaAdmin.Text;

            return fullText;
        }

        [AllureStep("GetTextYourAccountWasCreated")]
        public string GetTextYourAccountWasCreated()
        {
            string fullText = ElevnthRwBodyYourAccountWasCreatedCreateMarketplaceaAdmin.Text;

            return fullText;
        }
    }
}
