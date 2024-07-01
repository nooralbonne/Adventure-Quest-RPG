namespace AdventureQuestRPG
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Characters.Player player = new Characters.Player();
                Characters.Monster enemy = new Characters.Noor("noor", 100, 10, 5);

                StartBattle(player, enemy);

                Console.WriteLine("Adventure complete!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
           
        }

        public static void StartBattle(Characters.Player player, Characters.Monster enemy)
        {
            BattleSystem battleSystem = new BattleSystem();

            while (player.Health > 0 && enemy.Health > 0)
            {
                Console.WriteLine("player's turn");
                battleSystem.AttackPlayer(player, enemy);

                if (enemy.Health <= 0)
                {
                    Console.WriteLine("player is win in this battle!!");
                    break;
                }

                Console.WriteLine("enemy's turn");
                battleSystem.AttackMonster(enemy, player );

                if (player.Health <= 0)
                {
                    Console.WriteLine("enemy is win in this battle!!");
                    break;
                }
            }
        }
    }
}
