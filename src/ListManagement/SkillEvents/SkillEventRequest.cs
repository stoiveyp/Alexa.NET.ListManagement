using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Alexa.NET.ListManagement.SkillEvents
{
    public class SkillEventRequest:Request.Type.Request
    {
        [JsonProperty("body")]
        public SkillEventInformation Body { get; set; }
    }
}
