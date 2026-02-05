namespace Text_wow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string chestChoice = "";
            Weapon weapon = new Weapon("fist", 5);
            Monster monster = new Monster("Goblin", 30, 5);
            Player player = new Player("", "", 100);
            PlayerCreation PlayerCreation = new PlayerCreation("", "");
            PlayerCreation.CreateAccount();
            Console.WriteLine($"Välkommen till text WoW! \nVem är denna stolta krigare?!");
            player.Profile();
            Console.Clear();
            Console.WriteLine($"Välkommen {player._name} av släktet {player._race}!");
            Console.WriteLine($"Du kommer in i Azeroth med endast {weapon.weaponName} som gör {weapon.damage}dmg.");
            Console.WriteLine("Lycka till!!! \nPress Anykey to continue.");
            Console.ReadKey();
            CountDown.StartCountDown();

            Console.WriteLine("Du går fram till en stängd kista, vad vill du göra?");
            while (chestChoice != "1" && chestChoice != "2")
            {
                Console.Write("\nSkriv 1 för att öppna/2 för att gå vidare: ");
                chestChoice = Console.ReadLine();
                if (chestChoice == "1")
                {
                    weapon.weaponName = "Dagger";
                    weapon.damage = 10;
                    Console.WriteLine($"\nDu öppnar kistan och hittar en dagger med {weapon.damage}dmg");
                    Console.WriteLine("Tryck på anykey för att gå vidare");
                    Console.ReadKey();
                    Console.Clear();

                }
                else if (chestChoice == "2")
                {
                    Console.WriteLine("\nDu väljer att gå vidare utan att öppna kistan.");
                    Console.WriteLine("Tryck på anykey för att gå vidare");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Ogiltigt val Skriv en ny input.");
                }
            }
            Console.WriteLine("Du springer in i ett monster!");
            Console.WriteLine($"Det är en {monster._name} med {monster._health}hp");
            Console.WriteLine("\nKlicka på anykey för att attackera");
            Console.ReadKey();

            weapon.Attack(monster, player);
            while (true)
            {
                if (player._health <= 0)
                {
                    player.Death();                   
                }
                if (monster._health <= 0)
                {
                    monster.Death();
                    Console.WriteLine("\nKlicka anykey för att gå vidare");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
                Console.WriteLine("Tryck på anykey för att attackera igen!\n");
                Console.ReadKey();
                Console.Clear();
                weapon.Attack(monster, player);
            }
            
            Console.WriteLine($"{monster._name} droppade en klubba med 15dmg");
            Console.WriteLine($"\nDitt tidigare vapen är {weapon.weaponName} med {weapon.damage}dmg");
            Console.WriteLine($"För att plocka upp {weapon.weaponName} skriv \"ta upp\"");
            string pickUp = Console.ReadLine();

            if (pickUp.ToLower() == "ta upp")
            {
                weapon.damage = 15;
                weapon.weaponName = "Klubba";
                Console.WriteLine($"\nDu plockar upp {weapon.weaponName} och utrustar den.");
            }
            else
            {
                Console.WriteLine($"Du misslyckades med att ta upp vapnet och går vidare med {weapon.weaponName}");               
            }
        }
    }
}
