// kysyy käyttäjältä kokonaisluvun, joka sisältää vain nollia 
// ja ykkösiä (binääriluvun) ja tulostaa sen vastineen 10-järjestelmässä.
using System;

namespace Tehtava1
{
    class Program
    {
        public string Luku1 { set; get; }


        public Program()
        {
            int luku = 0;
            int temp;
            Console.Write("Anna 1. luku:");
            if (int.TryParse(Console.ReadLine(), out temp))
            {

                var binaari = temp.ToString();
                foreach (var c in binaari)
                {
                    if (c != '0' && c != '1')
                    {
                        luku++;
                        

                    }
                }

                if (luku !=0)
                {
                    Console.WriteLine("Ei binääri!");
                }
                else
                {
                    Luku1 = binaari;
                }


            }
           
        }
            public void Binaari()
        {
            int bin;
            bin = Convert.ToInt32(Luku1, 2);

             Console.WriteLine("binaarin luku on {0}",bin );
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Program laskuri = new Program();
            laskuri.Binaari();


            Console.ReadKey();
        }
    }

}

