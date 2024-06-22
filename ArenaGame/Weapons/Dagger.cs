using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Dagger : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; set; }

        public double BlockingPower { get; set; }

        public Dagger(string name)
        {
            Name = name;
            AttackDamage = 30;
            BlockingPower = 1;
        }

        public override void UseSpecialAbility()
        {
            BlockingPower += 6;
        }
    }
}
