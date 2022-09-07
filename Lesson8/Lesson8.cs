using System;

namespace Lesson8
{
    internal class Lesson8
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            //D1.1. Дан двумерный массив.
            //а) Вывести на экран элемент, расположенный в правом верхнем углу массива.
            //б) Вывести на экран элемент, расположенный в левом нижнем углу массива.
            //в) Вывести на экран элемент, расположенный в правом нижнем углу массива.
            //г) Вывести на экран элемент, расположенный в левом верхнем углу массива.
            int[][] ints =
            {
                new int[] { 1, 2, 7 },
                new int[] { 3, 4, 6 },
            };
            ShowRightUpElement(ints);

            ShowLeftDownElement(ints);

            ShowRightDownElement(ints);

            ShowLeftUpElement(ints);

            // Вам будет предоставлен массив и лимит. Вы должны убедиться, что все значения в массиве ниже или равны лимит. Если они есть, верните true. В противном случае верните ложь.

            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int limit = 5;

            bool result = CompareArrayWithLimit(numbers, limit);

            Console.WriteLine(result);
        }
        static void ShowRightUpElement(int[][] ints) =>
            Console.WriteLine(ints[0][ints[0].Length - 1]);
        

        static bool CompareArrayWithLimit(int[] arrayOfInt, int limit)
        {
            for (int i = 0; i < arrayOfInt.Length; i++)
                if (arrayOfInt[i] > limit)
                    return false;

            return true;
        }

        static void ShowLeftDownElement(int[][] ints) =>
            Console.WriteLine(ints[ints.Length-1][0]);
        
        static void ShowRightDownElement(int[][] ints) =>
            Console.WriteLine(ints[ints.Length - 1][ints[0].Length - 1]);

        static void ShowLeftUpElement(int[][] ints) =>
            Console.WriteLine(ints[0][0]);
    }
}
