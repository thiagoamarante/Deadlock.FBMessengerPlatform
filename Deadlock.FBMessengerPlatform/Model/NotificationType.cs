using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public enum NotificationType
    {
        /// <summary>
        /// REGULAR will emit a sound/vibration and a phone notification
        /// </summary>
        [JsonProperty("REGULAR")]
        Regular = 0,

        /// <summary>
        /// SILENT_PUSH will just emit a phone notification
        /// </summary>
        [JsonProperty("SILENT_PUSH")]
        SilentPush,

        /// <summary>
        /// NO_PUSH will not emit either
        /// </summary>
        [JsonProperty("NO_PUSH")]
        NoPush
    }
}
