/*
Lisää poikkeusten käsittely asianmukaisten virheilmoitusten kanssa ohjelmiin,
 joissa on käytetty int.Parse() tai double.Parse() -metodeja muuntamaan merkkijono 
numeeriseksi tyypiksi.
*/
using System;

namespace Tehtava1
{
    class Program
    {
        public int Luku1 { set; get; }
        public Program()
        {
            
            
            
            Console.Write("Anna 1. luku:");
            try
            {

                int result = Int32.Parse(Console.ReadLine());
                Console.WriteLine(result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Unable to parse");
            }


        }

        static void Main(string[] args)
        {

            Program laskuri = new Program();

            Console.ReadKey();
        }
    }
}
