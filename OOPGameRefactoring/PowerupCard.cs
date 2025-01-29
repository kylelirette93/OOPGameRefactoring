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
            GrantsFireBuff = true;
        }

        public override void Play(Character player, Character opponent)
        {
            player.HasFireBuff = true;
            player.Mana -= ManaCost;
            Console.WriteLine($"{player.Name} gains Fire Buff");
        }
    }
}
