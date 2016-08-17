using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class Adjustment
    {
        /// <summary>
        /// Name of adjustment
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Adjusted amount
        /// </summary>
        public decimal amount { get; set; }
    }
}
