using System;
using System.Collections;
using System.Collections.Generic;

namespace Test_Enumerators
{
    class Program
    {
        static void Main(string[] args)
        {
            Primes primesFrom2To1000 = new Primes(2, 100000);
            foreach (long i in primesFrom2To1000)
                Console.Write("{0} ", i);
            Console.ReadKey();
        }
    }
}
