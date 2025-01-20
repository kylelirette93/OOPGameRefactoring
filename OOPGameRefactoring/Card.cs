using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGameRefactoring
{
    public abstract class Card
    {
        public string cardName { get; set; }
        public int cardCost { get; set; }

        public void DealDamage(int damage)
        {

        }

        public void GainShield(int shield)
        {

        }
    }
}
