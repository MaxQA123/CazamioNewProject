using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.PageObjects.AdminPages.PetPoliciesMdlWndw
{
    public partial class PetPoliciesMdlWndw
    {
        [AllureStep("SelectAllItems")]
        public PetPoliciesMdlWndw SelectAllItems()
        {
            Pages.PetPoliciesMdlWndw
                .SelectItemPetPolocies(ItemsPetPolicies.CASE_BY_CASE)
                .SelectItemPetPolocies(ItemsPetPolicies.PETS_FEE)
                .SelectItemPetPolocies(ItemsPetPolicies.ALL_PETS_ALLOWED)
                .SelectItemPetPolocies(ItemsPetPolicies.SMALL_PETS_ALLOWED)
                .SelectItemPetPolocies(ItemsPetPolicies.CATS_ONLY)
                .SelectItemPetPolocies(ItemsPetPolicies.NO_PETS);

            return this;
        }
    }
}
