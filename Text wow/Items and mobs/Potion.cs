using System;
using System.Collections.Generic;
using System.Text;
using Text_wow.PlayerStuff;

namespace Text_wow
{
    internal class Potion
    {
        public string _potionType { get; set; }
        public int _healAmount { get; set; }

        public int _amount { get; set; }

        public Potion(string potionType, int healAmount)
        {
            _potionType = potionType;
            _healAmount = healAmount;
            _amount = 3;
        }
        public void UsePotion(Player player)
        {

            if (_amount <= 0)
            {
                Console.WriteLine("Du har inga fler potions kvar!");
                return;
            }

            player._health += _healAmount;
            if (player._health > 100)
            {
                player._health = 100;
                Console.WriteLine($"Du dricker glupskt men kan inte gå över din max health.");
            }
            _amount--;
            Console.WriteLine($"Du har blivit helad! Din nuvarande hälsa är {player._health} HP.");
            Console.WriteLine($"Du har {_amount}st {_potionType} kvar");                           
        }
    }
}
