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
                new int[] { 1, 2, 7, 12, 34 },
                new int[] { 3, 4, 6, 43, 65 },
                new int[] { 5, 8, 9, 62, 12 },
                new int[] { 6, 7, 8, 17, 75 },
                new int[] { 1, 4, 3, 55, 99 },
            }; 
              

            ShowRightUpElement(ints);

            ShowLeftDownElement(ints);

            ShowRightDownElement(ints);

            ShowLeftUpElement(ints);

            Console.WriteLine();

            ShowRandomElementSecond(ints, 1);

            ShowRandomElementArray(ints, 0, 2);

            ShowRandomElementThirdColumn(ints, 1);

            ShowAllElementsFifthLine(ints);

            ShowAllElementsFifthColumn(ints);

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
            Console.WriteLine(ints[ints.Length - 1][0]);

        static void ShowRightDownElement(int[][] ints) =>
            Console.WriteLine(ints[ints.Length - 1][ints[0].Length - 1]);

        static void ShowLeftUpElement(int[][] ints) =>
            Console.WriteLine(ints[0][0]);

        // D1.3. Дан двумерный массив. Составить программу:
        // а) вывода на экран любого элемента второй строки массива;
        // б) вывода на экран любого элемента массива.

        static void ShowRandomElementSecond(int[][] ints, int a) =>
            Console.WriteLine(ints[1][a]);

        static void ShowRandomElementArray(int[][] ints, int a, int b) =>
            Console.WriteLine(ints[a][b]);

        // D1.4. Дан двумерный массив.Составить программу:
        // а) вывода на экран любого элемента третьего столбца массива;

        static void ShowRandomElementThirdColumn(int[][] ints, int a) =>
            Console.WriteLine(ints[a][2]);

        // D1.5. Дан двумерный массив.Вывести на экран:
        // а) все элементы пятой строки массива;
        //б) все элементы s-го столбца массива.

        static void ShowAllElementsFifthLine(int[][] ints)
        {
            for (int i = 0; i < ints.Length; i++)
                Console.WriteLine(ints[4][i]);      
        }
        static void ShowAllElementsFifthColumn(int[][] ints)
        {
            for (int i = 0; i < ints.Length; i++)
                Console.WriteLine(ints[i][4]);
        }
    }
}
