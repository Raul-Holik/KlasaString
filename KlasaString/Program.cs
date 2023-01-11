using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasaString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string recenica = "Danas radimo klasu String.";

            //ispis broja znakova
            Console.WriteLine("Broj znakova u recenici: {0}", recenica.Length);
            //ispis velikim i malim slovima
            Console.WriteLine("Ispis velikim slovima: {0}\nIspis malim slovima: {1}", recenica.ToUpper(), recenica.ToLower());
            //ispis određene rijeci
            Console.WriteLine(recenica.Substring(0, 5));
            Console.WriteLine(recenica.Substring(recenica.Length-5,5));
            //zamjena znakova
            Console.WriteLine(recenica.Replace("Danas", "Sutra"));
            //razdvajanje stringova
            string[]rijec=recenica.Split(' ');
            for(int i=0;i<rijec.Length;i++)
            {
                Console.WriteLine(rijec[i]);
            }
            //umetanje znakova
            Console.WriteLine(recenica.IndexOf("radimo"));
            Console.WriteLine(recenica.Insert(recenica.IndexOf("radimo"), "intenzivno "));
            Console.ReadKey();
        }
    }
}
