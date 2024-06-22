using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Sword : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; set; }

        public double BlockingPower { get; set; }

        public Sword(string name)
        {
            Name = name;
            AttackDamage = 20;
            BlockingPower = 10;
        }
        public override void UseSpecialAbility()
        {
            AttackDamage *= 2;
        }
    }
}
