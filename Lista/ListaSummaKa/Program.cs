/*
Kirjoita ohjelma, joka lisää 25 satunnaista kokonaislukua väliltä 0-100 järjestettyyn
 listaan. Ohjelman tulee laskea lukujen (listan alkioiden) summa sekä keskiarvo 
desimaalilukuna yhden desimaalin tarkkuudella. Käytä ratkaisussa LinkedList-luokkaa.
*/
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Tehtava1
{
    class Program
    {
        private LinkedList<int> taulu = new LinkedList<int>();
        public void luvut()
        {
            int temp;
            Random rnd = new Random();

            for (int i = 0; i < 25; i++)
            {
                temp = rnd.Next(1, 100);
                taulu.AddLast(temp);
            }
            

        }
        public void con()
        {
            Console.WriteLine("summa {0}", taulu.Sum());
            Console.WriteLine("ka {0:0.0}", taulu.Average());

        }
        static void Main(string[] args)
        {
            Program laskuri = new Program();
            laskuri.luvut();
            
            laskuri.con();
            ;
        }
    }
}
