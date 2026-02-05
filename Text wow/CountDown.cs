using System;
using System.Collections.Generic;
using System.Text;

namespace Text_wow
{
    internal class CountDown
    {
        public static void StartCountDown()
        {

            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
            Console.Clear();
        }
    }
}
