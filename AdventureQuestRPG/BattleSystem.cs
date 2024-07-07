using System;

namespace AdventureQuestRPG
{
    public class BattleSystem
    {
        private Random random = new Random();

        public void AttackPlayer(IBattleStates player, IBattleStates monster)
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

            Console.WriteLine($"{player.Name} attacks {monster.Name} with {damage} damage, and {monster.Name}'s Health is now {monster.Health}");
        }

        public void AttackMonster(IBattleStates monster, IBattleStates player)
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

            Console.WriteLine($"{monster.Name} attacks {player.Name} with {damage} damage, and {player.Name}'s Health is now {player.Health}");
        }

        public Item GenerateRandomItem()
        {
            int itemType = random.Next(0, 3);

            switch (itemType)
            {
                case 0:
                    return new Weapon("Sword", "A sharp blade that increases attack power.");
                case 1:
                    return new Armor("Shield", "A sturdy shield that increases defense.");
                case 2:
                    return new Potion("Health Potion", "A potion that restores health.", 20);
                default:
                    return null;
            }
        }
    }
}
