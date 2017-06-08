using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasyvaiUzduotis6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rasti trimestro vidurki:");
            Console.WriteLine();


            Console.Write("Iveskite kiek bus pazymiu: ");
            int sk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite viso {0} pazymiu:", sk);
            int [] pazymiai = Array.ConvertAll(Console.ReadLine().Split(' ') , Int32.Parse);
            int pazymiuSuma = 0;

            for (int i = 0; i < sk; i++)
            {
                pazymiuSuma += pazymiai[i];
            }
            double vidurkis = (double)pazymiuSuma / sk;
            Console.WriteLine("Vidurkis: " + vidurkis);
            Console.ReadKey();
        }
    }
}
