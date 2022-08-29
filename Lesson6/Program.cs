using System;

namespace Lesson6
{
    internal class Program
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

            for(int i = x; i < int.MaxValue; i++)
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
                result[i-1] = i*x;
            }

            return result;
        }
    }
}
