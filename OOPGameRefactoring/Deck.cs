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
        Dictionary<string, int> deck = new Dictionary<string, int>();

        public Deck()
        {
            DeckSize = 20;
        }
        public void InitializeDeck()
        {
            deck.Add("Fireball", 5);
            deck.Add("IceShieldCard", 5);
            deck.Add("HealCard", 3);
            deck.Add("SlashCard", 4);
            deck.Add("PowerupCard", 3);
        }

        public void AddCard(string cardName, int quantity)
        {

        }
    }
}
