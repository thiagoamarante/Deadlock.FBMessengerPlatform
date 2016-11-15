//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Deadlock.FBMessengerPlatform.Model
//{
//    /// <summary>
//    /// You can send images by uploading them or sharing a URL using the Send API. Supported formats are jpg, png and gif.
//    /// </summary>
//    public class ImageAttachment : Attachment<MediaPayload>
//    {
//        public ImageAttachment() 
//            : base("image")
//        {
//        }

//        public ImageAttachment(string url, bool isReusable = false)
//            : this()
//        {
//            this.Payload = new MediaPayload(url, isReusable);
//        }
//    }
//}
