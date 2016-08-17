using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class Address
    {
        /// <summary>
        /// Street Address, line 1
        /// </summary>
        public string street_1 { get; set; }

        /// <summary>
        /// Street Address, line 2
        /// </summary>
        public string street_2 { get; set; }

        /// <summary>
        /// City
        /// </summary>
        public string city { get; set; }

        /// <summary>
        /// US Postal Code
        /// </summary>
        public string postal_code { get; set; }

        /// <summary>
        /// Two-letter state abbrevation (US)
        /// </summary>
        public string state { get; set; }

        /// <summary>
        /// Two-letter country abbreviation
        /// </summary>
        public string country { get; set; }
    }
}
