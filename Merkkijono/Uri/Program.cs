/*
sovellus, joka pilkkoo URL:n osiin Esimerkiksi http://www.lapinamk.fi/business/news/index.html olisi

http            (protokolla)
www.lapinamk.fi (kone ja domain)
business	(hakemisto)
news		(hakemisto)
index.html	(tiedosto)

Hyödynnä ratkaisussa System.Uri-luokkaa.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava2
{
    class Urli
    {
        public Uri uri ;

        static void Main(string[] args)
        {
            Uri uri = new Uri("http://www.lapinamk.fi/business/news/index.html");

        Console.WriteLine($"Scheme: {uri.Scheme}");
        Console.WriteLine($"DnsSafeHost: {uri.DnsSafeHost}");
        Console.WriteLine($"Segments: {string.Join(", ", uri.Segments)}");

    }
    }
}

