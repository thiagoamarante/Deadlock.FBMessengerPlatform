using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class PersistentMenuThreadSettings : IThreadSettings
    {
        public string setting_type { get; set; } = "call_to_actions";

        public string thread_state { get; set; } = "existing_thread";

        /// <summary>
        /// call_to_actions is limited to 5
        /// </summary>
        public List<Button> call_to_actions { get; set; }
    }
}
