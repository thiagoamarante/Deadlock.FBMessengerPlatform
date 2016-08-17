using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class GetStartedButtonThreadSettings : IThreadSettings
    {
        public string setting_type { get; set; } = "call_to_actions";

        public string thread_state { get; set; } = "new_thread";

        /// <summary>
        /// call_to_actions is limited to 1
        /// call_to_actions must contain at least one payload string. This data will be sent back to you via webhook
        /// </summary>
        public List<GetStartedButtonCallToActions> call_to_actions { get; set; }
    }
}
