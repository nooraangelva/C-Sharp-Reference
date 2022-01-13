/*
3. Tee ohjelma, joka tallentaa taulukkoon 
n:n opiskelijan kurssiarvosanat ja laskee sitten niiden mediaanin ja keskiarvon.

*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace Tehtava3
{
    class Program
    {
        public int okpl;
        public int[] tauluArray;
        public Program()
        {
            int temp;
            Console.Write("Anna opiskelijoiden maara:");
            if (int.TryParse(Console.ReadLine(), out temp))
            {
                okpl = temp;
            }
            else
            {
                Console.WriteLine("Anna vain kokonaislukuja!");
            }
        }
        public void arvosanat()
        {
            List<int> taulu = new List<int>();
            int temp;
           

            for (int i = 0; i<okpl; i++) 
            {

                Console.Write("Anna arvosana (0-5):");
                if (int.TryParse(Console.ReadLine(), out temp))
                {
                    if (temp < 6 && temp > -1)
                    {
                        taulu.Add(temp);
                    }
                    else
                    {
                        Console.WriteLine("Anna luku 0-5 valilta!");
                    }
                }
                else
                {
                    Console.WriteLine("Anna vain kokonaislukuja!");
                }


            } 


            tauluArray = taulu.ToArray();
        }
        public void ka()
        {
            double summa = 0;
            foreach (int i in tauluArray)
            {
                
                summa += i;
            }
            
                Console.Write("ka: {0:0.00} ", (summa/okpl));

        }
        public void mediaani()
        {
            int med;
            double i;
            int maara = tauluArray.Count();

            Array.Sort(tauluArray);

            if (maara%2 == 0)
            {
                med = maara / 2;
                i= (tauluArray[med] + tauluArray[med - 1]) / 2;
            }
            else
            {
                med = maara / 2;
                i = tauluArray[med];
            }
            Console.Write("Mediaani on {0} ", i);

        }
        static void Main(string[] args)
        {
            Program laskuri = new Program();

            laskuri.arvosanat();
            laskuri.ka();
            laskuri.mediaani();

        }
    }
}