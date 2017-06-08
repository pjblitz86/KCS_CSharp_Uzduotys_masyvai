using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasyvaiUzduotis28
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dvimaciai masyvai uzrasomi
            // int[][] labas;
            // int[,] kitas = new int [10,10];

            Console.WriteLine("Dvimatis masyvas");
            int[,] skaiciai = new int[2, 3] { { 1, 1, 5 }, 
                                              { 10, 2, 5 } };
            double[] b = new double[2]; // 2 eilutes - jau zinom
            

            for (int i = 0; i < 2; i++)
            {
                int suma = 0;
                for (int j = 0; j < 3; j++)
                {
                    suma += skaiciai[i, j];
                }
                b[i] = (double)suma / 3;
            }
           
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine("Vidurkis eilutes {0} yra {1:0.00}", i, b[i]);
            }
            Console.ReadKey();
        }
    }
}
