using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasyvaiUzduotis21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ARMSTRONGO SKAICIUS");
            Console.WriteLine("Jei 3 skaitmenu pakeltu 3iuoju laipsniu suma lygi paciam skaiciui");
            Console.WriteLine();

            int[] trizenkliaiVisi = new int[1000];
            for (int i = 100; i < 1000; i++)
            {
            // issireiskiam kiekviena 3zenklio skaitmeni
            int Skaitmuo1 = i / 100;
            int Skaitmuo2 = (i % 100) / 10;
            int Skaitmuo3 = i % 10;
            
            if (i == Math.Pow(Skaitmuo1, 3) + Math.Pow(Skaitmuo2, 3) + Math.Pow(Skaitmuo3, 3))
            {
                Console.WriteLine("{0} yra Armstrongo skaicius", i);
            }
            /*else
            {
                Console.WriteLine("Tai nera Armstrongo skaicius");
            }*/
            
            }
        Console.ReadKey();
        }
    }
    }

