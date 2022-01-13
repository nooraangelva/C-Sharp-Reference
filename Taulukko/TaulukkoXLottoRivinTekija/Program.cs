/*
2. Tee ohjelma, joka arpoo halutun määrän satunnaisia lottorivejä. 
Sama numero ei voi esiintyä kahta kertaa samassa rivissä. Voit hyödyntää ratkaisussa 
Random-luokkaa ja taulukoita.
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace Tehtava2
{
    class Program
    {
        public int rivikpl;
        int[] tauluArray;
        public Program()
        {
            int temp;
            Console.Write("Anna rivien maara:");
            if (int.TryParse(Console.ReadLine(), out temp))
            {
                rivikpl = temp;
            }
            else
            {
                Console.WriteLine("Anna vain kokonaislukuja!");
            }
        }
        public void lotto()
        {
            List<int> taulu = new List<int>();
            int temp;
            int test = 0;
            Random rnd = new Random();
            do
            {
                temp = rnd.Next(1, 40);

                if (test > Array.IndexOf(taulu.ToArray(), temp))
                {
                    taulu.Add(temp);
                }
                else
                {
                    
                }
           

            }while (taulu.Count() < 7);


            tauluArray = taulu.ToArray();
        }
        public void ulos()
        {
            Array.Sort(tauluArray);
            Console.Write("Lotto rivi :");
            foreach (int i in tauluArray)
            {
                Console.Write("{0} ", i);
            }
            Console.Write("\n");
        }
        static void Main(string[] args)
        {
            Program laskuri = new Program();
            for (int i = 0; i < laskuri.rivikpl; i++)
            {
                laskuri.lotto();
                laskuri.ulos();
            }
            
        }
    }
}