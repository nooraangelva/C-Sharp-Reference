//kysyy käyttäjältä viisi numeroa ja tulostaa sitten, 
//kuinka monta positiivista ja negatiivista numeroa sekä nollaa annettiin.
using System;

namespace Tehtava1
{
    class Program
    {
        public int Luku1 { set; get; }
        public int Luku2 { set; get; }
        public int Luku3 { set; get; }
        public int Luku4 { set; get; }
        public int Luku5 { set; get; }

        public Program()
        {
            int temp;
            Console.Write("Anna 1. luku:");
            if (int.TryParse(Console.ReadLine(), out temp))
            {
                Luku1 = temp;
                Console.Write("Anna 2. luku:");
                if (int.TryParse(Console.ReadLine(), out temp))
                {
                    Luku2 = temp;
                    Console.Write("Anna 3. luku:");
                    if (int.TryParse(Console.ReadLine(), out temp))
                    {
                        Luku3 = temp;
                        Console.Write("Anna 4. luku:");
                        if (int.TryParse(Console.ReadLine(), out temp))
                        {
                            Luku4 = temp;
                            Console.Write("Anna 5. luku:");
                            if (int.TryParse(Console.ReadLine(), out temp))
                            {
                                Luku5 = temp;

                            }
                            else
                            {
                                Console.WriteLine("Anna vain kokonaislukuja!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Anna vain kokonaislukuja!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Anna vain kokonaislukuja!");
                    }
                }
                else
                {
                    Console.WriteLine("Anna vain kokonaislukuja!");
                }
            }
            else
            {
                Console.WriteLine("Anna vain kokonaislukuja!");
            }
        }

        public int Neg()
        {
            int neg = 0;

            if (0 > Luku1) {
                neg++;
            }
            else { }
            if (0 > Luku2) {
                neg++;
            }
            else { }
            if (0 > Luku3)
            {
                neg++;
            }
            if (0 > Luku4)
            {
                neg++;
            }
            else { }
            if (0 > Luku5)
            {
            neg++;
            }
            else { }
                        
            return neg;
        }
        public int Pos()
        {
            int pos = 0;

            if (0 < Luku1)
            {
                pos++;
            }
            else { }
            if (0 < Luku2)
            {
                pos++;
            }
            else { }
            if (0 < Luku3)
            {
                pos++;
            }
            else
            {

            }
            if (0 < Luku4)
            {
                pos++;
            }
            else
            {

            }
            if (0 < Luku5)
            {
                pos++;
            }
            else { }
                      
            return pos;
        }
        public int Nollat()
        {
            int nol = 0;

            if (0 == Luku1)
            {
                nol++;
            }
            else { }

            if (0 == Luku2)
            {
                nol++;
            }
            else { }

            if (0 == Luku3)
            {
                nol++;
            }
            else { }
            if (0 == Luku4)
            {
                nol++;
            }
            else
            {

            }
            if (0 == Luku5)
            {
                nol++;
            }
            else { }
                    
            return nol;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Program laskuri = new Program();

            Console.WriteLine("Negatiivisia lukuja on {0}", laskuri.Neg());
            Console.WriteLine("Positiivisia lukuja on {0}", laskuri.Pos());
            Console.WriteLine("Nollia on {0}", laskuri.Nollat());
            Console.ReadKey();
        }
    }

}


