using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLasaString2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tekst1 = "Ovo je neki tekst.";
            string tekst2 = "Ovo je nek tekst.";
            string tekst3 = "Ovo je neki tekst.";
            string tekst4 = "Ovo je neki ekst.";

            Console.WriteLine(string.Compare(tekst1,tekst2));
            if(tekst1 == tekst2)
            {
                Console.WriteLine("Tekstovi su isti");
            }
            else
            {
                Console.WriteLine("Tekstovi nisu isti");
            }
            Console.WriteLine(string.Compare(tekst1, tekst3));
            if (tekst1 == tekst3)
            {
                Console.WriteLine("Tekstovi su isti");
            }
            else
            {
                Console.WriteLine("Tekstovi nisu isti");
            }
            Console.WriteLine(string.Compare(tekst1, tekst4));
            if (tekst1 == tekst4)
            {
                Console.WriteLine("Tekstovi su isti");
            }
            else
            {
                Console.WriteLine("Tekstovi nisu isti");
            }


            Console.ReadKey();
        }
    }
}
