using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasyvaiUzduotis1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Didziausio apskritimo radimas pagal ju spindulius");
            Console.WriteLine();

            Console.WriteLine("Iveskite 10 apskritimo spinduliu: ");
            double[] r = Array.ConvertAll(Console.ReadLine().Split(' '), Double.Parse);

            Program spinduliai = new Program();

            double MaxReiksme = 0;
            int MaxReiksmiuKiekis = 0;
            spinduliai.DidziausiasApskritimas(r, out MaxReiksme, out MaxReiksmiuKiekis);

            Console.WriteLine("Didziausias apskritimas yra kurio spindulys {0}, tokiu apskritimu yra {1}",
                             MaxReiksme, MaxReiksmiuKiekis);
            Console.ReadKey();
        }

        private void DidziausiasApskritimas(double[] r, out double MaxReiksme, out int MaxReiksmiuKiekis)
        {
            
            MaxReiksme = double.MinValue;
            int MaxValueIndex = -1;
            MaxReiksmiuKiekis = 1;
            for (int i = 0; i < r.Length; i++)
            {
                if (r[i] >= MaxReiksme)
                {
                    MaxReiksme = (double)r[i];
                    MaxValueIndex = i;
                }

                if (i != 0 && ((double) MaxReiksme == (double)r[i-1]))
                {
                    MaxReiksmiuKiekis++;
                }
            }
        }
    }
}
