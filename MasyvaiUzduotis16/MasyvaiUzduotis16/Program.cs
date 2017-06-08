using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasyvaiUzduotis16
{
    class Program
    {
        private int Didziausias(int[] masyvas)
        {
            int MaxValue = int.MinValue;
            int MaxValueIndex = -1;
            for (int i = 0; i < masyvas.Length; i++)
            {
                if (masyvas[i] >= MaxValue)
                {
                    MaxValue = masyvas[i];
                    MaxValueIndex = i;
                }
            }
            return MaxValue;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Mokytoju atlyginimai");
            Console.WriteLine();

            Console.WriteLine("Iveskite 10 mokytoju atlyginimu");
            int[] atlyginimai = new int [10];
            int kiekVirs800 = 0;
            int kiekVirs600 = 0;
            int kiekVirs400 = 0; 

            for (int i = 1; i <= 10; i++)
            {
                
                Console.WriteLine("Atlyginimas "+ i + " :");
                atlyginimai[i] = Convert.ToInt32(Console.ReadLine());
                if (atlyginimai[i] >= 800)
                {
                    kiekVirs800++;
                }
                else if (atlyginimai[i] >= 600 && atlyginimai[i] < 800)
                {
                    kiekVirs600++;
                }
                else if (atlyginimai[i] >= 400 && atlyginimai[i] < 600)
                {
                    kiekVirs400++;
                }
            }

            // is 3 grupiu kuriu daugiausia?
            int[] DUGrupes = new int[3];
            DUGrupes[0] = kiekVirs800;
            DUGrupes[1] = kiekVirs600;
            DUGrupes[2] = kiekVirs400;

            Program atl = new Program();
            Console.WriteLine("Daugiausia mokytoju {0} atlyginimo grupeje", atl.Didziausias(atlyginimai));


        }
    }
}
