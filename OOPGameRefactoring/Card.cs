using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGameRefactoring
{
    public abstract class Card
    {
        // Refactored to have an abstract class for all cards.
        private string name;
        public string Name { get { return name; } set { name = value; } }
        private int manaCost;
        public int ManaCost { get { return manaCost; } set { manaCost = value; } }
        private string description;
        public string Description { get { return description; } set { description = value; } }
        public bool GrantsFireBuff { get; set; }
        public bool GrantsIceShield { get; set; }

        public Card()
        {
            // Constructor each unique card class uses to set the card's properties.         
        }


        // Abstract method to override and play any card type.
        public abstract void Play(Character player, Character opponent);
    }
}
