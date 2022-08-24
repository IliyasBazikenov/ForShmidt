using System;

namespace Lesson5
{
    internal class Lesson5
    {
        static void Main(string[] args)
        {
            // если сумма элементов массива больше чем лимит то вернуть false, если лимит больше вернуть true 
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int limit = 700;
            Console.WriteLine(CheckArraySumForLimit(numbers, limit));


            //
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
