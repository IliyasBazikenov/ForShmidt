using System;

namespace Lesson7
{
    internal class Lesson7
    {
        static void Main(string[] args)
        {
            //функции, методы
            //основная цель функции на данный момент,
            //весь повторяющийся код убрать в отдельные блоки кода которые можно будет пере использовать в дальнейшем
            //большие куски кода дробить на маленькие для того чтобы было понятно читать код в будущем


            int[][] someDoubleArray =
            {
                new int[] { 1, 2 },
                new int[] { 3, 4 },
            };

            ShowDoubleArrayInConsole(someDoubleArray);

            int[][] someDoubleArray2 =
{
                new int[] { 5, 6, 7 },
                new int[] { 90, 4, 1 },
            };

            ShowDoubleArrayInConsole(someDoubleArray2);

            //Функции бывают двух видов, те которые возвращают значения и те которые ничего не возвращают
            int maxNumber = GetMaxNumberOfDoubleArray(someDoubleArray2);
            Console.WriteLine(maxNumber);
            Console.WriteLine(GetMaxNumberOfDoubleArray(someDoubleArray2));

            //функция которая вывод на консоль приветствие
            GetHelloToConsole();

            //не много про параметры функции
            TestMethod(1.5);
        }

        private static void GetHelloToConsole()
        {
            Console.WriteLine("Hello dear customer!!");
        }

        private static void ShowDoubleArrayInConsole(int[][] someDoubleArray)
        {
            foreach (var arr in someDoubleArray)
            {
                foreach (var item in arr)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }

        private static int GetMaxNumberOfDoubleArray(int[][] someDoubleArray)
        {
            int maxNumber = int.MinValue;
            foreach (var arr in someDoubleArray)
            {
                foreach (var item in arr)
                {
                    if(maxNumber < item)
                        maxNumber = item;
                }
            }

            return maxNumber;
        }

        private static void TestMethod(double i, int a = 2) // при указании опциональных параметров важна очередность, параметры с дефолтными значениями указываются в конце 
        {
            Console.WriteLine(i + " " + a);
        }
    }
}
