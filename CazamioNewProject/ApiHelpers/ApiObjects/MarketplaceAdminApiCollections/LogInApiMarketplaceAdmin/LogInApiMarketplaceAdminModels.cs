using Newtonsoft.Json;
using System;

namespace CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.LogInApiMarketplaceAdmin
{
    public class RequestLogInApiMarketplaceAdmin
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string DeviceFingerprint { get; set; }
        public bool RememberMe { get; set; }
    }

    public partial class ResponseLogInApiMarketplaceAdmin
    {
        [JsonProperty("authData")]
        public AuthData AuthData { get; set; }

        [JsonProperty("marketplaceId")]
        public long MarketplaceId { get; set; }

        [JsonProperty("isBanned")]
        public bool IsBanned { get; set; }

        [JsonProperty("logo")]
        public Uri Logo { get; set; }

        [JsonProperty("brand")]
        public string Brand { get; set; }

    }

    public partial class AuthData
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("refreshToken")]
        public string RefreshToken { get; set; }

        [JsonProperty("expireDate")]
        public DateTimeOffset ExpireDate { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("wasUserRegistered")]
        public bool WasUserRegistered { get; set; }
    }

    public partial class User
    {
        [JsonProperty("userId")]
        public Guid UserId { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("userEmail")]
        public string UserEmail { get; set; }

        [JsonProperty("userRoleId")]
        public long UserRoleId { get; set; }

        [JsonProperty("userPhoto")]
        public string UserPhoto { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("isGenerated")]
        public bool IsGenerated { get; set; }

        [JsonProperty("loginLinkPasswordUpdated")]
        public bool LoginLinkPasswordUpdated { get; set; }
    }
}
