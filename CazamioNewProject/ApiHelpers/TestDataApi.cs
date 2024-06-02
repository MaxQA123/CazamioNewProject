using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.ApiHelpers
{
    public class BaseStartPointsApi
    {
        public const string API_HOST_WEBSITE_LANDLORD = "https://api-cazamio-staging.azurewebsites.net/";
        public const string API_HOST_WEBSITE_TENANT = "https://api-cazamio-staging.azurewebsites.net/";
    }

    public class ApiRequestData
    {
        public const string DEVICE_FINGERPRINT_MARKETPLACE_ADMIN = "5ab5f20f5788afc5e04f1bd0317c8356";
        public const bool TRUE = true;
        public const bool FALSE = false;
        public const object NULL = null;
        public const string RETURN_URL = "/";
    }

    public class ApiTestDataGeneral
    {
        public const string BRAND_NAME_MARKETPLACE_ONE = "Beautiful Life";
    }

    public class ApiTestDataBroker
    {
        public const string DEVICE_FINGERPRINT = "5ab5f20f5788afc5e04f1bd0317c8356";
    }

    public class ApiTestDataTenants
    {
        public const string DEVICE_FINGERPRINT = "417d13cf3013cfd714a7c316d0415eca";
    }
}
