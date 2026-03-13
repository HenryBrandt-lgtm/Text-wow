using Text_wow.Event;
using Text_wow.Factories;
using Text_wow.Mobs;
using Text_wow.PlayerStuff;
using Text_wow.Potions;

namespace Text_wow
{
    internal class GamePlay
    {
        private IPlayer _player;
        private IMonster _goblin = MobFactory.CreateGoblin();
        private IPotion _potion;
        private Smörkniv _defultweapon;
       
        public GamePlay(IPlayer player, IPotion potion, Smörkniv smöras)
        {
            _player = player;
            _potion = potion;
            _defultweapon = smöras;
        
        }

        public void Start()
        {

            var weapon = new ChestEvent().FirstChestEvent( _defultweapon);
            new CombatEvent().CombatEventvsGoblin(_goblin, weapon, _player);
            weapon = new LootEvent().GoblinsLoot(_goblin, weapon);
            new CombatEvent().CrawlThorughBushes(_player, _potion, weapon, _defultweapon);
        }
    }
}
