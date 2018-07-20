using OverwatchLeagueAPI.Models.Matches;
using OverwatchLeagueAPI.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace OverwatchLeagueAPI.Models
{
    /// <summary>
    /// Represents a specific professional Overwatch League player.
    /// </summary>
    public class Player
    {
        #region Relevant for Maps in Matches
            /// <summary>
            /// The player ID.
            /// </summary>
            [UsageContext(ApiContext.Matches)]
            public int EsportsPlayerId { get; set; }

            /// <summary>
            /// The statistics for a specific player, on a specific map and for a specific match.
            /// </summary>
            [UsageContext(ApiContext.Matches)]
            public List<PlayerStat> PlayerStats { get; set; }

            /// <summary>
            /// The statistics for the heroes that a player played, on a specific map and for a specific match.
            /// </summary>
            [UsageContext(ApiContext.Matches)]
            public List<Hero> Heroes { get; set; }
        #endregion

        #region Relevant for Player Aggregation
            
        #endregion
    }
}
