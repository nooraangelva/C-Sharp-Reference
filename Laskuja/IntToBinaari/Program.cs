// kysyy käyttäjältä kokonaisluvun ja muuntaa sen binääriluvuksi.
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
        public string Binaari()
        {
            int fromBase = 10;
            int toBase = 2;
            String result = Convert.ToString(Convert.ToInt32(Luku1.ToString(), fromBase), toBase);
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Program laskuri = new Program();

            Console.WriteLine("Luvun binaari luku on {0}", laskuri.Binaari());
            Console.ReadKey();
        }
    }

}
