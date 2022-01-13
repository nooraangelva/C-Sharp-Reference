/*
Selvitä itsellesi Shape (kuvio) -esimerkin toiminnallisuus.

Lisää Shape-luokalle uusi aliluokka Parallelogram (Suunnikas). Lisää tarvittavat jäsenmuuttujat. 

Tallenna sivujen välinen kulma asteina. Anna toteutukset getArea() ja getCircumference() -metodeille, jotka laskevat suunnikkaan pinta-alan ja kehän.

Suunnikkaan pinta-ala = sivu1 * sivu2 * sin(sivujen välinen kulma). 

Kun toteutat ominaisuudet, tarkasta, että sivujen pituudet ovat suurempia kuin 0 ja sivujen välinen kulma on välillä 0-90.

java.lang.Math-luokasta tarvittavat funktiot ja vakiot:
Sini-funktio: Math.Sin(kulma radiaaneina)
Pyöristys-funktio: Math.Round(luku)
Vakio pii: Math.PI

Asteet radiaaneiksi muuttava ToRadians-funktio on toteutettu Shape-luokassa.
Kaava: rad = (Math.PI / 180) * asteet.

Luo Parallelogram-tyyppinen olio Test-luokassa ja kutsu printAreaAndCircumference-metodia.

Tarvitset System.Drawing-nimiavaruuden luokkkaa Color. Lisää viite/reference nimiavaruuteen: Project->References->Add Reference...
*/
using System;
using System.ComponentModel;
using System.Drawing;

namespace Tehtava1
{
    public abstract class Shape
    {
        private static int a_numberOfShapes = 0;

        public Color ShapeColor { set; get; }

        public Shape() : this(Color.Black)
        {

        }

        public Shape(Color c)
        {
            Shape.NumberOfShapes++;
            ShapeColor = c;
        }

        public static int NumberOfShapes
        {
            get
            {
                return a_numberOfShapes;
            }
            private set
            {
                a_numberOfShapes = value;
            }
        }
        public static double ToRadians(double angle)
        {
            return (Math.PI / 180) * angle;
        }
        public abstract void GetArea();

        public abstract void GetCircumference();
        
        class Parallelogram : Shape
        {
            public double sivu1 { set; get; }
            public double sivu2 { set; get; }
            public double aste { set; get; }

            public override void GetArea()
            {
                double ala;
                double radians = ToRadians(aste);
                ala = sivu1 * sivu2 * Math.Sin(radians);
                Console.WriteLine("Ala: {0:0.00}", ala);
            }
            public override void GetCircumference()
            {
                double pituus;
                pituus = 2 * sivu1 + 2 * sivu2;
                Console.WriteLine("Pituus: {0:0.00}", pituus);
            }
            public Parallelogram()
            {
                double temp;
                Console.Write("Anna 1. sivu:");
                if (double.TryParse(Console.ReadLine(), out temp))
                {
                    if (temp > 0) { 

                        sivu1 = temp;

                        Console.Write("Anna 2. sivu:");
                        if (double.TryParse(Console.ReadLine(), out temp))
                        {
                            if (temp > 0) { 
                                sivu2 = temp;
                                Console.Write("Anna kulma:");
                                if (double.TryParse(Console.ReadLine(), out temp))
                                {
                                    if (temp > 0 && temp < 90) { aste = temp; }
                                    else { Console.WriteLine("Anna vain 0-90!"); }

                                }
                                else
                                {
                                    Console.WriteLine("Anna vain lukuja!");
                                }
                            }
                            else { Console.WriteLine("Anna vain positiivisia lukuja!"); }

                        }
                        else
                        {
                            Console.WriteLine("Anna vain lukuja!");
                        }
                    }
                    else { Console.WriteLine("Anna vain positiivisia lukuja!"); }
                      
                }
                else
                {
                    Console.WriteLine("Anna vain lukuja!");
                }
            }

        }
        class Test
        {
            static void Main(string[] args)
            {
                Parallelogram suunnikas = new Parallelogram();
                
                suunnikas.GetArea();
                suunnikas.GetCircumference();

            }
        }
    }
    
}

