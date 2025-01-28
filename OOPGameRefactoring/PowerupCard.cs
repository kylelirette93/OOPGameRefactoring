using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGameRefactoring
{
    public class PowerupCard : Card
    {
        public PowerupCard()
        {
            Name = "PowerupCard";
            ManaCost = 30;
            Description = "Gain fire buff for 2 turns.";
        }

        public override void Play(Player player, Player opponent)
        {
            if (player.Mana >= ManaCost)
            {
                player.HasFireBuff = true;
                player.Mana -= ManaCost;
                Console.WriteLine($"{player.Name} gains Fire Buff");
            }
            else
            {
                Console.WriteLine($"{player.Name} does not have enough mana to cast Powerup.");
            }
        }
    }
}
