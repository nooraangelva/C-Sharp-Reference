// Tee luokka Ympyrä, jolla on yksityinen jäsenmuuttuja sade ja sitä vastaava julkinen ominaisuus Sade. 
// (Älä käytä skandi-merkkejä tunnisteiden nimissä.) Lisää luokalle rakentametodi. 
// Tee erilliset metodit ympyrän pinta-alan ja kehän laskemiseksi. 
// Tee erillinen testiluokka, jossa luot eri säteisiä ympyröitä ja tulostat niiden kehän ja pinta-alan. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava2
{
    class Ympyra
    {
        private double sade;
        public static double vuosikorko;

        public Ympyra(double alkusade)
        {
            sade = alkusade;
        }
        public double Sade   // property
        {
            get { return sade; }   // get method
            set { sade = value; }  // set method
        }
       
        public double LaskePintaala()
        {
            double pi = 3.14;
            return (pi*sade*sade);
        }
        public double LaskeKeha()
        {
            double pi = 3.14;
            return (2 * pi * sade);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Ympyra Sade1 = new Ympyra(3355);
            Ympyra Sade2 = new Ympyra(4739);
            Console.WriteLine("Keha: {0:0.00}", Sade1.LaskeKeha());
            Console.WriteLine("Keha: {0:0.00}", Sade2.LaskeKeha());

            Sade1.Sade = 10;
            Sade2.Sade = 12;
            Console.WriteLine("Pinta-ala: {0:0.00}", Sade1.LaskePintaala());
            Console.WriteLine("Pinta-ala: {0:0.00}", Sade2.LaskePintaala());
            Console.ReadKey();
        }
    }
}
