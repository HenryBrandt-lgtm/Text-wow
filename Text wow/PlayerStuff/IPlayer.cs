using Text_wow.Mobs;

namespace Text_wow.PlayerStuff
{
    public interface IPlayer
    {
        int _health { get; set; }
        string _name { get; set; }
        string _race { get; set; }
        public void Attack(IMonster monster, IWeapon weapon);
        void Death();
        void Profile();
    }
}