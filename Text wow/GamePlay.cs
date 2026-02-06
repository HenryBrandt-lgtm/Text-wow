using System;
using System.Collections.Generic;
using System.Text;
using Text_wow.Event;
using Text_wow.PlayerStuff;

namespace Text_wow
{
    internal class GamePlay
    {
        private Player _player;
        private Monster _monster;
        private Weapon _weapon;
        private Potion _potion;

        
        public GamePlay(Player player, Monster monster, Weapon weapon, Potion potion)
        {
            _player = player;
            _monster = monster;
            _weapon = weapon;
            _potion = potion;
        }

        public void Start()
        {
            new ChestEvent().FirstChestEvent(_weapon);
            new CombatEvent().CombatEventvsGoblin(_monster, _weapon, _player);
            new LootEvent().GoblinsLoot(_monster, _weapon);
            new CombatEvent().CrawlThorughBushes(_player, _potion, _weapon);
        } 
    }
}
