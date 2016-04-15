using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Deadlock.FBMessengerPlatform.WebHooks
{
    public abstract class WebHooksController : ApiController
    {
        public virtual HttpResponseMessage Get([FromUri]Hub hub)
        {
            if (hub.verify_token == Settings.VerifyToken)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.OK);
                resp.Content = new StringContent(hub.challenge, System.Text.Encoding.UTF8, "text/plain");
                return resp;
            }
            else
                return Request.CreateResponse(HttpStatusCode.BadRequest, "The token does not match.");
        }

        public virtual HttpResponseMessage Post([FromBody]Callback value)
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
