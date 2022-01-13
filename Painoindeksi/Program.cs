using System;

namespace tehtava10
{
    class Program
    {
        public double paino { set; get; }
        public double pituus { set; get; }

        public Program()
        {
            double temp;
            Console.Write("Anna paino kiloina: ");
            if (double.TryParse(Console.ReadLine(), out temp))
            {
                if (temp > 0)
                {
                    paino = temp;
                }
                else
                {
                    Console.Write("Painon pitaa olla suurempi kuin 0!");
                }
                
                Console.Write("Anna pituus metreinä: ");
                if (double.TryParse(Console.ReadLine(), out temp))
                {
                    if(temp > 0)
                    {
                        pituus = temp;
                    }
                    else
                    {
                        Console.Write("pituuden pitaa olla suurempi kuin nolla!");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Anna vain lukuja!");
                }
            }
            else
            {
                Console.WriteLine("Anna vain lukuja!");
            }
        }

        public double Painoindeksi()
        {
            return Math.Round(paino / (pituus*pituus),1);
            
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Program laskuri = new Program();

            Console.WriteLine("Painoindeksi on {0}", laskuri.Painoindeksi());
            Console.ReadKey();
        }
    }

}

