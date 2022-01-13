/*
Kirjoita ohjelma, joka yhdistää kaksi järjestettyä kokonaislukulistaa yhdeksi
 järjestetyksi kokonaislukulistaksi. Käytä ratkaisussa List-luokkaa.
*/
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Tehtava1
{
    class Program
    {
        private List<int> taulu = new List<int>();
        public void luvut(){
            int temp;
            Random rnd = new Random();

            for (int i = 0; i < 2; i++)
            {
                temp = rnd.Next(1, 40);
                taulu.Add(temp);
            }
            taulu.Sort();

        }
        public void con(List<int> t1, List<int> t2)
        {
            List<int> Luvut = new List<int>();
            t2.AddRange(t1);
            t2.Sort();
            foreach (int i in t2)
            {

                Console.WriteLine("{0}", i);
            }
     
        }
        static void Main(string[] args)
        {
            Program laskuri = new Program();
            Program lasku = new Program();
            laskuri.luvut();
            lasku.luvut();

            laskuri.con(lasku.taulu,laskuri.taulu);
            ;
        }
    }
}
