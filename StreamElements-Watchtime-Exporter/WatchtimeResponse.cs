using Newtonsoft.Json;

namespace StreamElements_Watchtime_Exporter
{
    internal class WatchtimeResponse
    {
        [JsonProperty("_total")]
        public uint? Total { get; set; }
        [JsonProperty("users")]
        public WatchtimeUser[]? Users { get; set; }
    }
}
