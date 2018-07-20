using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OverwatchLeagueAPI.Models.Matches
{
    /// <summary>
    /// The statistics for the game itself. Currently the OWL API only looks at total game time.
    /// </summary>
    public class GameStat
    {
        public string Name { get; set; }
        public int Value { get; set; }
    }
}
