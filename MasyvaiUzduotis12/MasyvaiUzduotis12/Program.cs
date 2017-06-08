using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasyvaiUzduotis12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rasti klases pazanguma pagal vidurkius:");
            Console.WriteLine();

            Console.Write("Iveskite kiek klaseje mokosi mokiniu: ");
            int sk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite viso {0} vidurkiu:", sk);
            double[] vidurkiai = Array.ConvertAll(Console.ReadLine().Split(' '), Double.Parse);
            double vidurkiuSuma = 0;

            for (int i = 0; i < sk; i++)
            {
                vidurkiuSuma += vidurkiai[i];
            }

            double pazangumas = (double)vidurkiuSuma / sk;
            Console.WriteLine("Klases pazangumas: {0:0.00}", pazangumas);
           
            Console.ReadKey();
        }
    }
}
