/*
Kirjoita ohjelma, joka pilkkoo seuraavan merkkijonon 
ja tulostaa sen sanat eri riveille: "Lukuja: yksi, (kaksi); kolme - neljä"
*/
using System;

namespace Tehtava4
{
    class Program
    {
        static void Main(string[] args)
        {
            string delimStr = " :;,()-";
            char[] delimiter = delimStr.ToCharArray();

            string words = "Lukuja: yksi, (kaksi); kolme - neljä";
            string[] split = null;
            split = words.Split(delimiter);
            foreach (string s in split)
            {
                Console.WriteLine("{0}", s);
            }
        }
    }
}
