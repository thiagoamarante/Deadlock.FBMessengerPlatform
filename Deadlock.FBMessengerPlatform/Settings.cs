using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform
{
    public static class Settings
    {
        public static string VerifyToken { get { return System.Configuration.ConfigurationManager.AppSettings["Deadlock.FBMessengerPlatform.VerifyToken"]; } }
    }
}
