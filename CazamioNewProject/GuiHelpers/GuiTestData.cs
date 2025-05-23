﻿namespace CazamioNewProject.GuiHelpers
{
    public class StartPoints
    {
        public const string URL_HOME_PAGE_TENANT_MARKET_MYSPACE = "https://testlandlord15-demo.casamio-test.lol/";
        public const string URL_HOME_PAGE_TENANT_MARKET_EVERGREEN = "https://testlandlord17-demo.casamio-test.lol/";
        public const string URL_HOME_PAGE_TENANT_MARKET_DOORWAY = "https://testlandlord18-demo.casamio-test.lol/";
        public const string URL_HOME_PAGE_TENANT_MARKET_JRZEE = "https://testlandlord19-demo.casamio-test.lol/";
        public const string URL_LOGIN_ADMIN_WEBSITE = "https://landlord-demo.casamio-test.lol/account/signin";

        public const string URL_XITROO_EMAIL_RANDOM = "https://xitroo.com/";
        public const string URL_XITROO_STATIC_SUPER_ADMIN = "https://xitroo.com/#testadmin@xitroo.com";
        public const string URL_XITROO_STATIC_BROKER = "https://xitroo.com/#evilhtingale@xitroo.com";
        public const string URL_XITROO_STATIC_ADMIN = "https://xitroo.com/#testlandlordcaz@xitroo.com";
        public const string URL_XITROO_STATIC_TENANT = "https://xitroo.com/#tenantoccupantliza@xitroo.com";

        public const string URL_PUTSBOX_EMAIL_STATIC_SUPER_ADMIN = "https://putsbox.com/superadmin123/inspect";

        #region MySpaceMarketplace

        public const string URL_PUTSBOX_EMAIL_STATIC_AGENT = "https://putsbox.com/agent175marie5urm/inspect";
        public const string URL_PUTSBOX_EMAIL_STATIC_BROKER = "https://putsbox.com/broker1aladin/inspect";
        public const string URL_PUTSBOX_EMAIL_STATIC_MARKETPLACE_ADMIN = "https://putsbox.com/marketplaceadmin15/inspect";
        public const string URL_PUTSBOX_EMAIL_STATIC_TENANT_APPLICANT = "https://putsbox.com/tenantapp123ray/inspect";
        public const string URL_PUTSBOX_EMAIL_STATIC_TENANT_OCCUPANT = "https://putsbox.com/tenantocc123liza/inspect";
        public const string URL_PUTSBOX_EMAIL_STATIC_TENANT_GUARANTOR = "https://putsbox.com/tenantgua123jim/inspect";

        #endregion
    }

    public class ConnectionDb
    {
        public const string GET_CONNECTION_STRING_TO_DB = "Server=20.110.40.246,1433;Database=CazamioStageDb;User Id=sa; password=sadvN742sJfe;MultipleActiveResultSets=true;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True";
    }

    public class GeneralTestDataForAllUsers
    {
        public const string PASSWORD_GENERAL = "Qwerty123!";
        public const string PASSWORD_NEW_GENEREAL = "!321Qwerty";
        public const int MARKETPLACE_ID_SUPER_ADMIN = 0;
        public const int MARKETPLACE_ID_MY_SPACE = 15;
    }

    public class CommonApiData
    {
        public const bool TRUE = true;
        public const bool FALSE = false;
    }

    public class TestDataLandlord
    {
        public const string USER_NAME_ROLE_SUPER_ADMIN = "Super Admin";
        public const string USER_NAME_ROLE_MARKETPLACE_ADMIN = "Marketplace Admin";
        public const string USER_NAME_ROLE_BROKER = "Broker";
        public const string USER_NAME_ROLE_AGENT = "Agent";
        public const string CAB_NAME_LOCK_ACCESS = "CAB";
        public const string NOTE_NAME_LOCK_ACCESS = "Note";
        public const string PIN_CODE_NAME_LOCK_ACCESS = "PinCode";
    }

    public class EmailNameDomen
    {
        public static string XITROO = "@xitroo.com";
        public const string PUTS_BOX = "@putsbox.com";
    }

    public class UploadImages
    {
        public const string AVATAR_IMG_TENANT = $"\\UploadImages\\TenantImgEnot.jpg";
        public const string LOGO_IMG_ADMIN_FIRST = $"\\UploadImages\\LogoLandLord1.jpg";
        public const string LOGO_IMG_ADMIN_SECOND = $"\\UploadImages\\LogoLandlord2.jpg";
        public const string AVATAR_IMG_ADMIN_FIRST = $"\\UploadImages\\2AvatarLandLord.jpg";
        public const string AVATAR_IMG_ADMIN_SECOND = $"\\UploadImages\\3AvatarKoalaLandlord.jpg";
        public const string IMAGE_BUILDING_LOCK_PIN_CODE = $"\\UploadImages\\PinCodeBuilding.jpg";
        public const string IMAGE_BUILDING_LOCK_NOTE = $"\\UploadImages\\NoteBuilding.jpg";
        public const string IMAGE_HOUSE_FOR_BUILDING = $"\\UploadImages\\HouseOne.jpg";
        public const string IMAGE_POOL_FOR_BUILDING = $"\\UploadImages\\Pool.jpg";
        public const string IMAGE_PARKING_FOR_BUILDING = $"\\UploadImages\\Parking.jpg";
        public const string IMAGE_YARD_FOR_BUILDING = $"\\UploadImages\\Yard.jpg";
        public const string IMAGE_FOR_PAYMENT_VENMO_SCREENING = $"\\UploadImages\\building screening.jpg";
        public const string IMAGE_FOR_PAYMENT_VENMO_HOLD_BUILDING = $"\\UploadImages\\building hold deposit.jpg";
        public const string IMAGE_FOR_PAYMENT_VENMO_HOLD_APARTMENT = $"\\UploadImages\\OK apartment hold deposit.jpg"; 
        public const string IMAGE_APARTMENT_LOCK_PIN_CODE = $"\\UploadImages\\PinCodeApartment.jpg";
        public const string IMAGE_APARTMENT_LOCK_NOTE = $"\\UploadImages\\NoteApartment.jpg";
        public const string IMAGE_APARTMENT_FIRST = $"\\UploadImages\\Bedroom1.jpg";
        public const string IMAGE_APARTMENT_SECOND = $"\\UploadImages\\Bedroom2.jpg";
        public const string IMAGE_APARTMENT_THIRD = $"\\UploadImages\\Bedroom3.jpg";
        public const string IMAGE_APARTMENT_FOURTH = $"\\UploadImages\\Bedroom4.jpg";
        public const string IMAGE_APARTMENT_FIFTH = $"\\UploadImages\\Bedroom5.jpg";
    }

    public class UploadTemplatesLandlord
    {
        public const string FIRST_NAME_FOR_MYSPACE = $"\\UploadImages\\FirstNameForMySpace.pdf";
        public const string SECOND_NAME_FOR_MYSPACE = $"\\UploadImages\\MySpaceBroker12345second.pdf";
    }

    public class UploadVideos
    {
        public const string VIDEO_FIRST_APARTMENT = $"\\UploadVideos\\First Video Nature.mp4";
    }

    public class ListOfAmenitiesForBuildingAdminsPage
    {
        public const int FIRST_TAG = 0;
    }

    public class ListOfAmenitiesForApartmentAdminsPage
    {
        public const int FIRST_TAG = 0;
    }

    public class ListOfAmenitiesForApartmentIncludedInMonthlyRent
    {
        public const int FIRST_TAG = 0;
    }

    public class ItemsPetPolicies
    {
        public const int CASE_BY_CASE = 0;
        public const int PETS_FEE = 1;
        public const int ALL_PETS_ALLOWED = 2;
        public const int SMALL_PETS_ALLOWED = 3;
        public const int CATS_ONLY = 4;
        public const int NO_PETS = 5;
    }
}
