using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGameRefactoring
{
    public class SlashCard : DamageCard
    {
        public SlashCard()
        {
            Name = "Slash";
            ManaCost = 20;
            Description = "Deal 20 damage.";
            BaseDamage = 20;
        }
    }
}
