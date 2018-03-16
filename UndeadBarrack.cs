using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class UndeadBarrack : Barrack
    {
        protected override Unit CreateUnit(string role)
        {
            if (role.Equals("Warrior"))
            {
                return new UndeadWarrior();
            }
            else if (role.Equals("Archer"))
            {
                return new UndeadArcher();
            }
            else if (role.Equals("Mage"))
            {
                return new UndeadMage();
            }
            else return null;
        }
    }
}
