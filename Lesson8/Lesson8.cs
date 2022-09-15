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

            Console.WriteLine("....................");

            ShowAllElementsSecondColumn(ints);

            ShowElementsSecondColumn(ints, 1);

            ReplaceElementFifthLineArray1949(ints, 2);

            ReplaceElementFifthLineArray(ints, 1, 999);

            ReplaceElementSecondColumnArray13(ints, 1);

            ReplaceElementSecondColumnArray(ints, 2, 888);

            SwapTwoElementsArray(ints, 0, 0, 2, 1);

            int[][] ints2 =
            {
                new int[] { 1, 2, 7, 12, 34 },
                new int[] { 3, 4, 6, 43, 65 },
                new int[] { 5, 8, 9, 62, 12 },
                new int[] { 6, 7, 8, 17, 75 },
                new int[] { 1, 4, 3, 55, 99, 100 },
            };
            SumLeftUpElementRightDownElement(ints2);

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
        // б) все элементы s-го столбца массива.
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

        // D1.6. Дан двумерный массив.Вывести на экран:
        // а) все элементы второго столбца массива;
        // б) все элементы m-й строки массива.
        static void ShowAllElementsSecondColumn(int[][] ints)
        {
            for (int i = 0; i < ints.Length; i++)
                Console.WriteLine(ints[i][1]);
        }

        static void ShowElementsSecondColumn(int[][] ints, int m)
        {
            for (int i = 0; i < ints[m].Length; i++)
                Console.WriteLine(ints[m][i]);
        }

        // D1.7. Составить программу:
        // а) заменяющую значение любого элемента пятой строки двумерного массива числом 1949;
        // б) заменяющую значение любого элемента пятой строки двумерного массива числом b.
        static void ReplaceElementFifthLineArray1949(int[][] ints, int a, int b = 1949)
        {
            if(ints[4].Length <= a)
            {
                Console.WriteLine("Вы ввели индекс которого нет в массиве");
                return;
            }    

            Console.WriteLine(ints[4][a] = b);
        }

        static void ReplaceElementFifthLineArray(int[][] ints, int a, int b)
        {
            if (ints[4].Length <= a)
            {
                Console.WriteLine("Вы ввели индекс которого нет в массиве");
                return;
            }

            Console.WriteLine(ints[4][a] = b);
        }

        // D1.8. Составить программу:
        // а) заменяющую значение любого элемента второго столбца двумерного массива числом 13;
        // б) заменяющую значение любого элемента двумерного массива числом b.
        static void ReplaceElementSecondColumnArray13(int[][] ints, int a, int b = 13) =>
           Console.WriteLine(ints[a][1] = b);

        static void ReplaceElementSecondColumnArray(int[][] ints, int a, int b) =>
          Console.WriteLine(ints[a][1] = b);

        // D1.9. Дан двумерный массив.Поменять местами:
        // а) элементы, расположенные в правом верхнем и левом нижнем углах;
        // б) элементы, расположенные в правом нижнем и левом верхнем углах.
        static void SwapRightUpElementAndLeftDownElement(int[][] ints)
        {
            int buff = ints[0][ints[0].Length - 1];
            ints[0][ints[0].Length - 1] = ints[ints.Length - 1][0];
            ints[ints.Length - 1][0] = buff;
        }
        static void SwapRightDownElementAndLeftUpElement(int[][] ints)
        {
            int buff = ints[ints.Length - 1][ints[0].Length - 1];
            ints[ints.Length - 1][ints[0].Length - 1] = ints[0][0];
            ints[0][0] = buff;
        }

        // D1.10. Составить программу, которая меняет местами два любых элемента двумерного массива.
        static void SwapTwoElementsArray(int[][] ints, int a, int b, int c, int d)
        {
            Console.WriteLine(ints[a][b] + " " + ints[c][d]);
            int buff = ints[a][b];
            ints[a][b] = ints[c][d];
            ints[c][d] = buff;
            Console.WriteLine(ints[a][b] + " " + ints[c][d]);
        }

        // D1.11. Дан двумерный массив.Найти:
        // а) сумму элементов, расположенных в левом верхнем и правом нижнем углах;
        // б) среднее арифметическое элементов, расположенных в четырех углах.
        static void SumLeftUpElementRightDownElement(int[][] ints)
        {
            int result = ints[0][0] + ints[ints.Length-1][ints[ints.Length - 1].Length-1];
            Console.WriteLine(result);
        }
    }
}
