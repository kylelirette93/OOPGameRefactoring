using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGameRefactoring
{
    public abstract class DamageCard : Card
    {
        
        // Refactored to make Fireball and Slash cards are damage cards. This avoids duplicated if/else chains.
        public override void Play(Character player, Character target)
        {
            int damage = BaseDamage;

            // Apply fire buff.
            if (player.HasFireBuff)
            {
                damage *= 2;
            }
            
            // Apply ice shield reduction.
            if (target.HasIceShield)
            {
                damage /= 2;
            }

            if (target.Shield > 0)
            {
                if (target.Shield >= damage)
                {
                    target.Shield -= damage;
                    damage = 0;
                }
                else
                {
                    damage -= target.Shield;
                    target.Shield = 0;
                }
            }
            target.Health -= damage;
            Console.WriteLine($"{player.Name} casts {Name} for {damage} damage!");
        }
    }
}

