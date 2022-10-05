using System;

namespace Lesson9
{
    internal class Lesson9
    {
        static void Main(string[] args)
        {
            //Тема
            //Передача параметров методов по ссылке (ref и out)
            string[] strArray = { "qwe", "asd" };
            PrintArray(strArray);

            Console.WriteLine("----------------");

            foreach (var item in strArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------------");

            string[] strArray2 = strArray;
            strArray2[1] = "1";

            foreach (var item in strArray)
            {
                Console.WriteLine(item);
            }

            //пример использования ref с типами данных которые передаются по значению(с помощью ref мы передаем по ссылке)
            int a = 0;
            PrintInt(a);

            Console.WriteLine(a);

            Console.WriteLine("------------------");

            int b = 0;
            PrintIntByRef(ref b);
            
            Console.WriteLine(b);

            //пример использования out с типами данных которые передаются по значению(с помощью out мы передаем по ссылке)
            //отлииче от ref в том что переменная может быть не инициализирована во время передачи, но в функци в который есть переменная out, переменная обязательна должна быть проинициализирована
            string number = Console.ReadLine();
            if(int.TryParse(number, out int c))
                Console.WriteLine(c);
            else
                Console.WriteLine("Не получилось конвертировать строку в int");

            //Потыйкася с рефом обязаиелно!
            
        }

        static void PrintArray(string[] stringArray)
        {
            foreach (var item in stringArray)
            {
                Console.WriteLine(item);
            }
            stringArray[0] = "bla";
        }

        static void PrintInt(int intNum)
        {
            Console.WriteLine(intNum);
            intNum= 10000000;
        }

        static void PrintIntByRef(ref int intNum)
        {
            Console.WriteLine(intNum);
            intNum = 10000000;
        }

        //Ругается так как переменную с ключевым словом out нужно обязательно присвоить
        //static void PrintIntByOut(out int intNum)
        //{
        //    Console.WriteLine(intNum);
        //    intNum = 10000000;
        //}
    }
}
