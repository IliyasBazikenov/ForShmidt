using System;

namespace Lesson2
{
    internal class Lesson2
    {
        static void Main(string[] args)
        {
            //Циклы:
            /*
             * Виды циклов в с# 
             * 1) for
             * 2) foreach - не будем трогать пока
             * 3) while
             * 4) do while
             */

            //Цикл for
            //for(инициализация индекса; условие; изменение индекса)
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Цикл закончен!");

            GetFactorial(17);
            GetX();
            GetFibonnachi(11);

            // Цикл while
            // while(условие)
            bool condition = true;
            while (condition)
            {
                Console.WriteLine("бесконечный цикл");
                condition = false;
            }

            int index = 0;
            while(index <= 10)
            {
                Console.WriteLine(index);
                index++;
            }

            // do while
            // do
            //{
            //} while(условие)

            int index2 = 0;
            do
            {
                Console.WriteLine(index2);
                index2++;
            }
            while (index2 > 1);

            index2 = 0;
            while(index2 > 1)
            {
                Console.WriteLine(index2);
                index2++;
            }

        }

        static void GetFactorial(int number)
        {

            long result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            Console.WriteLine(result);
        }

        static void GetX()
        {
            // x + 10 = 20 очень тупой пример
            for (int i = 0; i < 20; i++)
            {
                //continue;
                int result = i + 10;
                if(result == 20)
                {
                    Console.WriteLine($"Ураааа нашли решение х = {i}");
                    break;
                }
            }
        }

        static void GetFibonnachi(int position)
        {
            int f1, f2;
            f1 = 0; f2 = 1;
            int fsum = 0;
            if (position == 1) fsum = f1;
            else if (position == 2) fsum = f2;
            for (int i = 2; i < position; i++)
            {
                fsum = f1 + f2;
                f1 = f2;
                f2 = fsum;
            }
            Console.WriteLine(fsum);
        }
    }
}
