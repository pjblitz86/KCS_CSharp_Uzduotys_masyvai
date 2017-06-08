using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasyvaiUzduotis3
{
    class Program
    {
        static void Main(string[] args)
        {

            // A[i] += B[i]
            Console.WriteLine("Dvieju vienodo ilgio masyvu nariu sumavimas");
            Console.WriteLine();

            Program duMasyvai = new Program();
            duMasyvai.paklausimas("Iveskite prekiu A kiekius viena po kito iki 10 imtinai");
            int[] prekiuAKiekiai = duMasyvai.prekiuAIvedimas();
            duMasyvai.paklausimas("Iveskite prekiu B kiekius viena po kito iki 10 imtinai");
            int[] prekiuBKiekiai = duMasyvai.prekiuBIvedimas();
            int[] visoPrekiu = duMasyvai.prekiuSumavimas(prekiuAKiekiai, prekiuBKiekiai);
           
            Console.ReadKey();
        }

        private void paklausimas(string klausimas)
        {
            Console.WriteLine(klausimas);
        }
        
        private int[] prekiuAIvedimas()
        {
            int[] ivestiAKiekiai = new int[10];
            
                for (int i = 0; i < ivestiAKiekiai.Length; i++)
                {
                    ivestiAKiekiai[i] = Convert.ToInt32(Console.ReadLine());
                }
            Console.WriteLine();
            Console.WriteLine("Prekiu A kiekiai: ");
            for (int i = 0; i < ivestiAKiekiai.Length; i++)
            {
            Console.Write("{0}\t", ivestiAKiekiai[i]);
            }
            return ivestiAKiekiai;
        }

        private int[] prekiuBIvedimas()
        {
            int[] ivestiBKiekiai = new int[10];
            
                for (int i = 0; i < ivestiBKiekiai.Length; i++)
                {
                        ivestiBKiekiai[i] = Convert.ToInt32(Console.ReadLine());
                }

            Console.WriteLine("Prekiu B kiekiai:");
            for (int i = 0; i < ivestiBKiekiai.Length; i++)
            {
                Console.Write("{0}\t", ivestiBKiekiai[i]);
            }
            
            return ivestiBKiekiai;
        }

        private int[] prekiuSumavimas(int[] a, int[] b)
        {
            int[] prekiuSuma = new int[10];
            for (int i = 0; i < prekiuSuma.Length; i++)
            {
                prekiuSuma[i] = a [i] + b[i];
                
            }
            Console.WriteLine("Viso prekiu:"); 
            for (int i = 0; i < prekiuSuma.Length; i++)
            {
            Console.WriteLine("{0}  {1}", i, prekiuSuma[i]);
            }
            
            return prekiuSuma;
        }
    }
}
