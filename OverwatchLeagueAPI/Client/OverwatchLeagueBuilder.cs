using System;
using System.Collections.Generic;
using System.Text;

namespace OverwatchLeagueAPI.Client
{
    /// <summary>
    /// Builds the URLs needed for the known API endpoints.
    /// </summary>
    public class OverwatchLeagueBuilder
    {
        public const string BaseUrl = "https://api.overwatchleague.com";

        /// <summary>
        /// Get particular map stats for a particular match.
        /// </summary>
        /// <param name="matchId">The match ID.</param>
        /// <param name="mapId">The specific map ID. This corresponds to the game that they play.</param>
        /// <returns></returns>
        public string GetMatchStats(string matchId, string mapId)
        {
            return $"{BaseUrl}/stats/matches/{matchId}/maps/{mapId}";
        }

        /// <summary>
        /// Gets base statistics for all players in the Overwatch League.
        /// </summary>
        /// <returns>All player statistics.</returns>
        public string GetPlayerStats()
        {
            return $"{BaseUrl}/stats/players";
        }

        /// <summary>
        /// Returns statistics for all players, with parameters to filter out particular parts of a season, or a particular stage.
        /// </summary>
        /// <param name="StageId">The stage ID (e.g. "regular_season", or "postseason")</param>
        /// <param name="SeasonId">The season ID (e.g. 2017)</param>
        /// <returns></returns>
        public string GetPlayerStats(string StageId = null, string SeasonId = null)
        {
            var statsUrl = $"{BaseUrl}/stats/players";
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(statsUrl);

            if(StageId == null && SeasonId == null)
            {
                return statsUrl;
            }

            stringBuilder.Append("?");

            if(StageId != null)
            {
                stringBuilder.Append(String.Format("stage_id={0}", StageId));
            }
            else if(SeasonId != null)
            {
                stringBuilder.Append(String.Format("season_id={0}", SeasonId));
            }
            else
            {
                stringBuilder.Append(String.Format("season_id={0}&stage_id={1}", SeasonId, StageId));
            }

            return stringBuilder.ToString();
        }

        /// <summary>
        /// Gets the upcoming live matches.
        /// </summary>
        /// <returns>The upcoming live matches.</returns>
        public string GetLiveMatches()
        {
            return $"{BaseUrl}/live-match";
        }

        /// <summary>
        /// Gets information about the various teams competing in Overwatch League.
        /// </summary>
        /// <returns>Teams, team data, and social media information.</returns>
        public string GetTeams()
        {
            return $"{BaseUrl}/teams";
        }

        /// <summary>
        /// Gets the schedule of the entire league.
        /// </summary>
        /// <returns>The schedule of all of the teams -- who's playing who, and the results of each match (if completed).</returns>
        public string GetSchedule()
        {
            return $"{BaseUrl}/schedule";
        }

        /// <summary>
        /// Gets the current team standings.
        /// </summary>
        /// <returns>The team standings.</returns>
        public string GetStandings()
        {
            return $"{BaseUrl}/v2/standings";
        }

        /// <summary>
        /// Gets the current team rankings.
        /// </summary>
        /// <returns>The team rankings.</returns>
        public string GetRankings()
        {
            return $"{BaseUrl}/ranking";
        }

        /// <summary>
        /// Returns descriptions and other information about the maps in Overwatch. 
        /// </summary>
        /// <returns>Map information.</returns>
        public string GetMaps()
        {
            return $"{BaseUrl}/maps";
        }
    }
}
