using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Symbolový_čtverec
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napište znak");
            string a = Console.ReadLine();
            Console.WriteLine("Napište počet sloupců");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Napište počet znaků v řadě");
            int c = int.Parse(Console.ReadLine());
            for (int i = 0; i < b; i++) 
            {
                Console.SetCursorPosition(50, 10 + i);
                for (int j = 0; j < c; j++)
                {
                    Console.Write("{0} ", a);
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}