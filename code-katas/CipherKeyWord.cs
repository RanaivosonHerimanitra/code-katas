using Humanizer;
using System;
using System.Collections.Generic;
using System.Text;

namespace code_katas
{
    public class CipherKeyWord
    {
        private Dictionary<char, char> encodingDict = new Dictionary<char, char>();
        private Dictionary<char, char> decodingDict = new Dictionary<char, char>();

        public CipherKeyWord(string alphabet , string key)
        {
            encodingDict = new Dictionary<char, char>();
            decodingDict = new Dictionary<char, char>();

            for (var j = 0; j < key.Length; j++)
            {
                encodingDict.Add(alphabet[j], key[j]);
                decodingDict.Add(key[j], alphabet[j]);
            }

            for (var j = key.Length; j<alphabet.Length; j++)
            {
                encodingDict.Add(alphabet[j], alphabet[j]); ;
                decodingDict.Add(alphabet[j], alphabet[j]);
            }
        }

        // cipher.encode('ABCHIJ') == 'KEYABC'
        // take from original ALPHABET
        public string Encode(string str)
        {
            var output = new StringBuilder();
            for( var i=0; i<str.Length; i++)
            {
                output.Append(encodingDict.GetValueOrDefault(str[i]));
            }
            return output.ToString();
        }

        // cipher.decode('KEYABC') == 'ABCHIJ'
        public string Decode(string str)
        {
            var output = new StringBuilder();
            for (var i = 0; i < str.Length; i++)
            {
                output.Append(decodingDict.GetValueOrDefault(str[i]));
            }
            return output.ToString();
        }
    }
}
