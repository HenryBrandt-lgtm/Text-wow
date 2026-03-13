using System;
using System.Collections.Generic;
using System.Text;
using Text_wow.Factories;
using Text_wow.Mobs;

namespace Text_wow.Event
{
    internal class LootEvent
    {
        public IWeapon GoblinsLoot(IMonster monster, IWeapon weapon)
        {
            IWeapon klubba = WeaponFactory.CreateKlubba();

            Console.WriteLine($"{monster._name} droppade en klubba med 15dmg");
            Console.WriteLine($"\nDitt tidigare vapen är {weapon.weaponName} med {weapon.damage}dmg");
            Console.WriteLine("För att plocka upp vapnet skriv \"ta upp\"");

            string pickUp = Console.ReadLine();

            if (pickUp.ToLower() == "ta upp")
            {
                weapon = klubba;
                Console.WriteLine($"\nDu plockar upp {weapon.weaponName} och utrustar den. Du gör nu {weapon.damage}dmg");
            }
            else
            {
                Console.WriteLine($"Du går vidare med {weapon.weaponName}");
            }
            Console.ReadKey();
            Console.Clear();
            return weapon;
        }
    }
}
