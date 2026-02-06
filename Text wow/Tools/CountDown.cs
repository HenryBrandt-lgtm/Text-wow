using System;
using System.Collections.Generic;
using System.Text;

namespace Text_wow.Tools
{
    internal class CountDown
    {
        public static void StartCountDown()
        {
            Console.Clear();
            var currentColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"'########:'########:'##::::'##:'########:'##:::::'##::'#######::'##:::::'##:
... ##..:: ##.....::. ##::'##::... ##..:: ##:'##: ##:'##.... ##: ##:'##: ##:
::: ##:::: ##::::::::. ##'##:::::: ##:::: ##: ##: ##: ##:::: ##: ##: ##: ##:
::: ##:::: ######:::::. ###::::::: ##:::: ##: ##: ##: ##:::: ##: ##: ##: ##:
::: ##:::: ##...:::::: ## ##:::::: ##:::: ##: ##: ##: ##:::: ##: ##: ##: ##:
::: ##:::: ##:::::::: ##:. ##::::: ##:::: ##: ##: ##: ##:::: ##: ##: ##: ##:
::: ##:::: ########: ##:::. ##:::: ##::::. ###. ###::. #######::. ###. ###::
:::..:::::........::..:::::..:::::..::::::...::...::::.......::::...::...:::");
            for (int i = 5; i > 0; i--)
            {
                Console.Write(i + " ");
                Thread.Sleep(750);
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
        }
    }
}
