using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGameRefactoring
{
    public class Deck
    {
        public int DeckSize { get; set; }
        List<Card> deck = new List<Card>();
        List<Card> hand = new List<Card>();
        const int maxHandSize = 3;
        int handCount;
        Random random = new Random();

        public Deck()
        {
            DeckSize = 20;
            InitializeDeck();
        }
        public void InitializeDeck()
        {
            for (int i = 0; i < 5; i++)
            {
                deck.Add(new FireballCard());
                deck.Add(new IceShieldCard());
            }
            for (int i = 3; i < 3; i++)
            {
                deck.Add(new HealCard());
                deck.Add(new PowerupCard());
            }
            for (int i = 4; i < 4; i++)
            {
                deck.Add(new SlashCard());
            }

            ShuffleDeck(deck);
        }

        public void ShuffleDeck(List<Card> deck)
        {
            int n = deck.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                Card temp = deck[k];
                deck[k] = deck[n];
                deck[n] = temp;
            }
        }

        public void Draw()
        {
            if (handCount < maxHandSize && deck.Count > 0)
            {
                hand.Add(deck[0]);
                deck.RemoveAt(0);
            }
        }

        

        public void PlayCard(Card card)
        {
            enemy.TakeDamage(card.damageAmount);
        }
    }
}
