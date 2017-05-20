using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public abstract class TemplatePayload : IPayload
    {
        public TemplatePayload(string templateType)
        {
            this.TemplateType = templateType;
        }

        /// <summary>
        /// Tempalte type generic, button or receipt
        /// </summary>
        [JsonProperty("template_type")]
        public string TemplateType { get; private set; }

        [JsonProperty("sharable")]
        public bool Sharable { get; set; } = true;
    }
}
