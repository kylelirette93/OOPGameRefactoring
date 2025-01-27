using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGameRefactoring
{
    public class Player
    {
        private int health;
        public int Health { get; set; }
        private int mana;
        public int Mana { get; set; }
        private int shield;
        public int Shield { get; set; }

        bool hasFireBuff;
        bool hasIceShield;
        public List<Card> Hand { get; private set; }

        // Initialize the player using a constructor.
        public Player()
        {
            Health = 100;
            Mana = 100;
            Shield = 0;
            hasFireBuff = false;
            hasIceShield = false;

            Hand = new List<Card>();
        }

        public void DrawCard(Deck deck)
        {
            if (deck.Cards.Count > 0)
            {
                Card drawnCard = deck.Cards[0];

                Hand.Add(drawnCard);

                deck.Cards.RemoveAt(0);
            }
            else
            {
                Console.WriteLine("Deck is empty.");
            }
        }
        
        public void PlayCard(Card card, Player target)
        {

        }

        public void UpdateBuffs()
        {

        }
    }
}
