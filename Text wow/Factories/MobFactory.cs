using Text_wow.Mobs;
using Text_wow.PlayerStuff;
using Text_wow.Potions;
using Text_wow.Weapons;

namespace Text_wow.Factories
{
    public static class MobFactory
    {

        public static IPlayer CreatePlayer()
        {
            return new Player();
        }
        public static IMonster CreateGoblin()
        {
            return new Goblin();
        }
        
    }
}
