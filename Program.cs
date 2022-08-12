using System;
using System.Collections;
using System.Collections.Generic;

namespace example18._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            var rehberList = new List<Rehber>();
            while (true)
            {
                MenuHelper.Menu();
                var ınput = Console.ReadLine();
                if (ınput!="1"&&ınput!="2"&&ınput!="3"&&ınput!="4"&&ınput!="5")
                {
                    Console.WriteLine("Yanlış seçim yaptınız.");
                }
                if (ınput=="5")
                {
                    break;
                }
                MenuHelper.ReadInput(ınput, ref rehberList);
            }
            Console.WriteLine("Rehberi kapattınız.");
        } 
    }
}
