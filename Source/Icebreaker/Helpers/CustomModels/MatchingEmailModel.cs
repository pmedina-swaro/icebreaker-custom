using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Icebreaker.Helpers.CustomModels
{
    public class MatchingEmailModel
    {

        [JsonProperty("Recipient1")]
        public string Recipient1 { get; set; }
        [JsonProperty("Recipient2")]
        public string Recipient2 { get; set; }

        [JsonProperty("Subject")]
        public string Subject{ get; set; }

        [JsonProperty("Content1")]
        public string Content1{ get; set; }

        [JsonProperty("Content2")]
        public string Content2 { get; set; }


    }
}