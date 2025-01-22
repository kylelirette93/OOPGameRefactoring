using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGameRefactoring
{
    public class UIManager
    {
        public void DisplayStats()
        {
            Console.WriteLine($"\nPlayer Health: {player.Health} | Mana: {playerMana} | Shield: {playerShield}");
            Console.WriteLine($"Enemy Health: {enemyHealth} | Mana: {enemyMana} | Shield: {enemyShield}");
        }
    }
}
