using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AdventureQuestRPG.Characters;

namespace AdventureQuestRPG
{
    public class BattleSystem
    {
        public void AttackPlayer (Characters.Player player, Characters.Monster monster)
        {
            int damage = player.AttackPower - monster.Defense;
            if (damage < 0)
            {
                damage = 0;
            }

            monster.Health -= damage;
            if (monster.Health <= 0)
            {
                monster.Health = 0;
            }

            Console.WriteLine($"{player.Name} attack {monster.Name} with {damage} damage ,and Health is now {monster.Health}");
        }

        //=================================================================

         public void AttackMonster(Characters.Monster monster, Characters.Player player )
        {
            int damage = monster.AttackPower - player.Defense;
            if (damage < 0)
            {
                damage = 0;
            }

            player.Health -= damage;
            if (player.Health <= 0)
            {
                player.Health = 0;
            }

            Console.WriteLine($"{monster.Name} attack {player.Name} with {damage} damage ,and Health is now {player.Health}");
        }
    }
}
