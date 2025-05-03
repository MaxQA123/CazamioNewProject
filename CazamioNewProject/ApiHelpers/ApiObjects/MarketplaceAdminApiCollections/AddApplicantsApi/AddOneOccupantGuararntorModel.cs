using Newtonsoft.Json;

namespace CazamioNewProject.AddApplicantsApi
{ 
    public partial class RequestAddApplicants
    {
        [JsonProperty("applicationId")]
        public long ApplicationId { get; set; }

        [JsonProperty("applicants")]
        public Applicant[] Applicants { get; set; }
    }

    public partial class Applicant
    {
        [JsonProperty("suggestions")]
        public object[] Suggestions { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("isGuarantor")]
        public bool IsGuarantor { get; set; }
    }
}
