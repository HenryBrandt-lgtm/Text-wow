
using Text_wow.Factories;

namespace Text_wow.Event
{
    internal class ChestEvent
    {
        public IWeapon FirstChestEvent(Smörkniv smöras)
        {
            string chestChoice = "";
            IWeapon dagger = WeaponFactory.CreateDagger();
            IWeapon weapon = smöras;

            Console.WriteLine("Du går fram till en stängd kista, vad vill du göra?");
            while (chestChoice != "1" && chestChoice != "2")
            {
                Console.Write("\nSkriv 1 för att öppna/2 för att gå vidare: ");
                chestChoice = Console.ReadLine();

                if (chestChoice == "1")
                {                    
                    Console.WriteLine($"\nDu öppnar kistan och hittar en dagger med {dagger.damage}dmg");
                    Console.ReadKey();
                    Console.Clear();
                    
                }
                else if (chestChoice == "2")
                {
                    Console.WriteLine("\nDu väljer att gå vidare utan att öppna kistan.");
                    Console.ReadKey();
                    Console.Clear();
                    weapon = dagger;
                    
                }
                else
                {
                    Console.WriteLine("Ogiltigt val.");
                    continue;
                }
            }
            Console.WriteLine("Du utforskar vidare i grottan");

            return weapon;
        }
    }
}
