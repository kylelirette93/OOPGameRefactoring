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
            GrantsIceShield = true;
        }

        public override void Play(Player player, Player opponent)
        {
            player.Shield += 30;
            player.HasIceShield = true;
            Console.WriteLine($"{player.Name} casts Ice Shield!"); 
        }
    }
}
