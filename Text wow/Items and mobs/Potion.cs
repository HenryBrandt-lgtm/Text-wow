using System;
using System.Collections.Generic;
using System.Text;

namespace Text_wow
{
    internal class Potion
    {
        public int healAmount { get; set; }
        public void UsePotion(Player player)
        {
            player._health += healAmount;
            if (player._health > 100)
            {
                player._health = 100;
                Console.WriteLine($"Du kan inte gå över din max health. Ditt HP är nu {player._health}");
            }
            Console.WriteLine($"Du har blivit helad! Din nuvarande hälsa är {player._health} HP.");
        }
    }
}
