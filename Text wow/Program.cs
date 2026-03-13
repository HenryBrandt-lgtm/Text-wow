using Text_wow.Factories;
using Text_wow.Mobs;
using Text_wow.PlayerStuff;
using Text_wow.Potions;
using Text_wow.Tools;

namespace Text_wow
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PlayerCreation playerCreation = new PlayerCreation("", "");

            playerCreation.CreateAccount();

            IPlayer player = MobFactory.CreatePlayer();
            IPotion healthPotion = ItemFactory.CreateHealthPotion();
            Smörkniv smörkniv = WeaponFactory.CreateSmörkniv();
            

            Console.WriteLine("Välkommen till text WoW!");
            player.Profile();
            Console.Clear();

            Console.WriteLine($"Välkommen {player._name} av släktet {player._race}!");
            Console.WriteLine($"Du kommer in i Azeroth med endast your {smörkniv.weaponName} som gör {smörkniv.damage}dmg.");
            Console.WriteLine($"I din bag har du 3st {healthPotion._potionType} som ger {healthPotion._healAmount}hp");
            Console.WriteLine("Lycka till!!!");
            Console.ReadKey();

            CountDown.StartCountDown();

            GamePlay gameplay = new GamePlay(player, healthPotion, smörkniv);
            gameplay.Start();

        }
    }
}
