using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGameRefactoring
{
    public class LightningCard : DamageCard
    {
        public LightningCard()
        {
            Name = "LightningCard";
            ManaCost = 50;
            Description = "Deal 50 damage to enemy.";
            BaseDamage = 50;
        }
    }
    
}
