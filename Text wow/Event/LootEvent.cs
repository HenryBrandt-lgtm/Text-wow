using System;
using System.Collections.Generic;
using System.Text;

namespace Text_wow.Event
{
    internal class LootEvent
    {
        public void GoblinsLoot(Monster monster, Weapon weapon)
        {
            Console.WriteLine($"{monster._name} droppade en klubba med 15dmg");
            Console.WriteLine($"\nDitt tidigare vapen är {weapon.weaponName} med {weapon.damage}dmg");
            Console.WriteLine("För att plocka upp vapnet skriv \"ta upp\"");

            string pickUp = Console.ReadLine();

            if (pickUp.ToLower() == "ta upp")
            {
                weapon.weaponName = "Klubba";
                weapon.damage = 15;
                Console.WriteLine("\nDu plockar upp Klubban och utrustar den.");
            }
            else
            {
                Console.WriteLine($"Du går vidare med {weapon.weaponName}");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
