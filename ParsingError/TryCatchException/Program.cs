/*
Lisää poikkeusten käsittely tehtävään 5B2, jossa käytetään System.Uri-luokkaa URL:n
 käsittelyyn ja muokkaamiseen. Katso Uri-luokan dokumentaatiosta, 
mitä poikkeuksia käsittelyssä voi tapahtua.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava2
{
    class Program
    {
        public Uri Uri { set; get; }
     
        public Program()
        {

            Console.Write("Anna uri:");
            try
            {
                string result = Console.ReadLine();
                Uri.TryCreate(result, UriKind.Absolute, out Uri uri);
                Uri = uri;
                Console.WriteLine("{0} ",Uri);
                Console.WriteLine($"Scheme: {Uri.Scheme}");
                Console.WriteLine($"DnsSafeHost: {Uri.DnsSafeHost}");
                Console.WriteLine($"Segments: {string.Join(", ", Uri.Segments)}");
            }
            catch (UriFormatException)
            {
                Console.WriteLine("Unable to parse");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Unable to parse not a uri");
            }

        }
     

        static void Main(string[] args)
        {

            Program laskuri = new Program();
           
            Console.ReadKey();
        }
    }
}

