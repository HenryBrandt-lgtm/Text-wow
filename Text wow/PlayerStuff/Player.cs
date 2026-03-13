using System;
using System.Collections.Generic;
using System.Text;
using Text_wow.Mobs;
using Text_wow.Tools;
using static System.Net.Mime.MediaTypeNames;

namespace Text_wow.PlayerStuff
{
    public class Player : IPlayer
    {
        public string _name { get; set; }
        public string _race { get; set; }
        public int _health { get; set; } = 100;



        public void Profile()
        {
            Console.Write("Ange ditt namn: ");
            _name = Console.ReadLine();
            Console.Write("Ange din ras (Människa, Elf, Dvärg): ");
            _race = Console.ReadLine();
        }
        public void Attack(IMonster monster, IWeapon weapon)
        {
            Console.WriteLine($"You swing your {weapon.weaponName} och gör {weapon.damage} i skada!");
            monster._health -= weapon.damage;
            Console.WriteLine($"{monster._name} slår tillbaka och gör {monster._dmg}dmg");
            _health -= monster._dmg;
            Console.WriteLine($"Monstret har nu {monster._health} HP kvar");
            Console.WriteLine($"{_name} har nu {_health}hp kvar");
        }
        public void Death()
        {
            if (_health <= 0)
            {
                Console.WriteLine("Du har dött! Game Over!");
                CountDown.StartCountDown();
                
            }
        }


    }
}
