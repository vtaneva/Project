using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace homeworkkkk
{
    class Team 
    {
        public Team(ICoach coach, IFootballPlayer[] players)
        {
            Coach = coach;
            Players = players;
        }
        public ICoach Coach { get; set; }
        public IFootballPlayer[] Players { get; set; }

        public double AverageAge
        {
            get
            {
                if (Players.Length == 0)
                    return 0;

                int playersage = 0;
                double averageage = 0;
                foreach (var player in Players)
                {
                    playersage += player.Age;
                }
                averageage = (playersage / Players.Length);
                return averageage;
            }
        }
    }
}
