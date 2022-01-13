/*
4. Erastotheneen seula alkulukujen etsimiseen. The Sieve of Eratosthenes:
A prime integer is any integer that can be divided evenly only 
by itself and 1. The Sieve of Eratosthenes is a method of finding prime numbers. It works as follows:
1) Create an array with all elements initialized to 1 (true). Array elements 
with prime indexes (subscripts) will remain 1. All other elements will eventually be set to zero.
2) Starting with array index 2 (index 1 must be prime), every time an array element is 
found whose value is 1, loop through the remainder of the array and set zero every 
element whose subscript is a multiple of the index for the element with value 
1. For array index 2, all elements beyond 2 in the array that are multiples of 
2 will be set to zero (indexes 4, 6, 8, 10, etc.) For array index 3, all elements 
beyond 3 in the array that are multiples of 3 will be set to zero (indexes 6, 9, 12, 15, etc.).

When the process is complete, the array elements that are still 1 indicate that 
the index is a prime number. These indexes can then be printed. 

Write a program that uses an array of 1000 elements to determine an print the 
prime numbers between 1 and 999. Ignore element 0 in the array.
*/
using System;

namespace Tehtava4
{
    public class GFG
    {

        public static void SieveOfEratosthenes(int n)
        {

            // boolean array - true kaikki eka -> falseksi jos ei primääri luku


            bool[] prime = new bool[n + 1];

            for (int i = 0; i < n; i++)
                prime[i] = true;

            for (int p = 2; p * p <= n; p++)
            {

                if (prime[p] == true)
                {

                    for (int i = p * p; i <= n; i += p)
                        prime[i] = false;
                }
            }
 
            for (int i = 2; i <= n; i++)
            {
                if (prime[i] == true)
                    Console.Write(i + " ");
            }

        }

   
        public static void Main()
        {
            int n = 999;
            Console.WriteLine("Primaariluvut:");
            SieveOfEratosthenes(n);

        }
    }
}