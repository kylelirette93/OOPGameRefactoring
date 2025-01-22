using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGameRefactoring
{
    public bool IsPlayer { get; set; };
    public class Program1
    {
        RunGame();
        IsPlayer = true;
        Player player = new Player();
        Enemy enemy = new Enemy();
        UIManager uiManager = new UIManager();

        Deck playerDeck = new Deck();
        Deck enemyDeck = new Deck();
        uiManager.DisplayStats();

        HandleInput();

        Console.ReadLine();          
        

        public void RunGame()
        {
            while (true)
            {

            }
        }
        public void HandleInput()
        {
            Console.Write("\n Choose a card to play (1-3) or 0 to skip.");
            string input = Console.ReadLine();
            int keyPress = Convert.ToInt32(input);

            switch (keyPress)
            {
                case 1:
                    playerDeck.PlayCard(playerDeck.hand[0]);
                    break;

                case 2:
                    PlayCard(hand[1]);
                    break;
                case 3:
                    PlayCard(hand[2]);
                    break;

            }
        }
    }
}




    

