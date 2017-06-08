using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasyvaiUzduotis7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rasti geriausiai ir blogiausiai besimokanti pagal vidurkius:");
            Console.WriteLine();

            Program minMax = new Program();
           
            Console.WriteLine("Suveskite 10 mokiniu vidurkius:");
            double[] vidurkiai = Array.ConvertAll(Console.ReadLine().Split(' '), Double.Parse);
            

            double MaxValue = 0;
            int MaxValueIndex = 0;
            double MinValue = 0;
            int MinValueIndex = 0;

            minMax.Didziausias(vidurkiai, out MaxValue, out MaxValueIndex);
            minMax.Maziausias(vidurkiai, out MinValue, out MinValueIndex);

            Console.WriteLine("Geriausiai besimokantis yra {0} su {1} vidurkiu", MaxValueIndex, MaxValue);
            Console.WriteLine("Blogiausiai besimokantis yra {0} su {1} vidurkiu", MinValueIndex, MinValue);
            Console.ReadKey();
        }
        
    /// <summary>
    /// Paieskos funkcija didziausiai reiksmei is masyvo
    /// </summary>
    /// <param name="vidurkiai"></param>
    /// <returns></returns>
    private void Didziausias(double[] vidurkiai, out double MaxValue, out int MaxValueIndex)
    {
        MaxValue = double.MinValue;
        MaxValueIndex = -1;
        for (int i = 0; i < 10; i++)
        {
            if (vidurkiai[i] >= MaxValue)
            {
                MaxValue = vidurkiai[i];
                MaxValueIndex = i;
            }
        }
        
    }
    private void Maziausias(double[] vidurkiai, out double MinValue, out int MinValueIndex)
    {
        MinValue = int.MaxValue;
        MinValueIndex = -1;
        for (int i = 0; i < 10; i++)
        {
            if (vidurkiai[i] < MinValue)
            {
                MinValue = vidurkiai[i];
                MinValueIndex = i;
            }
        }
    }
}
}
