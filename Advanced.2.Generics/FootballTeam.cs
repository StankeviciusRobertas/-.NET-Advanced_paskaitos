using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced._2.Generics
{
    internal class FootballTeam
    {
        public string TeamName { get; set; }

        public FootballTeam(string teamName)
        {
            TeamName = teamName;
        }

        public override string ToString()
        {
            return $"Futbolo komanda: {TeamName}";
        }
    }
}
