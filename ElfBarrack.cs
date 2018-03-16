using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class ElfBarrack : Barrack
    {
        protected override Unit CreateUnit(string role)
        {
            if (role.Equals("Warrior"))
            {
                return new ElfWarrior();
            }
            else if (role.Equals("Archer"))
            {
                return new ElfArcher();
            }
            else if (role.Equals("Mage"))
            {
                return new ElfMage();
            }
            else return null;
        }
    }
}
