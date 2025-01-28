using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGameRefactoring
{
    public class SlashCard : Card
    {
        public SlashCard()
        {
            Name = "SlashCard";
            ManaCost = 20;
            Description = "Deal 20 damage.";
        }

        public override void Play(Player player, Player target)
        {
            int damage = 20;

            if (player.Mana >= ManaCost)
            {
                target.Health -= damage;
                player.Mana -= ManaCost;
                Console.WriteLine($"{player.Name} casts Slash for {damage} damage.");
            }
            else
            {
                Console.WriteLine($"{player.Name} does not have enough mana to cast Slash.");
            }
        }
    }
}
