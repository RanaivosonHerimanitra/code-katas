using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace code_katas
{
    public static class RemoveVowel
    {
        public static string Disemvowel(string str)
        {
            var output = new List<char>();
            var ListOfVowels = new List<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            foreach (char c in str)
            {
                if (ListOfVowels.Contains(c) != true)
                {
                    output.Add(c);
                }
               
            }
            return string.Join("", output);
        
        }
    }
}
