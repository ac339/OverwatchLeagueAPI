using System;
using System.ComponentModel;
using System.Threading.Tasks;
using OverwatchLeagueAPI;
using OverwatchLeagueAPI.Models.Matches;

namespace OverwatchLeagueAPI.Example
{
    public class Program
    {
        [STAThread]
        static async Task Main(string[] args)
        {
            OverwatchLeagueApi api = new OverwatchLeagueApi();
            string matchId = "10528";
            string mapId = "1";
            Map map = await api.GetMapStats(matchId, mapId);
            Console.Out.WriteLine("Map retrieved");
            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(map))
            {
                string name = descriptor.Name;
                object value = descriptor.GetValue(map);
                Console.WriteLine("{0}: {1}", name, value);
            }
            Console.ReadLine();
        }
    }
}
