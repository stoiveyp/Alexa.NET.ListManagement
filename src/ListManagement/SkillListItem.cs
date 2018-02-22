using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.ListManagement.Requests;
using Newtonsoft.Json;

namespace Alexa.NET.ListManagement
{
    public class SkillListItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("createdTime")]
        public string CreatedTime { get; set; }

        [JsonProperty("updatedTime")]
        public string UpdatedTime { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }
    }
}
