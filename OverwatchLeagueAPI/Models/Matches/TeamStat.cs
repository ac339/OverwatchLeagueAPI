using System;
using System.Collections.Generic;
using System.Text;

namespace OverwatchLeagueAPI.Models.Matches
{
    /// <summary>
    /// Represents a team's overall statistics, for a particular match, on a specific map
    /// (e.g. Dallas' performance on King's Row vs. Shanghai in Stage 4).
    /// </summary>
    public class TeamStat
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public string Id { get; set; }
    }
}
