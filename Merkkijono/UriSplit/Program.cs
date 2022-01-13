/*
Konvertoi URL:n protokolla (scheme), 
koneen ja domainin nimi isoiksi kirjaimiksi, mutta jätä muu osa URL:sta ennalleen.
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
        public string urli;
        public Program(string teksti)
        {

            urli = teksti;

        }


        static void Main(string[] args)
        {
            Program uri = new Program("http://www.lapinamk.fi/business/news/index.html");


            int delimeter = uri.urli.IndexOf("/b");
            string split1 = (uri.urli.Substring(0,delimeter)).ToUpper();
            string split2 = uri.urli.Substring(delimeter);
            string txt = String.Concat(split1,split2);


            Console.WriteLine("Urli: {0}", txt);


        }
    }
}

