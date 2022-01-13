// kysyy käyttäjältä kokonaisluvun ja tulostaa, onko luku parillinen vai pariton.
using System;

namespace Tehtava2
{
    using System;

        class Program
        {
            public int Luku1 { set; get; }
            public Program()
            {
                int temp;
                Console.Write("Anna luku:");
                if (int.TryParse(Console.ReadLine(), out temp))
                {
                Luku1 = temp;
            }
                else
                {
                    Console.WriteLine("Anna vain kokonaislukuja!");
                }
            }

            public string TarkistaLuku()
            {
            string tieto;

                if((Luku1 % 2)== 0)
            {
                tieto = "parillinen";
            }
                else
            {
                tieto = "pariton";
            }
                return tieto;
            }

            static void Main(string[] args)
            {
                Console.WriteLine("Hello!");
                Program tarkistaja = new Program();

                Console.WriteLine("Luku on {0}", tarkistaja.TarkistaLuku());
                Console.ReadKey();
            }
        }

}
