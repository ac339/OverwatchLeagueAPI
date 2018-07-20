using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OverwatchLeagueAPI.Client
{
    /// <summary>
    /// The client that retrieves the JSON data from the Overwatch League API.
    /// </summary>
    class OverwatchLeagueClient : IDisposable
    {
        private static HttpClient client;
        private const string BaseUrl = "https://api.overwatchleague.com/";
        private const string StatsUrl = BaseUrl + "stats/";

        public OverwatchLeagueClient()
        {
            client = new HttpClient();
        }

        /// <summary>
        /// Asynchronously retrieves the JSON data from the specified URL.
        /// </summary>
        /// <typeparam name="T">A generic type</typeparam>
        /// <param name="url">The string URL</param>
        /// <returns></returns>
        public async Task<T> GetAsync<T>(string url)
        {
            try
            {
                using (HttpResponseMessage response = await client.GetAsync(url, HttpCompletionOption.ResponseContentRead).ConfigureAwait(false))
                {
                    response.EnsureSuccessStatusCode();

                    var readResponse = await response.Content.ReadAsStringAsync();

                    Func<Task<T>> deserializeFunc = async () => JsonConvert.DeserializeObject<T>(readResponse);
                    return await Task.Run(deserializeFunc);
                }
            }
            catch (HttpRequestException hre)
            {
                throw new Exception("HttpRequestException: " + hre.Message, hre);
            }
            catch (Exception e) { 
                throw new Exception("Async get failed: " + e.Message, e);
            }
        }

        /// <summary>
        /// Releases this resource (implements IDispoable).
        /// </summary>
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
