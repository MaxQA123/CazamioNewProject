using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfOwnersPage
{
    public partial class ListOfOwners
    {
        [AllureStep("VerifyTitleListOfOwnersPg")]
        public ListOfOwners VerifyTitleListOfOwnersPg()
        {
            Assert.IsTrue(TitlesCheck.IsVisible(TitleListOfOwnersPg));

            return this;
        }

        [AllureStep("VerifyMessageSuccessCreatedOwner")]
        public ListOfOwners VerifyMessageSuccessCreatedOwner()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageOwnerHasBeenSuccessfullyCreated));
            WaitUntil.WaitSomeInterval(1000);

            return this;
        }

        [AllureStep("VerifyEmailForNewOwner")]
        public ListOfOwners VerifyEmailForNewOwner(string getOwnerEmailFromModalWndw, string getLastEmailFromPage)
        {
            WaitUntil.WaitSomeInterval(3000);
            Assert.AreEqual(getOwnerEmailFromModalWndw, getLastEmailFromPage);
            Console.WriteLine($"{getOwnerEmailFromModalWndw} :Email in the time creating");
            Console.WriteLine($"{getLastEmailFromPage} :Email after creating");

            return this;
        }
    }
}
