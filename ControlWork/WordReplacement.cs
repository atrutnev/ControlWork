using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork
{
    class WordReplacement
    {
        internal string Replacement(string s)
        {
            int key = 2;
            string sRes = "";
            string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (s[i] == alphabet[j])
                    {
                        int x = j + key;
                        while (x >= alphabet.Length)
                        {
                            x = x - alphabet.Length;
                        }
                        sRes += alphabet[x];
                    }
                }
            }
            return sRes;
        }
    }
}
