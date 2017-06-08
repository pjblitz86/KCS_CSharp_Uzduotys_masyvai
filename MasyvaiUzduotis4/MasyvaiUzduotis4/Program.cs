using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasyvaiUzduotis4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rasti didziausia skaiciu per 2 masyvus ir ji pasalinti");
            Console.WriteLine();

            Program masyvai = new Program();
            Console.WriteLine("Iveskite 10 sveiku skaiciu i pirma masyva: ");
            int[] masyvas1 = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            Console.WriteLine("Iveskite 10 sveiku skaiciu i antra masyva: ");
            int[] masyvas2 = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);

            int didziausias1 = 0;
            int indeksas1 = 0;
            int didziausias2 = 0;
            int indeksas2 = 0;

            int[] istrinti = new int[masyvas1.Length];

            masyvai.randaMax1(masyvas1, out didziausias1, out indeksas1);
            masyvai.randaMax2(masyvas2, out didziausias2, out indeksas2);
            masyvai.istrintiDidziausia(masyvas1, masyvas2, didziausias1, didziausias2);

            Console.ReadKey();
        }
        //
        private int[] istrintiDidziausia(int[] a, int[] b, int max1, int max2)
        {
            int[] perrasomas = new int[a.Length];
            int indeksas1 = a.Length -1;
            if (max1 > max2)
            {
                int indeksas = a.Length -1;
                while (indeksas >= 0)
                {
                    if (max1 != a[indeksas])
                    {
                        perrasomas[indeksas1] = a[indeksas];
                        indeksas1--;
                    }
                    indeksas--;
                }
            }
            else
            {
                perrasomas = new int[b.Length];
                indeksas1 = b.Length - 1;
                
                    int indeksas = b.Length - 1;
                    while (indeksas >= 0)
                    {
                        if (max1 != a[indeksas])
                        {
                            perrasomas[indeksas1] = a[indeksas];
                            indeksas1--;
                        }
                        indeksas--;
                    }
            }
            return perrasomas;
        }

        private void randaMax1 (int[] a, out int didziausias1, out int indeksas1)
        {
            didziausias1 = int.MinValue;
            indeksas1 = -1;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= didziausias1)
                {
                    didziausias1 = a[i];
                    indeksas1 = i;
                    Console.WriteLine("Didziausia 1 masyvo reiksme: {0}, indeksas {1}", didziausias1, i);
                }
            }
        }
        private void randaMax2(int[] b, out int didziausias2, out int indeksas2)
        {
            didziausias2 = int.MinValue;
            indeksas2 = -1;
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] >= didziausias2)
                {
                    didziausias2 = b[i];
                    indeksas2 = i;
                    Console.WriteLine("Didziausia 2 masyvo reiksme: {0}, indeksas {1}", didziausias2, i);
                }
            }
        }
    }
}
