using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class PersistentMenu
    {
        public PersistentMenu()
        {

        }

        public PersistentMenu(string locale, bool composerInputDisabled, List<MenuItem> menuItems)
        {
            this.Locale = locale;
            this.ComposerInputDisabled = composerInputDisabled;
            this.MenuItems = menuItems;
        }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("composer_input_disabled")]
        public bool ComposerInputDisabled { get; set; }

        [JsonProperty("call_to_actions")]
        public List<MenuItem> MenuItems { get; set; }
    }
}
