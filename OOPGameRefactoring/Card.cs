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
        private int baseDamage;
        public int BaseDamage { get { return baseDamage; } set { baseDamage = value; } }
        public bool GrantsFireBuff { get; set; }
        public bool GrantsIceShield { get; set; }

        public Card()
        {
            // Constructor each unique card class uses to set the card's properties.         
        }


        // Abstract method to override and play any card type, choosing the player and opponent.
        public abstract void Play(Character player, Character opponent);
    }
}
