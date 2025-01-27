using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGameRefactoring
{
    public class FireballCard : Card
    {
        public FireballCard()
        {
            Name = "Fireball";
            Cost = 30;
            Damage = 40;
            Shield = 0;
            Effect = $"Deals {Damage} damage.";
        }

        public override void Play(Player player, Player target)
        {
            throw new NotImplementedException();
        }
    }
}
