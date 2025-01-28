using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGameRefactoring
{
    public class IceShieldCard : Card
    {
        public IceShieldCard()
        {
            Name = "IceShieldCard";
            ManaCost = 20;
            Description = "Gain 30 shield and ice protection.";
        }

        public override void Play(Player player, Player opponent)
        {
            if (player.Mana >= ManaCost)
            {
                player.Shield += 30;
                player.HasIceShield = true;
                player.Mana -= ManaCost;
                Console.WriteLine($"{player.Name} casts Ice Shield!");
            }
            else
            {
               Console.WriteLine($"{player.Name} does not have enough mana to cast Ice Shield.");
            }
        }
    }
}
