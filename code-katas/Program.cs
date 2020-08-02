using System;
using System.Collections.Generic;
using System.Linq;

namespace code_katas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DigitalRoot(456));
            erastotheneCrible(102);
        }

        static int DigitalRoot(long n)
        {
            var arrayOfDigitCharacter = n.ToString().ToCharArray();
            int total = 0;
            foreach (char element in arrayOfDigitCharacter)
            {
                total += int.Parse(element.ToString());
            }
            if (total > 9) {
                return DigitalRoot(total);
            } else {
                return total;
            }
        }

        // to find prime given max Range
        static void erastotheneCrible(int N)
        {
            int currentPrime = 2;
            List<int> primes = new List<int> { currentPrime };
            int[] intList = Enumerable.Range(3, N).ToArray();
            while (currentPrime <= N)
            {
                intList = intList.Where(value => (value % currentPrime) != 0).ToArray();
                foreach (int value in intList)
                {
                    if (value> currentPrime)
                    {
                        primes.Add(value);
                        currentPrime = value;
                        break;
                    }
                }
            }
            foreach(int value in primes)
            {
                Console.WriteLine(value);
            }
        }
    }
}
