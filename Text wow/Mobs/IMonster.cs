namespace Text_wow.Mobs
{
    public interface IMonster
    {
        int _dmg { get; set; }
        int _health { get; set; }
        string _name { get; set; }

        void Death();
    }
}