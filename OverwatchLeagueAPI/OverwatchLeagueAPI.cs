using System;
using System.Threading.Tasks;
using OverwatchLeagueAPI.Client;
using OverwatchLeagueAPI.Models.Matches;

namespace OverwatchLeagueAPI
{
    /// <summary>
    /// The main Overwatch League API class.
    /// </summary>
    public class OverwatchLeagueApi : IDisposable
    {
        private OverwatchLeagueClient apiClient;
        private OverwatchLeagueBuilder builder;

        public OverwatchLeagueApi()
        {
            apiClient = new OverwatchLeagueClient();
            builder = new OverwatchLeagueBuilder();
        }

        public void Dispose()
        {
            apiClient.Dispose();
            GC.SuppressFinalize(this);
        }
        
        /// <summary>
        /// Asynchronous method to retrieve the map statistics for a particular match.
        /// </summary>
        /// <param name="matchId">The match ID</param>
        /// <param name="mapId">The map ID</param>
        /// <returns></returns>
        public async Task<Map> GetMapStats(string matchId, string mapId)
        {
            var maps = builder.GetMatchStats(matchId, mapId);
            return await apiClient.GetAsync<Map>(maps);
        }
    }
}
