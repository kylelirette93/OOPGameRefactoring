using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOPGameRefactoring
{
    public class Game
    {
        // Create instance of player and their deck.
        private Player player = new Player("Player");
        private Deck playerDeck = new Deck();

        // Create instance of enemy and their deck.
        private Player enemy = new Player("Enemy");
        private Deck enemyDeck = new Deck();

        // Create random instance for enemy's turn.
        Random random = new Random();

        public void StartGame()
        {
            Console.WriteLine("=== Card Battle Game ===");

            // Main game loop.
            while (player.Health > 0 && enemy.Health > 0)
            {
                // Draw hands at the start of the round.
                if (player.Hand.Count < 3) player.DrawCards();
                if (enemy.Hand.Count < 3) enemy.DrawCards();

                // Display information about the game state.
                DisplayGameState();

                // Start the player's turn.
                PlayTurn(true);

                // Check if enemy is alive.
                if (enemy.Health <= 0) break;

                // Enemy's turn.
                Console.WriteLine("\nEnemy's turn...");
                Thread.Sleep(1000);
                PlayTurn(false);

                // Check if player is alive.
                if (player.Health <= 0) break;

                // End of round effects.
                UpdateBuffs(true);
                UpdateBuffs(false);

                // Clear the console for the next round.
                Console.WriteLine("\nPress any key for next round...");
                Console.ReadKey();
                Console.Clear();
            }
            // Check if player or enemy has won.
            Console.WriteLine(player.Health <= 0 ? "You  lost!" : "You won!");
            Console.ReadKey();
        }

        private void DisplayGameState()
        {
            // Display player and enemy stats.
            Console.WriteLine($"\nPlayer Health: {player.Health} | Mana: {player.Mana} | Shield: {player.Shield}");
            Console.WriteLine($"Enemy Health: {enemy.Health} | Mana: {enemy.Mana} | Shield: {enemy.Shield}");

            // Display player's hand.
            Console.WriteLine("\nYour hand:");
            for (int i = 0; i < player.Hand.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {GetCardDescription(player.Hand[i])}");
            }
        }

        private string GetCardDescription(Card cardName)
        {
            // Iterate through the player's hand and return card info.
            foreach (Card card in player.Hand)
            {
                if (card.Name == cardName.Name)
                {
                    return $"{card.Name} - Cost: {card.ManaCost} - {card.Description}";
                }
            }
            return "No cards in hand.";
        }

        private void PlayTurn(bool isPlayer)
        {
            // Check which player's turn it is.
            var currentPlayer = isPlayer ? player : enemy;
            currentPlayer.Mana = player.Mana;
            currentPlayer.Health = player.Health;
            var hand = currentPlayer.Hand;

            if (isPlayer)
            {
                // Enter a loop to allow the player to choose a card to play.
               
                   
                    Console.Write("\nChoose a card to play (1-3) or 0 to skip: ");
                    // Check if the input is a valid choice.
                    if (!int.TryParse(Console.ReadKey(true).KeyChar.ToString(), out int choice) || choice < 0 || choice > hand.Count)
                    {
                        Console.WriteLine($" {choice} Invalid choice! Turn skipped.");
                        return;
                    }
                    Console.WriteLine(choice.ToString());
                    if (choice == 0) return;

                    // Check if the player has enough mana to play the card.
                    Card selectedCard = hand[choice - 1];
                    if (currentPlayer.Mana >= selectedCard.ManaCost)
                    {
                        // Play the card and remove it from the players hand.
                        PlayCard(selectedCard, isPlayer);
                        hand.RemoveAt(choice - 1);
                    }
                    else
                    {
                        // Display a message if the player does not have enough mana.
                        Console.WriteLine("Not enough mana to play this card. Choose another card or skip.");
                    }
                
            }
            else
            {
                // Allow the enemy to play a random card from its hand, if possible.
                int cardIndex = random.Next(hand.Count);
                Card cardToPlay = hand[cardIndex];

                // Check if enemy has enough mana to play the card.
                if (currentPlayer.Mana >= cardToPlay.ManaCost)
                {
                    // Play the card and remove it from the enemy's hand.
                    PlayCard(cardToPlay, isPlayer);
                    hand.RemoveAt(cardIndex);
                }
            }
        }

        private void PlayCard(Card card, bool isPlayer)
        {
            // Check which player is playing the card.
            // Deduct the mana cost and play the card.
            if (isPlayer)
            {
                player.Mana -= card.ManaCost;
                Console.WriteLine($"\nPlayer played {card.Name}.");
                card.Play(player, enemy);
            }
            else
            {
                enemy.Mana -= card.ManaCost;
                Console.WriteLine($"\nEnemy played {card.Name}.");
                card.Play(enemy, player);
            }
        }

        private void UpdateBuffs(bool isPlayer)
        {
            // Check if player or enemy has any buffs.
            // Update the buffs at the end of the round.
            if (isPlayer)
            {
                if (player.HasFireBuff) player.HasFireBuff = false;
                if (player.HasIceShield) player.HasIceShield = false;
                player.Mana += 20;
            }
            else
            {
                if (enemy.HasFireBuff) enemy.HasFireBuff = false;
                if (enemy.HasIceShield) enemy.HasIceShield = false;
                enemy.Mana += 20;
            }
        }
    }
}




    

