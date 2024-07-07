using System;

namespace AdventureQuestRPG.Characters
{
    public class Player : IBattleStates
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int MaxHealth { get; set; }  // i added it to restore health after each battle
        public int Defense { get; set; }
        public Inventory Inventory { get; set; } = new Inventory();

        public Player(string name = "Player", int health = 75, int attackPower = 10, int defense = 7)
        {
            Name = name;
            Health = health;
            MaxHealth = health;
            AttackPower = attackPower;
            Defense = defense;
        }

        public void UseItem(Item item)
        {
            if (item is Potion potion)
            {
                Health += potion.HealthIncrease;
                if (Health > MaxHealth)
                {
                    Health = MaxHealth;
                }
                Console.WriteLine($"{Name} used {item.Name} and increased health by {potion.HealthIncrease}.");
            }
        }
    }

    public abstract class Monster : IBattleStates
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int Defense { get; set; }

        protected Monster(string name, int health, int attackPower, int defense)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
            Defense = defense;
        }
    }

    public class BossMonster : Monster
    {
        public BossMonster(string name = "BossMonster")
           : base(name, 500, 100, 50) 
        {
            // Additional configuration specific to BossMonster if needed
            // e.g., special attacks, unique abilities
        }
    }

    public class DevilMonster : Monster
    {
        public DevilMonster() : base("DevilMonster", 30, 5, 2) { }
    }

    public class VorlaxMonster : Monster
    {
        public VorlaxMonster() : base("VorlaxMonster", 50, 10, 3) { }
    }

    //  Player(string name = "Player", int health = 75, int attackPower = 10, int defense = 7)

    public class FrankensteinMonster : Monster
    {
        public FrankensteinMonster() : base("FrankensteinMonster", 150, 25, 10) { }
    }
}