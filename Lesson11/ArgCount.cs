using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Lesson11
{
    internal class ArgCount
    {
        public int GetArgCount(params object[] args)
        {
            return args.Length;
        }

        public static string Add(string a, string b) => (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString();

    }
}
