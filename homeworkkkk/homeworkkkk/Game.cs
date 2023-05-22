using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace homeworkkkk
{
     class Game
    {
        public Team TeamA { get; set; }
        public Team TeamB { get; set; }
        public Referee Referee { get; set; }
        public AssistantReferee [] AssistantReferee { get; set; }
        public Goals[] Goal { get; set; }
        public GameResult GameeResultt { get; set; }


        public Game(Team teamA, Team teamB, Referee referee, AssistantReferee [] assistantReferees)
        {
            TeamA = teamA;
            TeamB = teamB;
            Referee = referee;
            AssistantReferee = assistantReferees;
            Goal = new Goals[0];
        }

        public void AddGoals(int minute, FootballPlayer player)
        {
            Goals[]temp = new Goals[Goal.Length];
            Array.Resize(ref temp, Goal.Length + 1);
             Goal[Goal.Length - 1] = new Goals(minute, player);
        }

        public void GameResultt(string result, string winner)
        {
            GameeResultt = new GameResult(result, winner);
        }
    }
}
