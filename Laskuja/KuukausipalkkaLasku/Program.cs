/*
Tee abstrakti luokka Tyontekija, jolla on attribuutit nimi ja työsuhteen alkupäivä sekä abstrakti metodi laskeKuukausiPalkka. 
Tee Tyontekijalle aliluokat Toimihenkilo ja Tehdastyontekija. Toimihenkilön palkka koostuu peruspalkasta ja bonuksesta. 
Tehdastyöntekijät ovat tuntipalkattuja, mutta palkka maksetaan kuukausittain. 

Lisää luokille tarvittavat attribuutit, rakentajametodit ja toteuta yliluokasta peritty laskeKuukausiPalkka-metodi kummassakin aliluokassa.

Tee testiluokka, jossa luot Toimihenkilo- ja Tehdastyontekija -oliota. Laske ja tulosta kaikkien työntekijöiden kuukausipalkat samassa metodissa.

Käytä päiväyksen tallentamiseen DateTime-struktuuria. 

Tämänhetkisen päiväyksen/ajan saat haettua näin:
DateTime date1 = DateTime.Now;
DateTime date2 = DateTime.UtcNow;
DateTime date3 = DateTime.Today;

*/
using System;
namespace Tehtava2
{

    public abstract class Tyontekija
    {
        public string Nimi;
        public DateTime TAlkupaiva;
        public Tyontekija()
        {
            TAlkupaiva = DateTime.Today;
         
        }

        public abstract void laskeKuukausiPalkka();

        class Toimihenkilo : Tyontekija
        {
            private double bonus;
            private double ppalkka;
            public Toimihenkilo(double t1, double t2, string t3)
            {
                bonus = t1;
                ppalkka = t2;
                Nimi = t3;

            }

            public override void laskeKuukausiPalkka()
            {
                double kkpalkka = ppalkka + bonus;
                Console.WriteLine("Toimhenkilon palkka on tässä kuussa: {0:0.00}", kkpalkka);
                Console.WriteLine("Tyontekijan nimi: {0}", Nimi);
            }
        }
        class Tehdastyontekija : Tyontekija
        {
            private double hpalkka;
            public Tehdastyontekija(double t1, string t2)
            {
                hpalkka = t1;
                Nimi = t2;
            }

            public override void laskeKuukausiPalkka()
            {
                int days = DateTime.DaysInMonth(TAlkupaiva.Year, TAlkupaiva.Month);
                double kkpalkka = 7.5 * hpalkka * (days - TAlkupaiva.Day); //viikonloppuja ei ole erotettu arkipäivistä, oletus että työskentelee täyttä päivää
                Console.WriteLine("tehdastyolaisen palkka on tässä kuussa: {0:0.00}", kkpalkka);
                Console.WriteLine("Tyontekijan nimi: {0}", Nimi);
            }
        }
        class Test
        {
            static void Main(string[] args)
            {
                Toimihenkilo T1 = new Toimihenkilo(3, 2000, "Sami");
                Tehdastyontekija T2 = new Tehdastyontekija(11, "Roosa");

                T1.laskeKuukausiPalkka();
                T2.laskeKuukausiPalkka();

            }
        }

    }
}
