// kysyy käyttäjältä viisi kokonaislukua ja tulostaa sitten suurimman ja pienimmän.
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

        public int max()
        {
            int max = Math.Max(Luku1, Math.Max(Luku2, Math.Max(Luku3, Math.Max(Luku4, Luku5))));
            return max;
        }
        public int min()
        {
            int min = Math.Min(Luku1, Math.Min(Luku2, Math.Min(Luku3, Math.Min(Luku4, Luku5))));
            return min;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Program laskuri = new Program();

            Console.WriteLine("Pienin luku on {0}", laskuri.min());
            Console.WriteLine("Suurin luku on {0}", laskuri.max());
            Console.ReadKey();
        }
    }

}

