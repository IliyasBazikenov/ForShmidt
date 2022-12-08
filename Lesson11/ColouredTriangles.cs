using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson11
{
    internal class ColouredTriangles
    {

        public void GetTriangle()
        {
            Console.WriteLine(GetLastColor("RRGBRGBB"));
        }

        public char GetLastColor(string firstline)
        {
            var temp = string.Empty;
                
            if (firstline.Length == 1)
            {
                return firstline[0];
            }

            for (var i = 1; i < firstline.Length; i++)
                temp += GetNextColour(firstline[i-1], firstline[i]);

            return GetLastColor(temp);
        }

        public string GetNextColour(char colorOne, char colorTwo)
        {
            switch (colorOne)
            {
                case 'R' when colorTwo == 'G':
                case 'G' when colorTwo == 'R':
                    return "B";
                case 'R' when colorTwo == 'B':
                case 'B' when colorTwo == 'R':
                    return "G";
                case 'B' when colorTwo == 'G':
                case 'G' when colorTwo == 'B':
                    return "R";
            }

            return colorOne.ToString();
        }
        
    }
}
