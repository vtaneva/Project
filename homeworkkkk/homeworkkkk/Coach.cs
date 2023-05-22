using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkkkk
{
   class Coach : Person, ICoach
    {
        public Coach(string name, int age) : base (name, age)
        {
        }
    }
}
