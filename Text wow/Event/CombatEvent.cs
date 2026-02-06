using System;
using System.Collections.Generic;
using System.Text;
using Text_wow.PlayerStuff;

namespace Text_wow.Event
{
    internal class CombatEvent
    {
        public void CombatEventvsGoblin(Monster monster, Weapon weapon, Player player)
        {
            Console.WriteLine("och springer in i ett monster!");
            Console.WriteLine($"Det är en {monster._name} med {monster._health}hp");


            while (player._health > 0 && monster._health > 0)
            {
                Console.WriteLine("Tryck på anykey för att attackera!");
                Console.ReadKey();
                Console.Clear();

                weapon.Attack(monster, player);
                if (player._health <= 0)
                {
                    player.Death();
                    break;
                }
                if (monster._health <= 0)
                {
                    monster.Death();
                    break;
                }

            }

        }
        public void CrawlThorughBushes(Player player, Potion potion, Weapon weapon)
        {
            int grenar = 50;
            Console.WriteLine("Dina äventyr tar dig vidare i grottan till du går runt ett hörn och plötsligt inte kommer längre.");
            Console.WriteLine("Din väg är täckt av taggiga grenar. Vad vill du göra?");

            bool stuckBehindBush = true;
            while (stuckBehindBush)
            {
                Console.WriteLine($"\n1. Försök krypa igenom och riksera att ta skada. ditt hp är ju nu {player._health}");
                Console.WriteLine($"2. Ta en potion. Du har just nu {potion._amount}{potion._potionType} kvar");
                Console.WriteLine($"3. Slå sönder grenarna med din {weapon.weaponName}");


                string playerChoice = Console.ReadLine();
                switch (playerChoice)
                {

                    case "1":
                        Console.Clear();
                        Console.WriteLine("Du kikar omkring och ser ett litet hål bland grenarna som du tror att du kan krypa igenom. " +
                            "\nDu tar ett djupt andetag och försöker krypa igenom hålet.");
                        int damage = grenar >= 50 ? 20 : grenar >= 40 ? 15 : 10;
                        player._health -= damage;
                        Console.WriteLine($"Du river dig på grenarna och tar {damage} skada. HP kvar: {player._health}");
                        Console.WriteLine("Men du kommer igenom och går vidare");
                        Console.ReadKey();
                        Console.Clear();
                        stuckBehindBush = false;
                        break;

                    case "2":
                        Console.Clear();
                        potion.UsePotion(player);
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Vad vill du göra nu?");
                        continue;
                    case "3":
                        Console.Clear();
                        if (weapon.weaponName == "fist")
                        {
                            Console.WriteLine("Du har inga vapen och dina bebishänder är för spröda för att ens försöka");
                        }
                        else
                        {
                            Console.WriteLine($"Du tar i allt du orkar och börja veva mot grenarna... Tills...");
                            Thread.Sleep(2000);
                            weapon.WeaponBreak();
                            grenar -= weapon.damage;
                            Console.WriteLine("Du hann åtminstone slå bort en del grenar...");
                            Console.WriteLine("Vad vill du göra nu?");
                        }
                        continue;
                    default:
                        Console.WriteLine("ogiltigt val");
                        break;
                }
            }
        }
    }
}

