using System;
using System.Collections.Generic;
using System.Text;

namespace Text_wow.Mobs
{
    public class Goblin : IMonster
    {
        public string _name { get; set; }
        public int _health { get; set; } 
        public int _dmg { get; set; }

        public Goblin()
        {
            _name = "Goblin";
            _health = 30;
            _dmg = 5;
        }


        public void Death()
        {
            if (_health <= 0)
            {
                Console.WriteLine($"\nDitt slag tog {_name}s sista hp. GG EZ {_name} är död!");
                Console.WriteLine("Press anykey för att gå viadre");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
