using Text_wow.Potions;

namespace Text_wow.Factories
{
    internal class ItemFactory
    {

        public static IPotion CreateHealthPotion()
        {
            return new HealthPotion();
        }
    }
}
