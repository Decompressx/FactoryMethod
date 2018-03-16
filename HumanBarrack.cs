using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class HumanBarrack : Barrack
    {
        protected override Unit CreateUnit(string role)
        {
            if (role.Equals("Warrior"))
            {
                return new HumanWarrior();
            }
            else if (role.Equals("Archer"))
            {
                return new HumanArcher();
            }
            else if (role.Equals("Mage"))
            {
                return new HumanMage();
            }
            else return null;
        }
    }
}
