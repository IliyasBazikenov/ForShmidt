using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Обьявить перменную
            string initString;

            //  присвоить значение
            initString = "String";

            //Инициализировать переменную
            string b = "asdasda";
             // Nen z dy`c JUHJVYST bpvtytybz <kznm
            // Примитивные типы:

            // Целочисленный тип(16bit) представляет собой тип данных в котором хранятся целые числа, максиальное число(2^16)
            short shortValue; 

            // Целочисленный тип(32bit) представляет собой тип данных в котором хранятся целые числа, максиальное число(2^32)
            int integerValue;

            //Целочисленный тип(64bit) представляет собой тип данных в котором хранятся целые числа, максиальное число(2^64)
            long longValue;

            //Символьный тип данных, 256 bit, представляет собой символ в кодировке UTF-16
            char someChar;

            // Дробные числа, single-precision (32bit) max value 3.4028235 * 10^38 
            float someFloat;

            //Дробные числа, Double precision (64bit) max value 1.7976931348623157 * 10^308 
            double someDouble;

            //Дробные числа, decimal 128bit, max value 79228162514264337593543950335 
            decimal someDecimal;

            //булева переменная true / false
            bool someBool = false;

            // Условные конструкции:
            // != - не равно, == - равно

            string product = "qweq";

            if (product == "hleb")
            {
                Console.WriteLine("Хлеб есть в магазе");
            }
            else if(product == "napoleon")
            {
                Console.WriteLine("Купили napoleon");
            }
            else if(product == "pivo")
            {
                Console.WriteLine("Купили pivo");
            }
            else if (product == "ekler")
            {
                Console.WriteLine("Купили еклер");
            }


            product = "pivo";
            bool nastroenieDlyPiva = true;
            // || &&
            if(product == "pivo" && nastroenieDlyPiva == true)
            {
                //Console.WriteLine("Покупаем!");
            }

            product = "ekler";
            nastroenieDlyPiva = false;

            // || - или, если хотябы одно выражение возвращает true то все выражение true
            // && - и, если хотябы одно выражение false то все выражение false

            product = true ? "Coca-cola" : product;
            Console.WriteLine(product);

            //if (!nastroenieDlyPiva)
            //{
            //    Console.WriteLine("Не покупаем");
            //}

            // if (nastroenieDlyPiva) эквивалентно if (nastroenieDlyPiva == true)
            // if (!nastroenieDlyPiva) эквивалентно if (nastroenieDlyPiva == false)

            //int a = 2;
            //a += 4; // еквивалентно a = a +/*-% 4

            //Console.WriteLine(a);
            product = "as";
            switch (product)
            {
                case "hleb":
                    Console.WriteLine("Хлеб есть в магазе");
                    break;

                case "napoleon":
                    Console.WriteLine("Купили napoleon");
                    break;

                case "pivo":
                    Console.WriteLine("Купили pivo");
                    break;

                case "ekler":
                    Console.WriteLine("Купили еклер");
                    break;

                default: 
                    Console.WriteLine("aaaaaaaaaaaaa"); 
                    break;
            }
        }
    }
}
