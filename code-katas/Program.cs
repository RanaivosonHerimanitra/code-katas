using System;
namespace code_katas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DigitalRoot(456));
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
    }
}
