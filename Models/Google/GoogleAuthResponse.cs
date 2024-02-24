using Newtonsoft.Json;

namespace Crv5heR.OAuth.Google.Models.Google
{
    public class GoogleAuthResponse
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Given_Name")]
        public string GivenName { get; set; }

        [JsonProperty("Family_Name")]
        public string FamilyName { get; set; }

        [JsonProperty("Email")]
        public string Email { get; set; }

        [JsonProperty("Picture")]
        public string Picture { get; set; }

        [JsonProperty("hd")]
        public string HostedDomain { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }
    }
}
