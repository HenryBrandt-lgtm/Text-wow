using Text_wow.PlayerStuff;

namespace Text_wow.Potions
{
    public interface IPotion
    {
        int _amount { get; set; }
        int _healAmount { get; set; }
        string _potionType { get; set; }

        void UsePotion(IPlayer player);
    }
}