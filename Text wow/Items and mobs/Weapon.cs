using System;
using System.Collections.Generic;
using System.Text;
using Text_wow.PlayerStuff;

namespace Text_wow
{
    internal class Weapon
    {
        public string weaponName { get; set; }
        public int damage { get; set; }


        public Weapon(string name, int dmg)
        {
            weaponName = name;
            damage = dmg;
        }

        public void Attack(Monster monster, Player player)
        {
            Console.WriteLine($"You swing your {weaponName} och gör {damage} i skada!");
            monster._health -= damage;
            Console.WriteLine($"{monster._name} slår tillbaka och gör {monster._dmg}dmg");
            player._health -= monster._dmg;
            Console.WriteLine($"Monstret har nu {monster._health} HP kvar");
            Console.WriteLine($"{player._name} har nu {player._health}hp kvar");
        }
        public void WeaponBreak()
        {
            Console.WriteLine($"Your {weaponName} gick sönder!");
            weaponName = "fist";
            damage = 5;
        }
    }
}
