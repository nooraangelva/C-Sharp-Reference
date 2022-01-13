/*
Kirjoita ohjelma, joka laskee jokaisen sanan toistumiskertojen 
lukumäärän merkkijonossa. Käytä String-luokan split-metodia pilkkomaan 
merkkijono sanoiksi. Käytä SortedDictionary-luokkaa tallentamaan eri 
sanojen esiintymiskertojen lukumäärät.
*/
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Tehtava1
{
    class Program
    {
        private SortedDictionary<int, string> taulu = new SortedDictionary<int, string>();
        public string teksti;
        public void luvut()
        {
            Console.Write("kirjoita jotain:");
            teksti = Console.ReadLine();


        }



        private int count(string avain)
        {
            string[] ar = teksti.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<int, string> d = new Dictionary<int, string>();

            for (int i = 0; i < ar.Length; i++)
                d.Add(i, ar[i]);
            return d.Where(x => x.Value == avain).ToList().Count;

            
        }
        static void Main(string[] args)
        {
            Program laskuri = new Program();
            laskuri.luvut();
            string[] ar = laskuri.teksti.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            
            foreach (String s in ar.Distinct()) {
                
                Console.Write("{0} = {1} ",s,laskuri.count(s));
            }
            
            ;
        }
    }
}
