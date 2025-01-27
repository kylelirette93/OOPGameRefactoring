using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGameRefactoring
{
    public class Deck
    {
        public List<Card> Cards;
        Random random = new Random();

        public Deck()
        {
            Cards = new List<Card>();
            InitializeDeck();
        }

        public void InitializeDeck()
        {
            for (int i = 0; i < 5; i++) Cards.Add(new FireballCard());
            for (int i = 0; i < 5; i++) Cards.Add(new IceShieldCard());
            for (int i = 0; i < 3; i++) Cards.Add(new HealCard());
            for (int i = 0; i < 4; i++) Cards.Add(new SlashCard());
            for (int i = 0; i < 3; i++) Cards.Add(new PowerupCard());
        }
        public void Shuffle()
        {
            int n = Cards.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                Card temp = Cards[k];
                Cards[k] = Cards[n];
                Cards[n] = temp;
            }
        }

        public Card DrawCard()
        {
            if (Cards.Count > 0)
            {
                Card drawnCard = Cards[0];
                Cards.RemoveAt(0);
                return drawnCard;
            }
            else
            {
                // No more cards in the deck.
                return null;
            }
        }
    }
}
