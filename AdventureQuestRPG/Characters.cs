using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureQuestRPG
{
    public class Characters
    {
        public class Player
        {
            public string Name { get; set; }
            public int Health { get; set; }
            public int AttackPower { get; set; }
            public int Defense { get; set; }

            public Player(string name = "Player", int health = 80, int attackPower = 15,int defense = 5)
            {
                Name = name;
                Health = health;
                AttackPower = attackPower;
                Defense = defense;

            }
        }

        public abstract class Monster
        {
            public string Name { get; set; }
            public int Health { get; set; }
            public int AttackPower { get; set; }
            public int Defense { get; set; }

            public Monster(string name, int health, int attackPower, int defense)
            {
                Name = name;
                Health = health;
                AttackPower = attackPower;
                Defense = defense;

            }
        }

        public class Noor : Monster
        {
            public Noor(string name, int health, int attackPower, int defense)
                : base(name, health, attackPower, defense)
            {

            }
        }
    } 
}
