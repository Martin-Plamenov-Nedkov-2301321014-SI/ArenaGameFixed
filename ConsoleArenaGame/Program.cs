using ArenaGame;
using ArenaGame.Heroes;
using ArenaGame.Weapons;

namespace ConsoleArenaGame
{
    class Program
    {
        static void ConsoleNotification(GameEngine.NotificationArgs args)
        {
            Console.WriteLine($"{args.Attacker.Name} attacked {args.Defender.Name} with {Math.Round(args.Attack,2)} and caused {Math.Round(args.Damage,2)} damage.");
            Console.WriteLine($"Attacker: {args.Attacker}");
            Console.WriteLine($"Defender: {args.Defender}");
        }
        static void Main(string[] args)
        {
            // Първа битка
            GameEngine gameEngine1 = new GameEngine()
            {
                HeroA = new Knight("Knight", 10, 20, new Sword("Sword")),
                HeroB = new Assassin("Assassin", 10, 5, new Dagger("Dagger")),
                NotificationsCallBack = ConsoleNotification
            };
            gameEngine1.ActivateSpecialAbility(gameEngine1.HeroA);
            gameEngine1.Fight();

            Console.WriteLine();
            Console.WriteLine($"And the winner is {gameEngine1.Winner}");

            // Втора битка
            Console.WriteLine();
            Console.WriteLine("Second Battle:");
            GameEngine gameEngine2 = new GameEngine()
            {
                HeroA = new Warrior("Warrior", 15, 18, new Mace("Mace")),
                HeroB = new Villain("Villain", 5, 15, new Axe("Axe")),
                NotificationsCallBack = ConsoleNotification
            };
            gameEngine2.ActivateSpecialAbility(gameEngine2.HeroB);
            gameEngine2.Fight();

            Console.WriteLine();
            Console.WriteLine($"And the winner is {gameEngine2.Winner}");
        }
    }
}