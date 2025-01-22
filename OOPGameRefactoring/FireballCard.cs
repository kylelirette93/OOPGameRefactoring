using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGameRefactoring
{
    public class FireballCard : Card
    {
        public FireballCard()
        {
            cardName = "Fireball";
            cardCost = 30;
            damageAmount = 40;
        }
    }
}
