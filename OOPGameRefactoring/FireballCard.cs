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
            ManaCost = 30;
            Description = "Deals 30 damage to the opponent.";
        }

        public override void Play(Character player, Character target)
        {
            int baseDamage = 30;
            int damage = baseDamage;

            // Apply fire buff
            if (player.HasFireBuff)
            {
                damage *= 2;
            }

            // Apply ice shield reduction
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
            Console.WriteLine($"{player.Name} casts Fireball for {damage} damage!");
        }     
    }
}
