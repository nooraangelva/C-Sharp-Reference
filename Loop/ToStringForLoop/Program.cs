// kysyy käyttäjältä kokonaisluvun, erottaa sen yksittäiset numerot ja tulostaa ne eri riveille.
using System;

namespace Tehtava1
{
    class Program
    {
        public int Luku1 { set; get; }
        public Program()
        {
            int temp;

            Console.Write("Anna 1. luku:");
            if (int.TryParse(Console.ReadLine(), out temp))
            {
                Luku1 = temp;
            }
            else
            {
                Console.WriteLine("Anna vain kokonaislukuja!");
            }
        }
        public int pituus()
        {
            string stringi = Luku1.ToString();
            int pitka = stringi.Length;
            return pitka;
        }
        public string teksti()
        {
            string stringi2 = Luku1.ToString();
            return stringi2;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Program laskuri = new Program();
            int pituus = laskuri.pituus();
            string tekstiluku = laskuri.teksti();
            
            for (int i = 0; i < pituus; i++)
            {
                Console.WriteLine("{0}", tekstiluku[i]);
            }
            Console.ReadKey();
        }
    }

}

