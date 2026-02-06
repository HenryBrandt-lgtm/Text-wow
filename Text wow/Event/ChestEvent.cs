using System;
using System.Collections.Generic;
using System.Text;

namespace Text_wow.Event
{
    internal class ChestEvent
    {
        public void FirstChestEvent(Weapon weapon)
        {
            string chestChoice = "";

            Console.WriteLine("Du går fram till en stängd kista, vad vill du göra?");
            while (chestChoice != "1" && chestChoice != "2")
            {
                Console.Write("\nSkriv 1 för att öppna/2 för att gå vidare: ");
                chestChoice = Console.ReadLine();

                if (chestChoice == "1")
                {
                    weapon.weaponName = "Dagger";
                    weapon.damage = 10;
                    Console.WriteLine($"\nDu öppnar kistan och hittar en dagger med {weapon.damage}dmg");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (chestChoice == "2")
                {
                    Console.WriteLine("\nDu väljer att gå vidare utan att öppna kistan.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Ogiltigt val.");
                }
            }
            Console.WriteLine("Du utforskar vidare i grottan");
            
        }
    }
}
