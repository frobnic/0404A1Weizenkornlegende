using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0404A1Weizenkornlegende
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = 1; // koerne je feld
            double s = 0; // mitlaufende summe
            int i = 0;

            do
            {
                Console.WriteLine("Auf dem {0,2}. Feld liegen {1} Körner",i+1, w);
                w = w * 2;
                s = s + w;
                i++;
            } while (i < 64);

            Console.WriteLine();

            double tonnen =  s / 1000 / 1000 / 0.5;
            Console.WriteLine("Das macht etwa {0} Tonnen Getreide.", tonnen);

            Console.WriteLine();
            double stau = tonnen / 25 * 19 / 1000;
            Console.WriteLine("Der Stau wäre etwa {0:F2} km lang.", stau);

            Console.WriteLine();

        }
    }
}
