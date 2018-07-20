using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OverwatchLeagueAPI.Models.Matches
{
    /// <summary>
    /// Represents a player's hero-specific statistics, for a particular match, on a specific map
    /// (e.g. Seagull's performance as D.Va on King's Row in the Dallas vs. Shanghai match in Stage 4).
    /// </summary>
    public class PlayerHeroStat
    {
        /// <summary>
        /// The name of the statistic, e.g. "critical_hits".
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The value of this statistic.
        /// </summary>
        [JsonProperty("value")]
        public float Value { get; set; }

        /// <summary>
        /// The ID of this particular stat. Is typically shown as a byte value.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
