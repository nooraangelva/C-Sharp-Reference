// kysyy käyttäjältä kaksi kokonaislukua ja laskee niiden summan, 
// tulon, vaillinaisen osamäärän ja jakojäännöksen.
using System;

namespace Tehtava1
{
    class Program
    {

        public int Luku1 { set; get; }
        public int Luku2 { set; get; }

        public Program()
        {
            int temp; 

            Console.Write("Anna 1. luku:");

            if (int.TryParse(Console.ReadLine(), out temp))
            {
                Luku1 = temp;
                Console.Write("Anna 2. luku:");
                if (int.TryParse(Console.ReadLine(), out temp))
                {
                    Luku2 = temp;
                }
                else
                {
                    Console.WriteLine("Anna vain kokonaislukuja!");
                }
            }
            else
            {
                Console.WriteLine("Anna vain kokonaislukuja!");
            }
            
        }

        public int laskeSumma()
        {
            int summa = Luku1 + Luku2;
            return summa;
        }
        public int laskeTulo()
        {
            int tulo = Luku1 * Luku2;
            return tulo;
        }
        public int laskeVOsamaara()
        {
            int tulo = Luku1 / Luku2;
            return tulo;
        }
        public int laskeJakojaannos()
        {
            int tulo = Luku1 % Luku2;
            return tulo;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program laskuri = new Program ();
            
            Console.WriteLine("Lukujen summa on {0}", laskuri.laskeSumma());
            Console.WriteLine("Lukujen tulo on {0}", laskuri.laskeTulo());
            Console.WriteLine("Lukujen vaillinainen osamaara on {0}", laskuri.laskeVOsamaara());
            Console.WriteLine("Lukujen jakojaannos on {0}", laskuri.laskeJakojaannos());
            Console.ReadKey();
        }
    }

}
