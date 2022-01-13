/*
1. A) Käytä yksiulotteista taulukkoa seuraavan ongelman ratkaisussa: 
kirjoita ohjelma, joka kysyy käyttäjältä viisi eri kokonaislukua väliltä 10-100. 
Jos annettu luku on syötetty aiemmin tai luku ei ole väliltä 10-100, 
tulosta virheilmoitus. Käytä pienintä mahdollista taulukkoa, 
mutta varaudu pahimpaan tapaukseen, jossa kaikki viisi numeroa ovat eri numeroita. 
Jokaisen luvun lukemisen jälkeen, 
tulosta täydellinen lista tähän mennessä syötetyistä uniikeista luvuista.

1. B) Muokkaa ohjelmaa niin, että luvut tulostetaan lopuksi järjestyksessä pienimmästä 
suurimpaan.

1. C) Miten voisit tehdä ohjelmasta tehokkaamman suoritusajan suhteen (hieman) 
muistinkäytön kustannuksella?
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace Tehtava1
{
    class Program
    {
        
        int[] tauluArray;
        public Program()
        {
            List<int> taulu = new List<int>();
            int temp;
            int test = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Anna luku:");
                if (int.TryParse(Console.ReadLine(), out temp))
                {
                    if (temp > 10 && temp < 100)
                    {
                        if (test > Array.IndexOf(taulu.ToArray(), temp))
                        {
                            taulu.Add(temp);
                        }
                        else
                        {
                            Console.WriteLine("luku on jo taulukossa!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("luku on vaaran kokoinen luku!");
                    }
                }
                else
                {
                    Console.WriteLine("Anna vain kokonaislukuja!");
                }
            }
            tauluArray = taulu.ToArray();

        }
        public void ulos()
        {
            Array.Sort(tauluArray);

            foreach (int i in tauluArray)
            {
                Console.Write("{0} ", i);
            }
        }
        static void Main(string[] args)
        {
            Program laskuri = new Program();
            laskuri.ulos();
        }
    }
}
/* C OSA TEHTAVAAN VASTAUS : for loop on nopeampi kuin foreach
 *  public void ulos()
        {
            Array.Sort(tauluArray);
            int maara = tauluArray.Count();
            for (int i = 0; i < maara; i++)
            {
                Console.Write("{0} ", tauluArray[i]);
            }
        }*/
