using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Client
{
    public interface IElement
    {
        string title { get; set; }

        string image_url { get; set; }

        string subtitle { get; set; }
    }
}
