//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Deadlock.FBMessengerPlatform.Model
//{
//    /// <summary>
//    /// You can send sounds by uploading them or sharing a URL using the Send API.
//    /// </summary>
//    public class AudioAttachment : Attachment<MediaPayload>
//    {
//        public AudioAttachment() 
//            : base("audio")
//        {
//        }

//        public AudioAttachment(string url, bool isReusable = false)
//            : this()
//        {
//            this.Payload = new MediaPayload(url, isReusable);
//        }
//    }
//}
