using System;
using System.Linq;

namespace Lesson4
{
    class Lesson4
    {
        static void Main(string[] args)
        {
            // Массивы

            // JIT компиляция 
            // 1) Jit компилятор переводит наш язык в промежуточный язык Intermediate Language(IL)
            // 2) IL компилируется в какой то низкоуровненвый ассемблерный код

            int[] typicalArray = new int[] { 1, 2, 3 };

            Console.WriteLine(typicalArray[0]);

            //пустой массив
            int[] newArray = typicalArray;
            newArray[0] = 10;

            Console.WriteLine(typicalArray[0] + " " + newArray[0]);

            int someInt = 1;

            Console.WriteLine(someInt);

            int someInt2 = someInt;
            someInt = 2;
            Console.WriteLine(someInt + " " + someInt2);


            string someString = "qwe";
            string someString2 = someString;
            someString2 = someString2 + "Shmidt";
            Console.WriteLine(someString + " " + someString2);

            string[] stringArray = new string[] { "qwe", "asd", "zxc" };
            string[] stringArray2 = stringArray;
            stringArray2[0] = "1";
            Console.WriteLine(stringArray[0] + " " + stringArray2[0]);


            //Чтобы не передавать ссылку а копировать значения
            string[] stringArray3 = new string[] { "qwe", "asd", "zxc" };
            string[] stringArray4 = new string[stringArray3.Length];
            stringArray3.CopyTo(stringArray4, 0);

            stringArray3[0] = "1";
            Console.WriteLine(stringArray3[0] + " " + stringArray4[0]);


            //foreach
            foreach (string str in stringArray3)
            {
                Console.WriteLine(str);
            }

            int sum = 0;
            foreach (int number in newArray)
            {
                //Console.WriteLine(number);
                sum += number;
            }

            Console.WriteLine(sum);
            // Числа в массиве NewArray = [10, 2, 3]
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine(newArray[i]);
            }

            Console.WriteLine("Вывод массив масивов");
            int[][] arrayOfArray = new int[][]
            {
                new int[]
                {
                    1, 2, 3
                },
                new int[]
                {
                    1, 2, 3
                }
            };

            Console.WriteLine(arrayOfArray[0][0] + " " + arrayOfArray[0][1] + " " + arrayOfArray[0][2]);
            Console.WriteLine(arrayOfArray[1][0] + " " + arrayOfArray[1][1] + " " + arrayOfArray[1][2]);

            //Многомерные массивы

            //3x мерный массив
            int[,,] threeDimensionalArray = new int[,,]
            {
                { {1, 2}, {1, 3}, {1, 2} },
                { {1, 2}, {1, 3}, {1,8 } },
            };


            //Вытащить наибольшее число с массива
            int[] testArray = new int[] { -12213, -12312, -123123, -12, -1 };
            int maxNumber = int.MinValue;
            for (int i = 0; i < testArray.Length; i++)
            {
                if(maxNumber < testArray[i])
                    maxNumber = testArray[i];
            }

            Console.WriteLine(maxNumber);
        }
    }
}
