// 1. Muokkaa esimerkin Opintojakso-luokkaa ja OpintojaksoTesti-luokkaa seuraavasti:
// A) Lisää Opintojakso-luokalle ominaisuus opettajanNimi, joka kertoo kurssin opettajan. 
// B) OpintojaksoTesti-luokassa aseta kurssien opettajien nimet ominaisuuksia käyttämällä.
// C) Lisää Opintojakso-luokkaan toinen rakentajametodi, jolla on kurssin nimen ja laajuuden  lisäksi kolmas parametri, joka kertoo kurssin opettajan. Rakentajassa alusta jäsenmuuttujat parametrina tuotuihin arvoihin.
// D) OpintojaksoTesti-luokassa luo uusi olio opintojakso3 ja anna rakentajametodin kutsussa kurssin nimeksi "Matematiikka", laajuudeksi 3 ja opettajaksi "Veikko".
// E) Muokkaa Opintojakso-luokan tulosta-metodia niin, että se tulostaa myös opettajan nimen.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opinnot
{
    public class Opintojakso
    {
        private int opintopisteet;
        public String Nimi { set; get; }
        public String opettajanNimi { set; get; }
        public Opintojakso(String n, int p, string o)
        {
            Nimi = n;
            Pisteet = p;
            opettajanNimi = o;

        }
        public int Pisteet
        {
            get
            {
                return opintopisteet;
            }

            set
            {
                if (value > 0)
                {
                    opintopisteet = value;
                }
                else
                {
                    opintopisteet = 0;
                }
            }
        }

    }
    class Opintojaksotesti
    {
        static void Main(string[] args)
        {
            Opintojakso opintojakso3 = new Opintojakso("Matikka", 3, "Veikko");
            Console.WriteLine("Opintojakso {0}", opintojakso3.Nimi);
            Console.WriteLine("Opintopisteet {0}", opintojakso3.Pisteet);
            Console.WriteLine("Opettajan nimi {0}", opintojakso3.opettajanNimi);
        }

    }
}
