using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class NestedMenuItem : MenuItem
    {
        public NestedMenuItem()
            :base("nested")
        {

        }

        public NestedMenuItem(string title, List<MenuItem> menuItems)
            :this()
        {
            this.Title = title;
            this.MenuItems = menuItems;
        }

        [JsonProperty("call_to_actions")]
        public List<MenuItem> MenuItems { get; set; }
    }
}
