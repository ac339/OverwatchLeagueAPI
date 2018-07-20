using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace OverwatchLeagueAPI.Models.Matches
{
    /// <summary>
    /// Map-specific statistics for a particular match
    /// (e.g. King's Row statistics for the Stage 4 match between Dallas and Shanghai).
    /// </summary>
    public class Map
    {

        /// <summary>
        /// The game ID.
        /// </summary>
        [JsonProperty("game_id")]
        private Guid gameId;
        public Guid GameId
        {
            get
            {
                return this.gameId;
            }

            set
            {
                Guid.TryParse(value.ToString(), out this.gameId);
            }
        }

        /// <summary>
        /// The match ID.
        /// </summary>
        [JsonProperty("match_id")]
        private Guid matchId;
        public Guid MatchId
        {
            get
            {
                return this.matchId;
            }

            set
            {
                Guid.TryParse(value.ToString(), out this.matchId);
            }
        }

        /// <summary>
        /// The tournament ID.
        /// </summary>
        [JsonProperty("tournament_id")]
        public int TournamentId { get; set; }

        /// <summary>
        /// The tournament type. So far, this has been set to the string 'owl'.
        /// </summary>
        [JsonProperty("tournament_type")]
        public string TournamentType { get; set; }

        /// <summary>
        /// The phase of the tournament, indicated by a string, e.g. "preseason".
        /// </summary>
        [JsonProperty("tournament_phase")]
        public string TournamentPhase { get; set; }

        /// <summary>
        /// The season ID. It seems that this is set to the starting year of that season, e.g. "2017".
        /// </summary>
        [JsonProperty("season_id")]
        public string SeasonId { get; set; }

        /// <summary>
        /// The game number. This indicates the order of the map being played, e.g. the 3rd map played would have GameNumber set to '3'.
        /// </summary>
        [JsonProperty("game_number")]
        public int GameNumber { get; set; }

        /// <summary>
        /// The map ID. This is set to some byte value.
        /// </summary>
        [JsonProperty("map_id")]
        public string MapId { get; set; }

        /// <summary>
        /// The type of map being played. Blizzard currently has set this property's values to be in all-caps, e.g. "CONTROL".
        /// </summary>
        [JsonProperty("map_type")]
        public string MapType { get; set; }

        /// <summary>
        /// The instance ID.
        /// </summary>
        [JsonProperty("instance_id")]
        private Guid instanceId;
        public Guid InstanceId
        {
            get
            {
                return this.instanceId;
            }

            set
            {
                Guid.TryParse(value.ToString(), out this.instanceId);
            }
        }

        /// <summary>
        /// The esports tournament ID. Unlike TournamentId, this is a number reference to an index, as opposed to a GUID.
        /// </summary>
        [JsonProperty("esports_tournament_id")]
        public int EsportsTournamentId { get; set; }

        /// <summary>
        /// The esports match ID. Unlike MatchId, this is a number reference to an index, as opposed to a GUID.
        /// </summary>
        [JsonProperty("esports_match_id")]
        public int EsportsMatchId { get; set; }

        /// <summary>
        /// The game statistics.
        /// </summary>
        [JsonProperty("stats")]
        public List<GameStat> GameStats { get; set; }

        /// <summary>
        /// The teams that played on this map.
        /// </summary>
        [JsonProperty("teams")]
        public List<Team> Teams { get; set; }
    }
}
