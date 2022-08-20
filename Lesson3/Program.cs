using System;

namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Использование "встроенных" методов примитивных типов данных

            //Методы типа int
            int number = 123;
            string intToString = number.ToString();
            Console.WriteLine("hello " + intToString);

            int a = number.CompareTo(200);
            Console.WriteLine(a);

            Console.WriteLine(number.GetType());

            //явное преобразование и не явное

            long maxLongValue = 123123123123123;
            Console.WriteLine(maxLongValue);
            int someInt = (int)maxLongValue;
            Console.WriteLine(someInt);

            int maxIntValue = int.MaxValue;
            Console.WriteLine(maxIntValue);
            long someLongValue = maxIntValue;
            Console.WriteLine(someLongValue);


            string someString = long.MaxValue.ToString();
            Console.WriteLine(someString);
            Console.WriteLine(someString.Substring(1, 2));
            Console.WriteLine(someString);
            Console.WriteLine(someString.Remove(1, 2));
            Console.WriteLine(someString.Contains('1'));
            someString = "Hello Iliyas";
            Console.WriteLine(someString.EndsWith("Iliya"));
            Console.WriteLine(someString.Insert(5," Cool"));
            Console.WriteLine(someString);

            //статические методы типов
            string someNumber = "12323";
            if(int.TryParse(someNumber, out int resultNumber))
            {
                Console.WriteLine("УРАААААААААА " + resultNumber.ToString());
            }
            else
            {
                Console.WriteLine("Грустно!");
            }
            //HomeWork
            NameToInitials("Mihal Terentev");

        }

        static void NameToInitials(string name)
            
        {
            name.ToUpper();
            string[] Initials = name.Split(' ');
            
            Console.WriteLine (Initials[0].Substring(0,1) + "." + Initials[1].Substring(0, 1));

               
            
            
            


        }
    }
    
}
