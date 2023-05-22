using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace homeworkkkk
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            ICoach coachLevski = new Coach("Coach Tonkin", 45);

            IFootballPlayer firstPlayerL = new Goalkeeper("George", 18, 1, 1.75);
            IFootballPlayer secondPlayerL = new Goalkeeper("Pavel", 20, 2, 1.70);
            IFootballPlayer thirdPlayerL = new Goalkeeper("Todor", 22, 3, 1.83);
            IFootballPlayer fourthPlayerL = new Defender("Michael", 28, 4, 1.89);
            IFootballPlayer fifthPlayerL = new Defender("Dimitar", 22, 5, 1.69);
            IFootballPlayer sixthPlayerL = new Striker("Nedqlko", 23, 6, 1.84);
            IFootballPlayer seventhPlayerL = new Striker("Lorenco", 25, 7, 1.90);
            IFootballPlayer eighthPlayerL = new Midfield("Anton", 26, 8, 1.80);
            IFootballPlayer ninthPlayerL = new Midfield("Luci", 20, 9, 1.87);

            IFootballPlayer[] LevskiPlayers = 
                {firstPlayerL,secondPlayerL,thirdPlayerL,fourthPlayerL,fifthPlayerL,sixthPlayerL,seventhPlayerL,eighthPlayerL, ninthPlayerL};
            Team levski = new Team(coachLevski, LevskiPlayers);


            ICoach coachManchester = new Coach("Coach Guardiola", 52);

            FootballPlayer[] ManchesterPlayers = new FootballPlayer[11];
            Random random = new Random();
            for (int i = 0; i < ManchesterPlayers.Length; i++)
            {
                ManchesterPlayers[i] = new Goalkeeper($"Member {i + 1}", i + 1, random.Next(18, 40), 1.80 + i);
                ManchesterPlayers[i/3] = new Midfield($"Member {i + 1}", i + 1, random.Next(18, 40), 1.75 + i);
                ManchesterPlayers[i/5] = new Defender($"Member {i + 1}", i + 1, random.Next(18, 40), 1.90 + i);
                ManchesterPlayers[i/7] = new Striker($"Member {i + 1}", i + 1, random.Next(18, 40), 1.85 + i);
            }
            Team manchester = new Team(coachManchester, new FootballPlayer[11]);


            Referee refereeRandom = new Referee("Referee Pierluigi Collina", 50);
            AssistantReferee[] assistantRef = new AssistantReferee[2]
            {
            new AssistantReferee("Assistant Junior", 20),
            new AssistantReferee("Assistant Junior 2", 22)
            };

            Game championship = new Game(levski, manchester, refereeRandom, assistantRef);
            championship.AddGoals(40, (FootballPlayer)fifthPlayerL);
            championship.AddGoals(80, ManchesterPlayers[5]);

            championship.GameResultt("1-1", "Even");

            Console.WriteLine($"Game Result: {championship.GameeResultt.Result}");
            Console.WriteLine($"Winner: {championship.GameeResultt.Winner}");
        }
    }  
}





