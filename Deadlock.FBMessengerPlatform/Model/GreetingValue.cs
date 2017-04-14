using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class GreetingValue
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="locale"></param>
        /// <param name="text">
        //  You can personalize the greeting text using the person's name. You can use the following template strings:
        /// {{user_first_name}}, {{user_last_name}}, {{user_full_name}} 
        /// </param>
        public GreetingValue(string locale = null, string text = null)
        {
            this.Locale = locale;
            this.Text = text;
        }       

        [JsonProperty("locale")]
        public string Locale { get; set; }

        /// <summary>
        /// You can personalize the greeting text using the person's name. You can use the following template strings:
        /// {{user_first_name}}, {{user_last_name}}, {{user_full_name}}
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
