using Text_wow.Mobs;
using Text_wow.PlayerStuff;

namespace Text_wow
{
    public interface IWeapon
    {
        int damage { get; set; }
        string weaponName { get; set; }
        public void Broke(Smörkniv smöras);

    }
}