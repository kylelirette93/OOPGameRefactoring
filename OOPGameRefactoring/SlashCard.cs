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

        public override void Play(Character player, Character target)
        {
            int damage = 20;
            target.Health -= damage;
            Console.WriteLine($"{player.Name} casts Slash for {damage} damage.");
        }
    }
}
