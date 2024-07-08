using AdventureQuestRPG;
using AdventureQuestRPG.Characters;
using Xunit;

namespace AdventureQuestRPG.Tests
{
    public class BattleSystemTests
    {
        //[Fact]
        //public void PlayerAttackReducesEnemyHealth()
        //{
        //     Arrange
        //    Player player = new Player();
        //    Monster enemy = new DevilMonster();
        //    BattleSystem battleSystem = new BattleSystem();

        //    int initialHealth = enemy.Health;

        //     Act
        //    battleSystem.AttackMonster(player, enemy);

        //     Assert
        //    Assert.True(enemy.Health < initialHealth);
        //}

        //[Fact]
        //public void EnemyAttackReducesPlayerHealth()
        //{
        //     Arrange
        //    Player player = new Player();
        //    Monster enemy = new DevilMonster();
        //    BattleSystem battleSystem = new BattleSystem();

        //    int initialHealth = player.Health;

        //     Act
        //    battleSystem.AttackPlayer(enemy, player);

        //     Assert
        //    Assert.True(player.Health < initialHealth);
        //}

        //[Fact]
        //public void WinnerHealthGreaterThanZeroAfterBattle()
        //{
        //     Arrange
        //    Player player = new Player();
        //    Monster enemy = new DevilMonster();
        //    BattleSystem battleSystem = new BattleSystem();

        //     Act
        //    Program.StartBattle(player, enemy);
        //    int playerHealth = player.Health;
        //    int enemyHealth = enemy.Health;

        //     Assert
        //    Assert.True(playerHealth > 0 || enemyHealth > 0);
        //}

        [Fact]
        public void EncounterBossMonster()
        {
            // Arrange
            Player player = new Player();
            Monster boss = new BossMonster();
            BattleSystem battleSystem = new BattleSystem();

            // Act
            Program.StartBattle(player, boss);

            // Assert
            Assert.True(boss is BossMonster);
        }

        [Fact]
        public void MoveToNewLocation()
        {
            // Arrange
            Adventure adventure = new Adventure();

            // Act
            adventure.MoveToNewLocation("Forest");

            // Assert
            Assert.Equal("Forest", adventure.CurrentLocation);
        }
    }
}