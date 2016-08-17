using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class Recipient
    {
        /// <summary>
        /// Phone number of the recipient with the format +1(212)555-2368
        /// </summary>
        public string phone_number { get; set; }

        /// <summary>
        /// ID of recipient
        /// </summary>
        public string id { get; set; }
    }
}
