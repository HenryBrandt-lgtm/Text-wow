using System;
using System.Collections.Generic;
using System.Text;

namespace Text_wow
{
    internal class Player
    {
        public string _name { get; set; }
        public string _race { get; set; }
        public int _health { get; set; } = 100;

        public Player(string name, string race, int health) 
        {
            _name = name;
            _race = race;
            _health = health;
        }
        

        public void Profile()
        {
            Console.Write("Ange ditt namn: ");
            _name = Console.ReadLine();
            Console.Write("Ange din ras (Människa, Elf, Dvärg): ");
            _race = Console.ReadLine();
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
