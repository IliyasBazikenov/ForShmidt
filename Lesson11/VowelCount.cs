using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson11
{
    internal class VowelCount
    {
        public static int GetVowelCount(string str)
        {
            int count = 0;
            string vowels = ("AaEeIiOoUu");

            for (int i = 0; i < str.Length; ++i)
                for (int j = 0; j < vowels.Length; ++j)
                    if (str[i] == vowels[j])
                        ++count;
            return count;
        }
    }
}
