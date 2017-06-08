using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasyvaiUzduotis8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rasti kiek ugiu didesni uz ugiu vidurki:");
            Console.WriteLine();


            Console.Write("Iveskite kiek bus studentu ugiu: ");
            int sk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite viso {0} ugiu, cm:", sk);
            double[] ugiai = Array.ConvertAll(Console.ReadLine().Split(' '), Double.Parse);
            double ugiuSuma = 0;
            int ugiuKiekisDaugiauUzVidurki = 0;

            for (int i = 0; i < sk; i++)
            {
                ugiuSuma += ugiai[i];
            }

            double vidurkis = (double)ugiuSuma / sk;
            Console.WriteLine("Vidurkis ugiu: " + vidurkis);
            
            for (int i = 0; i < sk; i++)
            {
                double Vidurkis = vidurkis;
                if (vidurkis < ugiai[i])
                ugiuKiekisDaugiauUzVidurki++;
            }

            Console.WriteLine("Ugiu kiekis didesnis uz vidurki: {0}", ugiuKiekisDaugiauUzVidurki);
            Console.ReadKey();
        }
    }
}
