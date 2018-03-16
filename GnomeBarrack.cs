using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class GnomeBarrack : Barrack
    {
        protected override Unit CreateUnit(string role)
        {
            if (role.Equals("Warrior"))
            {
                return new GnomeWarrior();
            }
            else if (role.Equals("Archer"))
            {
                return new GnomeArcher();
            }
            else if (role.Equals("Mage"))
            {
                return new GnomeMage();
            }
            else return null;
        }
    }
}
