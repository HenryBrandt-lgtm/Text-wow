namespace Text_wow
{
    public class Smörkniv : IWeapon
    {
        public string weaponName { get; set; }
        public int damage { get; set; }

        public Smörkniv()
        {
            weaponName = "Smörkniv";
            damage = 5;
        }

        public void Broke(Smörkniv smöras)
        {
            Console.WriteLine("Smörkniven är från djupaste skogarna i dalarna och kan inte gå sönder");
        }

    }
}
