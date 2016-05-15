using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Deadlock.FBMessengerPlatform.WebHooks;

namespace Deadlock.FBMessengerPlatform.Test.Controller
{
    public class FacebookController : Deadlock.FBMessengerPlatform.WebHooks.WebHooksController
    {
        public override HttpResponseMessage Get([System.Web.Http.FromUriAttribute] Hub hub)
        {
            //Add in appSettings <add key="Deadlock.FBMessengerPlatform.VerifyToken" value="{VerifyToken}" />
            return base.Get(hub);
        }

        public override HttpResponseMessage Post([System.Web.Http.FromBodyAttribute] Callback value)
        {
            //Implementation
            foreach(Entry entry in value.Entry)
            {
                foreach(Messaging messaging in entry.Messaging)
                {
                    if(messaging.Delivery != null)
                    {
                        //Confirmation Delivery
                    }
                    else if (messaging.Message != null)
                    {
                        //User Send Message
                    }
                    else if (messaging.Optin != null)
                    {
                        //User Call "Message Us" 
                    }
                    else if (messaging.PostBack != null)
                    {
                        //User Button Click PostBack
                    }
                }
            }
            return base.Post(value);
        }
    }
}
