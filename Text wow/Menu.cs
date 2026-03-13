using Text_wow.Potions;

namespace Text_wow
{
    internal class Menu
    {

        public static int ShowMenu(int left, int top, int playerHealth, IPotion potion, IWeapon weapon)
        {
            ConsoleKeyInfo key;
            int option = 1;
            bool isSelected = false;
            string color = "-> \u001b[36m";

            Console.CursorVisible = false;

            while (!isSelected)
            {
                Console.SetCursorPosition(left, top);

                Console.WriteLine($"{(option == 1 ? color : "   ")}1. \u001b[0mFörsök krypa igenom och riskera att ta skada. Ditt HP är {playerHealth}");
                Console.WriteLine($"{(option == 2 ? color : "   ")}2. \u001b[0mTa en potion. Du har {potion._amount}{potion._potionType} kvar");
                Console.WriteLine($"{(option == 3 ? color : "   ")}3. \u001b[0mSlå sönder grenarna med din {weapon.weaponName}");

                key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.DownArrow:
                        option = option == 3 ? 1 : option + 1;
                        break;

                    case ConsoleKey.UpArrow:
                        option = option == 1 ? 3 : option - 1;
                        break;

                    case ConsoleKey.Enter:
                        isSelected = true;
                        break;
                }
            }

            Console.CursorVisible = true;
            return option;
        }
    }

}
