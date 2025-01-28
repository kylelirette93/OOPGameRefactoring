﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGameRefactoring
{
    public class Player
    {
        // Encapsule fields to properties.
        
        public string Name { get; set; } // Auto-implemented in the constructor.

        // Full property implementations.
        private int health;
        public int Health
        {
            get { return Math.Min(100, health); }
            set { health = value; }
        }

        private int mana;
        public int Mana
        {
            get { return Math.Min(100, mana); }
            set { mana = value; }
        }
        private int shield;
        public int Shield
        {
            get { return shield; }
            set { shield = value; }
        }

        private bool hasFireBuff;
        public bool HasFireBuff
        {
            get { return hasFireBuff; }
            set { hasFireBuff = value; }
        }
        private bool hasIceShield;
        public bool HasIceShield
        {
            get { return hasIceShield; }
            set { hasIceShield = value; }
        }

        // Refactored to have card logic seperate from main program.
        // List of cards in players hand.
        public List<Card> Hand { get; private set; }
        // Deck of cards for the player.
        public Deck deck { get; private set; }

        // Initialize the player using a constructor.
        public Player(string name)
        {
            // Refactored to initialize player with default values
            // rather than having a bunch of field variables in main program.
            Name = name;
            Health = 100;
            Mana = 100;
            Shield = 0;
            hasFireBuff = false;
            hasIceShield = false;
            Hand = new List<Card>();
            deck = new Deck();
        }

        public void DrawCards()
        {
            // Refactored to draw cards for the player and opponent.
            while (Hand.Count < 3 && deck.Cards.Count > 0)
            {
                // Draw cards from deck and add to hand.
                Card newCard = deck.DrawCard();
                if (newCard != null) Hand.Add(newCard);        
            }
        }
    }
}
