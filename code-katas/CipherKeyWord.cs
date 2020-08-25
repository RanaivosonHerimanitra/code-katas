using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace code_katas
{
    public class CipherKeyWord
    {
        private string output;
        private Dictionary<char, char> dico = new Dictionary<char, char>();
        public CipherKeyWord(string alphabet , string key)
        {
            var decode = new StringBuilder();
            foreach (var i in alphabet)
            {
                if (key.Contains(i) == false) {
                    decode.Append(i);
                }
            }
            output = key + decode.ToString();

            for(var k =0; k< alphabet.Length; k++)
            {
                dico.Add(alphabet[k], output[k]);
            }
        }

        // cipher.encode('ABCHIJ') == 'KEYABC'
        public string Encode(string str)
        {
            var encodeOutput = new StringBuilder();
            foreach (var key in str)
            {
                encodeOutput.Append(dico.GetValueOrDefault(key));
            }
            return encodeOutput.ToString();
        }

        // cipher.decode('KEYABC') == 'ABCHIJ'
        public string Decode(string str)
        {
            var decodeOutput = new StringBuilder();
            foreach (var val in str)
            {
                decodeOutput.Append(dico.FirstOrDefault(x => x.Value == val).Key);
            }
            return decodeOutput.ToString();
        }
    }
}
