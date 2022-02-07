using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLCLib
{
    public class ProcessData
    {
        public Process riotClient { get; set; } = null;
        public string riotClientCmd { get; set; } = null;

        public Process leagueClient { get; set; } = null;
        public List<string> languages { get; set; } = null;
    }
}
