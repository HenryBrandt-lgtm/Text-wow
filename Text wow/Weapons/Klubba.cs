namespace Text_wow.Weapons
{
    public class Klubba : IWeapon
    {
        public int damage { get; set; }
        public string weaponName { get; set; }

        public Klubba()
        {
            damage = 15;
            weaponName = "Klubba";
        }

        public void Broke(Smörkniv smöras)
        {
            IWeapon weapon = smöras;
        }

    }
}
