using Newtonsoft.Json;
using OverwatchLeagueAPI.Attributes;
using OverwatchLeagueAPI.Models.Matches;
using System;
using System.Collections.Generic;
using System.Text;

namespace OverwatchLeagueAPI.Models
{
    /// <summary>
    /// Represents a specific OWL team's performance in a particular match, on a specific map.
    /// </summary>
    public class Team
    {
        /// <summary>
        /// The esports team ID for this team.
        /// </summary>
        [JsonProperty("esports_match_id")]
        public int EsportsTeamId { get; set; }

        #region Relevant for Maps in Matches
            /// <summary>
            /// The overall team statistics of a team, for a particular map in a particular match.
            /// </summary>
            [UsageContext(ApiContext.Matches)]
            [JsonProperty("stats")]
            public List<TeamStat> TeamStats { get; set; }

            [UsageContext(ApiContext.Matches)]
            [JsonProperty("players")]
            public List<Player> Players { get; set; }
        #endregion


    }
}
