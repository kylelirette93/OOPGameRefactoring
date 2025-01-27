using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGameRefactoring
{
    public abstract class Card
    {
        public string Name { get; set; }
        public int Cost { get; set; }
        public int Damage { get; set; }
        public int Shield { get; set; }

        public string Effect { get; set; }


        public abstract void Play(Player player, Player target);
    }
}
