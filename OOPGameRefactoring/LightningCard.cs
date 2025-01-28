using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGameRefactoring
{
    public class LightningCard : Card
    {
        public LightningCard()
        {
            Name = "LightningCard";
            ManaCost = 50;
            Description = "Deal 50 damage to enemy.";
        }

        public override void Play(Player player, Player target)
        {
            int damage = 50;
            if (player.Mana >= ManaCost)
            {
                target.Health -= 50;
                player.Mana -= ManaCost;
                Console.WriteLine($"{player.Name} casts Lightning for {damage} damage.");
            }
            else
            {
                Console.WriteLine($"{player.Name} does not have enough mana to cast Lightning.");
            }
        }
    }
    
}
