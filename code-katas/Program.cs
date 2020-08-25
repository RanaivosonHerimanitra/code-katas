using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace code_katas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * IsEmail("bavion@gmail.com");
            Console.WriteLine("chapeau".Pluralize());
            Console.WriteLine(DigitalRoot(456));
            erastotheneCrible(102);
            */
            var abc = "abcdefghijklmnopqrstuvwxyz";
            var key = "keyword";
            var cipher = new CipherKeyWord(abc, key);
            Console.WriteLine(cipher.Encode("abc"));
            Console.WriteLine(cipher.Encode("xyz"));
            Console.WriteLine(cipher.Decode("key"));
            Console.WriteLine(cipher.Decode("vxz"));
            RemoveVowel.Disemvowel("This website is for losers LOL!");
        }

        // doing some regular expression to find email for instance:
        static void IsEmail(string email)
        {
            MatchCollection mc = Regex.Matches(email, @"^a(.+)(@)(.+)");
            if (mc.Count() == 0)
            {
                Console.WriteLine("no match");
            } else
            {
                Console.WriteLine("trouvé");
            }
        }

        // code katas
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

        // to list prime less than N
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
                if (value <= N) Console.WriteLine(value);
            }
        }
    }
}
