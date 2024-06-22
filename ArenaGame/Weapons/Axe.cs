using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    class Axe : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; set; }

        public double BlockingPower { get; set; }

        public Axe(string name)
        {
            Name = name;
            AttackDamage = 18;
            BlockingPower = 4;
        }
        public override void UseSpecialAbility()
        {
            AttackDamage += 10;
        }
    }
}
