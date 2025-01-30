using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGameRefactoring
{
    public class FireballCard : DamageCard
    {
        public FireballCard()
        {
            Name = "Fireball";
            ManaCost = 30;
            Description = "Deals 30 damage to the opponent.";
            BaseDamage = 30;
        }
    }
}
