using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkkkk
{
    class GameResult
    {
        public string Result { get; set; }
        public string Winner { get; set; }

        public GameResult(string result, string winner)
        {
            Result = result;
            Winner = winner;
        }
    }
}
