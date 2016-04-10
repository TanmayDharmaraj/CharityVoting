using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharityVoting.Models
{
    public class Vote
    {
        [JsonProperty("Vote1")]
        public int Vote1 { get; set; }

        [JsonProperty("Vote2")]
        public int Vote2{ get; set; }

        [JsonProperty("Vote3")]
        public int Vote3 { get; set; }
    }
}