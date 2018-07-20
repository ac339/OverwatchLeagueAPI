using Newtonsoft.Json;
using System.Collections.Generic;

namespace OverwatchLeagueAPI.Models.Matches
{
    /// <summary>
    /// A hero that a specific player played during a particular map, and on a specific match
    /// (e.g. Seagull's D.Va stats on King's Row, during Dallas' match against Shanghai in Stage 4).
    /// </summary>
    public class Hero
    {
        /// <summary>
        /// The hero ID.
        /// </summary>
        [JsonProperty("hero_id")]
        public string HeroId { get; set; }

        /// <summary>
        /// The hero name, e.g. "mercy".
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The list of statistics for this hero that a player played.
        /// </summary>
        [JsonProperty("stats")]
        public List<PlayerHeroStat> PlayerHeroStats {get; set;}
    }
}