using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGameRefactoring
{
    public class Actor : Deck
    {
        public int Health { get; set; }
        public int Mana { get; set; }
        public int Shield { get; set; }
        public bool isTurn { get; set; }

        public Actor()
        {
            Health = 100;
            Mana = 100;
            Shield = 0;
        }

        public void PlayCard()
        {

        }
    }
}
