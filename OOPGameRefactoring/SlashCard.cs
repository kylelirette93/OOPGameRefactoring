using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGameRefactoring
{
    public class SlashCard : Card
    {
        public override void Play(Player target)
        {
            target.TakeDamage(); 
        }
    }
}
