//2. Tee luokka Säästötili. Käytä staattista muuttujaa vuosiKorko 
// tallentamaan vuosittainen korkoprosentti, joka on sama kaikille 
// tilin haltijoille. Säästötilillä on lisäksi yksityinen oliomuuttuja saldo, 
// joka kertoo kullakin tilillä olevan rahamäärän.
// Lisää luokalle rakentaja-metodi, joka ottaa parametrikseen tilin saldon.
// Lisää luokalle julkiset metodit asetaSaldo ja haeSaldo.
// Lisää luokalle julkinen staattinen metodi asetaVuosiKorko, jonka avulla vuosiKorolle voi antaa uuden arvon. 
// Lisää luokalle julkinen metodi laskeKuukausiKorko, joka laskee kuukauden koron: 
// saldo*vuosiKorko/12 Laske 0.00 tarkkuudella. Metodi lisää koron tilin saldoon.
// Kirjoita ohjelma, jonka avulla voit testata Säästötili-luokkaa. Luo kaksi Säästötili-oliota 
// ja aseta niille saldot 3355 ja 4739. Aseta vuosiKoroksi 2.5%. Laske sitten kuukausikorot ja tulosta 
// molempien tilien saldot.
// Vaihda vuosiKoroksi 4%, laske seuraavan kuukauden korot ja tulosta tilien saldot.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava2
{
    class Saastotili
    {
        private double saldo;
        private string haltija;
        public static double vuosikorko;

    public Saastotili(double alkusaldo, string Value)
    {
        saldo = alkusaldo;
        haltija = Value;
    }
        public double AsetaSaldo(double value)
        {
            saldo = value;
            return saldo;
        }
        public double HaeSaldo()
        {
            saldo = saldo + LaskeKuukausiKorko(saldo);
            return saldo;
        }
        public double LaskeKuukausiKorko(double value)
        {
            return value * (vuosikorko / 12);
        }
        public static void AsetaVuosiKorko(double uusikorko)
        {
            vuosikorko = uusikorko;
        }
        static void Main(string[] args)
        {
            Saastotili.AsetaVuosiKorko(2.5);
            Saastotili TilinSaldo1 = new Saastotili(3355,"ville");
            Saastotili TilinSaldo2 = new Saastotili(4739,"sanna");
            Console.WriteLine("saldo1: {0:0.00}", TilinSaldo1.HaeSaldo());
            Console.WriteLine("Saldo2: {0:0.00}", TilinSaldo2.HaeSaldo());

            Saastotili.AsetaVuosiKorko(4);
            TilinSaldo1.AsetaSaldo(3355.0);
            TilinSaldo2.AsetaSaldo(4739.0);
            Console.WriteLine("saldo1: {0:0.00} {1}", TilinSaldo1.HaeSaldo(),TilinSaldo1.haltija);
            Console.WriteLine("Saldo2: {0:0.00}  {1}", TilinSaldo2.HaeSaldo(),TilinSaldo2.haltija);
            Console.ReadKey();


        }
    }
}
