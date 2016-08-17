using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class Greeting
    {
        /// <summary>
        /// greeting.text must be UTF-8 and has a 160 character limit
        /// </summary>
        public string text { get; set; }
    }
}
