using Newtonsoft.Json;

namespace StreamElements_Watchtime_Exporter
{
    internal class WatchtimeUser
    {
        [JsonProperty("username")]
        public string? Username { get; set; }
        [JsonProperty("minutes")]
        public uint? Minutes { get; set; }
    }
}
