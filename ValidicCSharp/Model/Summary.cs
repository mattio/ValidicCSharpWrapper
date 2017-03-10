using System;
using Newtonsoft.Json;
using ValidicCSharp.Interfaces;

namespace ValidicCSharp.Model
{
    public class Summary : IValidic
    {
        [JsonProperty("status")]
        public StatusCode Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("results")]
        public int Results { get; set; }

        [JsonProperty("start_date")]
        public DateTime? StartDate { get; set; }

        [JsonProperty("end_date")]
        public DateTime? EndDate { get; set; }

        [JsonProperty("offset")]
        public int? Offset { get; set; }

        [JsonProperty("limit")]
        public int? Limit { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("params")]
        public Parameters Parameters { get; set; }
    }
}