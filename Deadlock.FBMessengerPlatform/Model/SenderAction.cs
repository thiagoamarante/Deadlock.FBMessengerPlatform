using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public enum SenderAction
    {
        /// <summary>
        /// Mark last message as read
        /// </summary>
        [JsonProperty("mark_seen")]
        MarkSeen,

        /// <summary>
        /// Turn typing indicators on
        /// </summary>
        [JsonProperty("typing_on")]
        TypingOn,

        /// <summary>
        /// Turn typing indicators off
        /// </summary>
        [JsonProperty("typing_off")]
        TypingOff
    }
}
