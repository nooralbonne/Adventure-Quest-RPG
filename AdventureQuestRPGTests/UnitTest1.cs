using AdventureQuestRPG;
using static AdventureQuestRPG.Characters;

namespace AdventureQuestRPGTests
{
    public class UnitTest1
    {
        [Fact]
        public void ReducesHealthOfEnemy()
        {
            //arrange
            Player player = new Player("Player", 100 , 15,10);
            Monster enemy = new Noor("Enemy", 80, 10, 5);

            int newEnemyHealth = enemy.Health;
            //Act
            BattleSystem battleSystem = new BattleSystem();
            battleSystem.AttackPlayer(player, enemy);
            
            //Assert
            Assert.True(enemy.Health <  newEnemyHealth);
        }


        //=============================

       
        [Fact]
        public void AttackMonster_ShouldReducePlayerHealth()
        {
            // Arrange
            var player = new Player("TestPlayer", 100, 20, 5);
            var monster = new Noor("TestMonster", 100, 20, 5);
            var battleSystem = new BattleSystem();

            // Act
            battleSystem.AttackMonster(monster, player);

            // Assert
            int expectedHealth = 100 - (20 - 5); // Initial health minus (monster's attack power - player's defense)
            Assert.Equal(expectedHealth, player.Health);
        }

        //=============================

        [Fact]
        public void WinnerHealth()
        {
            Player player = new Player("Player", 100, 15, 10);
            Monster enemy = new Noor("Enemy", 80, 10, 5);

            //Act
            BattleSystem battleSystem = new BattleSystem();
            battleSystem.AttackPlayer(player, enemy);

            //Assert
            if (player.Health > 0 || enemy.Health >0) { 
                Assert.True(player.Health > 0);
                Assert.True(enemy.Health > 0);
            }
        }
    }
}