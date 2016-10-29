using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class ResultError
    {
        public string Message { get; set; }

        public string Type { get; set; }

        public int Code { get; set; }

        public int ErrorSubcode { get; set; }

        public string FBTraceId { get; set; }
    }
}
