using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    class Spear : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; set; }

        public double BlockingPower { get; set; }

        public Spear(string name)
        {
            Name = name;
            AttackDamage = 25;
            BlockingPower = 0;
        }
        public override void UseSpecialAbility()
        {
            BlockingPower += 3;
        }
    }
}
