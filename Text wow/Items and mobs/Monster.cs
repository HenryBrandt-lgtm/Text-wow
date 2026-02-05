using System;
using System.Collections.Generic;
using System.Text;

namespace Text_wow
{
    internal class Monster
    {
        public string _name {  get; set; }
        public int _health { get; set; } = 30;

        public int _dmg { get; set; }

        public Monster(string name, int health, int dmg)
        {
            _name = name;
            _health = health;
            _dmg = dmg;
        }
        public Monster(int hp) 
        {
            _health = hp;
        }

        public void Death()
        {
            if (_health <= 0)
            {
                Console.WriteLine($"Ditt slag tog {_name}s sista hp. GG EZ");
            }
        }
    }
}
