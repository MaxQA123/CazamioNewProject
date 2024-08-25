using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.PageObjects.AdminPages.NewBuildingPage
{
    public partial class NewBuilding
    {
        [AllureStep("VerifyTitleListOfBuildingsPg")]
        public NewBuilding VerifyTitleNewBuildingPg()
        {
            WaitUntil.CustomElementIsVisible(LoaderHidden);
            WaitUntil.WaitSomeInterval(1000);
            Assert.IsTrue(Successfully.IsVisible(TitleNewBuildingPage));

            return this;
        }

        public string CopyNameLocation()
        {
            WaitUntil.CustomElementIsVisible(FieldInputLocationForAccess);
            string getNameLocation = (FieldInputLocationForAccess).GetAttribute("value");
            string nameLocationActual = getNameLocation.ToString();

            return nameLocationActual;
        }


        [AllureStep("VerifyLocationMainAccess")]
        public NewBuilding VerifyLocationMainAccess(string nameLocationActual)
        {
            Assert.AreEqual(nameLocationActual, building.AccessLocks.MainEntranceByDefaultFirstNameLock);

            Console.WriteLine($"AR: {nameLocationActual} ER: {building.AccessLocks.MainEntranceByDefaultFirstNameLock}");

            return this;
        }

        [AllureStep("VerifyLocationApartment")]
        public NewBuilding VerifyLocationApartment(string copyActualNameLocationTwo)
        {
            Assert.AreEqual(copyActualNameLocationTwo, building.AccessLocks.ApartmentByDefaultSecondNameLock);

            Console.WriteLine($"AR: {copyActualNameLocationTwo} ER: {building.AccessLocks.ApartmentByDefaultSecondNameLock}");

            return this;
        }

        [AllureStep("VerifyValueByDefaulScreeningFee")]
        public NewBuilding VerifyValueByDefaulScreeningFee(string valueScreeningFeeByDefault)
        {
            Assert.AreEqual(valueScreeningFeeByDefault, building.MySpaceAmountPayments.CreditScreeningFeeByDefault);

            Console.WriteLine($"Value Screening Fee by default AR: {valueScreeningFeeByDefault} ER: {building.MySpaceAmountPayments.CreditScreeningFeeByDefault}");

            return this;
        }

        [AllureStep("VerifyValueByDefaulHoldDeposit")]
        public NewBuilding VerifyValueByDefaulHoldDeposit(string getValueHoldDeposit)
        {
            Assert.AreEqual(getValueHoldDeposit, building.MySpaceAmountPayments.HoldDepositByDefault);

            Console.WriteLine($"Value Screening Fee by default AR: {getValueHoldDeposit} ER: {building.MySpaceAmountPayments.HoldDepositByDefault}");

            return this;
        }

        public NewBuilding VerifyTypeAccessFromTable(string nameNoteActual, string namePinCodeActual)
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(nameNoteActual, TestDataLandlord.NOTE_NAME_LOCK_ACCESS, $"Name note not equal");
                Assert.AreEqual(namePinCodeActual, TestDataLandlord.PIN_CODE_NAME_LOCK_ACCESS, $"Name pin code not equal");
            });

            return this;
        }

        [AllureStep("VerifyNameConcessionAndFreeStuff")]
        public NewBuilding VerifyNameConcessionAndFreeStuff(string nameConcessionActual, string getNameFreeStuffActual)
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(nameConcessionActual, building.SettingsConcessions.NameFirst, $"Name concession not equal");
                Assert.AreEqual(getNameFreeStuffActual, building.SettingsFreeStuff.NameFirst, $"Name free stuff not equal");
            });

            return this;
        }

        [AllureStep("VerifyMessageSavedSuccessfullyBuilding")]
        public NewBuilding VerifyMessageSavedSuccessfullyBuilding()
        {
            WaitUntil.CustomElementIsVisible(MessageSavedSuccessfullyBuilding);
            Assert.IsTrue(Successfully.IsVisible(MessageSavedSuccessfullyBuilding));

            return this;
        }
    }
}
