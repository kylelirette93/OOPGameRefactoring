using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGameRefactoring
{
    public class HealCard : Card
    {
        public HealCard()
        {
            Name = "HealCard";
            ManaCost = 40;
            Description = "Restore 40 health.";
        }

        public override void Play(Player player, Player target)
        {
            if (player.Mana >= ManaCost)
            {
                player.Health += 40;
                player.Mana -= ManaCost;
                Console.WriteLine($"{player.Name} casts Heal and restores 40 health!");
            }
            else
            {
                Console.WriteLine($"{player.Name} does not have enough mana to cast Heal.");
            }
        }
    }
}
