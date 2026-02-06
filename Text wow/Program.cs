using Text_wow.PlayerStuff;
using Text_wow.Tools;

namespace Text_wow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon = new Weapon("smörkniv", 5);
            Monster monster = new Monster("Goblin", 30, 5);
            Player player = new Player("", "", 100);
            Potion potion = new Potion("Health Potion", 20);

            PlayerCreation playerCreation = new PlayerCreation("", "");

            playerCreation.CreateAccount();

            Console.WriteLine("Välkommen till text WoW!");
            player.Profile();
            Console.Clear();

            Console.WriteLine($"Välkommen {player._name} av släktet {player._race}!");
            Console.WriteLine($"Du kommer in i Azeroth med endast your {weapon.weaponName} som gör {weapon.damage}dmg.");
            Console.WriteLine($"I din bag har du 3st {potion._potionType} som ger {potion._healAmount}hp");
            Console.WriteLine("Lycka till!!!");
            Console.ReadKey();

            CountDown.StartCountDown();

            GamePlay gameplay = new GamePlay(player, monster, weapon, potion);
            gameplay.Start();

        }
    }
}
