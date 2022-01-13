/*
sovellus, joka pyytää käyttäjältä kolme merkkijonoa. Tulosta merkkijonot aakkosjärjestyksessä.
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace Tehtava1
{
    class Program
    {

       public string lista1;
       public string lista2;
       public string lista3;
       
        public Program()
        {
            
           
            Console.Write("kirjoita jotain:");
            lista1 = Console.ReadLine();
            Console.Write("kirjoita jotain:");
            lista2 = Console.ReadLine();
            Console.Write("kirjoita jotain:");
            lista3 = Console.ReadLine();

        }
        public void ulos()
        {

            Console.Write("{0} \n", (String.Concat(lista1.OrderBy(c => c))));
            Console.Write("{0} \n", (String.Concat(lista2.OrderBy(c => c))));
            Console.Write("{0} \n", (String.Concat(lista3.OrderBy(c => c))));

        }
        static void Main(string[] args)
        {
            Program laskuri = new Program();
            laskuri.ulos();
        }
    }
}

