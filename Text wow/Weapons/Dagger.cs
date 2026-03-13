namespace Text_wow.Weapons
{
    internal class Dagger : IWeapon
    {
        public int damage { get; set; }
        public string weaponName { get; set; }

        public Dagger()
        {
            damage = 10;
            weaponName = "Dagger";
        }

        public void Broke(Smörkniv smöras)
        {
            IWeapon weapon = smöras;
        }
    }
}
