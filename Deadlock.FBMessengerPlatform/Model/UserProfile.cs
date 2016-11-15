using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class UserProfile
    {
        [JsonProperty("first_name")]
        public string Firstname { get; set; }

        [JsonProperty("last_name")]
        public string Lastname { get; set; }

        [JsonProperty("profile_pic")]
        public string ProfilePicture { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("is_payment_enabled")]
        public bool IsPaymentEnabled { get; set; }
    }
}
