using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharityVoting.Models
{
    public class Vote
    {
        [JsonProperty("TanmayDharmaraj")]
        public int TanmayDharmaraj { get; set; }

        [JsonProperty("DonaldTrump")]
        public int DonaldTrump { get; set; }
    }
}