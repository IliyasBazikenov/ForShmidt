using System;

namespace Lesson6
{
    internal class Lesson6
    {
        static void Main(string[] args)
        {
            //Create a function with two arguments that will return an array of the first n multiples of x.
            //Assume both the given number and the number of times to count will be positive numbers greater than 0.
            //Return the results as an array or list ( depending on language ).
            //Examples: countBy(1,10)  should return  {1,2,3,4,5,6,7,8,9,10}
            //countBy(2,5)  should return {2,4,6,8,10}

            var result = SuperBetterCountBy(212312, 3);
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }

            //Write a function to split a string and convert it into an array of words.
            //"Robin Singh" ==> ["Robin", "Singh"]
            //"I love arrays they are my favorite" ==> ["I", "love", "arrays", "they", "are", "my", "favorite"]
            Console.WriteLine();
            StringToArray();


            //Complete the function which converts a binary number (given as a string) to a decimal number.
            Console.WriteLine();
            string a = "1011";

            Console.WriteLine("{0} : двоичная : {1}", a, Convert.ToInt64(a, 2));

            //Выведи нечетные элементыв массива
            int[] numbers = new int[] { 7, 2, 4, 21, 1, };

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                    Console.Write(numbers[i] + " ");

            }

            Console.WriteLine();

            //Сумма всех элементов в массиве
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
                sum = sum + numbers[i];

            Console.WriteLine(sum);
            Console.WriteLine();

            //Выведи масив в обратном порядке
            int[] numbers2 = new int[] { 1, 2, 3, 4, };
            for (int i = numbers2.Length - 1; i >= 0; i--)
                Console.Write(numbers2[i] + " ");

            Console.WriteLine();

            //Поменяй элементы в двух массивах местами
            string[] strings1 = new string[] { "Sof", "Sam", "Sed" };
            string[] strings2 = new string[] { "Ted", "Tom", "Terry" };
            string buff;

            for (int i = 0; i < strings1.Length; i++)
            {
                buff = strings1[i];
                strings1[i] = strings2[i];
                strings2[i] = buff;

            }

            for (int i = 0; i < strings1.Length; i++)
                Console.Write(strings1[i] + " ");

            Console.WriteLine();

            for (int i = 0; i < strings2.Length; i++)
                Console.Write(strings2[i] + " ");

            Console.WriteLine();


            /*
            * Задача C. Симметричная ли матрица?
            * Проверьте, является ли двумерный массив симметричным относительно главной
            * диагонали.Главная диагональ — та, которая идёт из левого верхнего угла двумерного
            * массива в правый нижний.
            * Формат входных данных
            * Программа получает на вход число n ≤ 100, являющееся числом строк и столбцов 
            * массиве.Далее во входном потоке идет n строк по n чисел, являющихся элементами
            * массива.
            * Формат выходных данных
            * Программа должна выводить слово yes для симметричного массива и слово no для
            * несимметричного.
            */

            //Не правильно! Переделать!
            int[,] symmetry = new int[17, 17]; 
            bool sym = true;
            for (int i = 0; i < symmetry.GetLength(0); i++)
            {
                for (int j = 0; j < symmetry.GetLength(0); j++)
                    if (symmetry[i, j] != symmetry[j, i])
                    {
                        sym = false;
                        break;
                    }
                if (!sym)
                    break;
            }
            if (sym)
                Console.Write("yes");
            else
                Console.Write("no");


            Console.WriteLine();

            //Написать в одном Consol.Write два предложения, и каждое с новой строки
            Console.Write($"Ilya {Environment.NewLine}Shmidt"); // Можно еще через \n\r (для виндоус), \n (для линукс) вместо Environment.NewLine

            Console.WriteLine();

            //Поменять элементы в двумерном массиве
            int[,] elements = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            int buff2;
            for (int j = 0; j < elements.GetLength(0); j++)
            {
                buff2 = elements[0, j];
                elements[0, j] = elements[1, j];
                elements[1, j] = buff2;
            }

            //напиши универсальный вариант
            Console.WriteLine(elements[0, 0] + " " + elements[0, 1] + " " + elements[0, 2]);
            Console.WriteLine(elements[1, 0] + " " + elements[1, 1] + " " + elements[1, 2]);


            //Дан целочисленный массив В[1..5, 1..5]. Напечатать его левую и правую диагональ
            int[,] cubes = new int[,] 
            { 
                { 10, 20, 30, 40, 50 }, 
                { 60, 70, 80, 90, 10 }, 
                { 11, 12, 13, 14, 15 }, 
                { 16, 17, 18, 19, 20 }, 
                { 21, 22, 23, 24, 25 } 
            };

            for (int i = 0; i < cubes.GetLength(0); i++)
                Console.Write(cubes[i, i] + " "); //Левая диагональ

            Console.WriteLine();

            for (int j = cubes.GetLength(0) - 1, i = 0; j >= 0; j--, i++)
                Console.Write(cubes[i, j] + " "); //Правая диагональ

            Console.WriteLine();

            for (int i = 0; i < cubes.GetLength(0); i++)
                Console.Write(cubes[i, cubes.GetLength(0)-1-i] + " ");//Правая диагональ

        }


        static void StringToArray()
        {
            string soursString = "I love arrays they are my favorite";
            string[] resultstring = soursString.Split(' ');
            foreach (string word in resultstring)
            {
                Console.Write(word + " ");
            }
        }

        static int[] CountBy(int x, int firstMultiplayers)
        {
            int[] result = new int[firstMultiplayers];
            firstMultiplayers = 0; // кол-во элементов в массиве, обнулил чтобы считать итерации

            for (int i = x; i < int.MaxValue; i++)
            {
                if (i % x == 0) // проверка на кратность
                {
                    result[firstMultiplayers] = i; // присваиваю кратное число элементу массива
                    firstMultiplayers++; // увеливаю на единицу индекс по которому я обращаюсь к элементам в массиве
                }
                if (firstMultiplayers == result.Length) // проверка на то что итерации равны длине массива
                    break;
            }

            return result;
        }

        static int[] BetterCountBy(int x, int firstMultiplayers)
        {
            int[] result = new int[firstMultiplayers];

            for (int i = x; i < int.MaxValue; i++)
            {
                if (i % x == 0) // проверка на кратность
                {
                    result[result.Length - firstMultiplayers] = i; // присваиваю кратное число элементу массива
                    firstMultiplayers--; // увеливаю на единицу индекс по которому я обращаюсь к элементам в массиве
                }
                if (firstMultiplayers == 0) // проверка на то что итерации равны длине массива
                    break;
            }

            return result;
        }

        static int[] SuperBetterCountBy(int x, int firstMultiplayers)
        {
            int[] result = new int[firstMultiplayers];

            for (int i = 1; i <= firstMultiplayers; i++)
            {
                result[i - 1] = i * x;
            }

            return result;

        }
    }
}
