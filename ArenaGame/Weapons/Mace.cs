using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    class Mace : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; set; }

        public double BlockingPower { get; set; }

        public Mace(string name)
        {
            Name = name;
            AttackDamage = 40;
            BlockingPower = 8;
        }
        public override void UseSpecialAbility()
        {
            AttackDamage -= 5;
            BlockingPower += 10;
        }
    }
}
