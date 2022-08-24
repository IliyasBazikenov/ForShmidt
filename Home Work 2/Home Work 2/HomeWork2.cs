using System;

namespace Home_Work_2
{
    internal class HomeWork2
    {
        static void Main(string[] args)
        {
            //0 <= h <= 23
            //0 <= m <= 59
            //0 <= s <= 59
            int h = 0;
            int m = 1;
            int s = 0;
            int result =  h * 3600000 + m * 60000 + s * 1000;
            Console.WriteLine(result);
        }
    }
}
