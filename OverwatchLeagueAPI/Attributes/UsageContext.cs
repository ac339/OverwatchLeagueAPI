using System;
using System.Collections.Generic;
using System.Text;

namespace OverwatchLeagueAPI.Attributes
{
    /// <summary>
    /// Enum to set the API's context.
    /// </summary>
    public enum ApiContext
    {
        Matches,
        Players
    }

    /// <summary>
    /// A custom attribute to determine what information is returned to the user.
    /// For example, different endpoints return different information about certain players.
    /// </summary>
    public class UsageContext : System.Attribute
    {
        private ApiContext Context { get; set; }

        public UsageContext(ApiContext context)
        {
            this.Context = context;
        }

    }
}
