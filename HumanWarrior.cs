using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class HumanWarrior : Unit
    {
        public override string Voice()
        {
            return "Человек-Воин";
        }
    }
}
