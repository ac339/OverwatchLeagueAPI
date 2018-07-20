using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OverwatchLeagueAPI.Models.Matches
{
    /// <summary>
    /// Represents a player's overall statistics, for a particular match, on a specific map
    /// (e.g. Seagull (Fuel)'s performance on King's Row vs. Shanghai in Stage 4).
    /// </summary>
[JsonObject("stats")]
    public class PlayerStat
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
