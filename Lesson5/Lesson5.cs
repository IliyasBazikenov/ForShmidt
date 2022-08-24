using System;

namespace Lesson5
{
    internal class Lesson5
    {
        static void Main(string[] args)
        {
            // Вам будет предоставлен массив и лимит. Вы должны убедиться, что все значения в массиве ниже или равны лимит. Если они есть, верните true. В противном случае верните ложь. 
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int limit = 10;
            bool GG = true;
            
            for (int i = 0; i < numbers.Length; i++) 
            {
                if (numbers[i] > limit)
                {
                    GG = false;

                    break;
                }
                
               
            }
            Console.WriteLine(GG);


            //Найти максимальное значение в массиве
            int[] values = new int[] { 2, 5, 3, 4, 1 };
            int resault = values[0];
            foreach (int value in values)
            {
                if (resault < value) 
                resault = value;

            }
            Console.WriteLine(resault);
        }     

        static bool CheckArraySumForLimit(int[] numbers, int limit)
        {
            foreach (var number in numbers)
            {
                limit -= number;
            }

            return limit > 0;
        }
    }
}
