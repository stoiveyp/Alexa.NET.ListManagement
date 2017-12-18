using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Alexa.NET.ListManagement.SkillEvents
{
    public class SkillEventInformation
    {
        [JsonProperty("listId")]
        public string ListId { get; set; }

        [JsonProperty("listItemIds")]
        public string[] ListItemIds { get; set; }
    }
}
