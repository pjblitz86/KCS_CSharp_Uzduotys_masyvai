using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasyvaiUzduotis9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rasti kuriu zmoniu indeliai banke > 1000 eur");
            Console.WriteLine();
           
            Console.WriteLine("Iveskite kiek zmoniu padejo indeliu i banka, eur: ");
            int zmoniuSkaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite {0} indeliu sumas", zmoniuSkaicius);
            int[] pinigai = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            int kiekZmoniuDaugiau1000 = 0;

            for (int i = 0; i < zmoniuSkaicius; i++)
            {
                if (pinigai[i] > 1000)
                {
                    kiekZmoniuDaugiau1000++;
                }
            }
            Console.WriteLine("Zmoniu kurie padejo daugiau nei 1000 eur skaicius: " + kiekZmoniuDaugiau1000);
           

            Console.ReadKey();
        }
    }
}
