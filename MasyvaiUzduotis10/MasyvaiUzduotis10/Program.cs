using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasyvaiUzduotis10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Studentu vidurkiai. Kiek mokosi geriau nei vidurkis?");
            Console.WriteLine();

            Console.Write("Iveskite kiek yra studentu: ");
            int sk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite viso {0} vidurkius:", sk);
            double[] vidurkiai = Array.ConvertAll(Console.ReadLine().Split(' '), Double.Parse);
            double vidurkiuSuma = 0;
            int studentuDaugiauUzVidurki = 0;

            for (int i = 0; i < sk; i++)
            {
                vidurkiuSuma += vidurkiai[i];
            }

            double grupesVidurkis = (double)vidurkiuSuma / sk;
            Console.WriteLine("Vidurkis grupes: " + grupesVidurkis);

            for (int i = 0; i < sk; i++)
            {
                double Vidurkis = grupesVidurkis;
                if (grupesVidurkis < vidurkiai[i])
                    studentuDaugiauUzVidurki++;
            }

            Console.WriteLine("Studentu skaicius, kurie turi didesni vidurki nei grupes: {0}"
                , studentuDaugiauUzVidurki);
            Console.ReadKey();
        }
    }
    }

