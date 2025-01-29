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
            target.Health -= damage;
            Console.WriteLine($"{player.Name} casts Lightning for {damage} damage.");
        }
    }
    
}
