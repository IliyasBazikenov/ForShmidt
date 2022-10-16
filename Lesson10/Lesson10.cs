using System;

namespace Lesson10
{
    internal class Lesson10
    {
        static void Main(string[] args)
        {
            //ООП. Классы. Обьекты.
            //ООП - это объектно ориентированное программирование

            //Создали конкретный экземпляр класса (тобишь есть конкретный обьект этого класса)
            Human humanClass = new Human("100", "Iliyas", "12", "200");
            Console.WriteLine(humanClass.name);
            Console.WriteLine(humanClass.age);

            //По сути класс представляет с собой какой то новый тип данных, который мы сами пишем
            //Ключевое слово для создания класса class, далее его имя и далее идут красивые(фигурные) скобочки(тело класса)
            //class class_name
            //{
            // здесь ты пишешь содержимое класса
            //}

            //Содержимое класса(класс может быть пустым!):
            //Поля - используется для хранения данных класса
            //Поля - это переменные которые хранят данные класса
            //Методы - используются для определения поведения/логики класса
            //Конструктор - особый вид метода для инициализирования экземпляра класса. Если в классе не указан конструктор то для этого класса автоматически создается пустой конструктор по умолчанию.
            //Может быть много конструкторов
            //Пример:
            Car mercedes = new Car(); // использую второй конструктор
            Console.WriteLine(mercedes.engineVolume);

            Car toyota = new Car("2jz", "Silver", 600, 3, 6, 3000, 6.2);

            //Для того чтобы мы могли обращаться к полям/методам класса используется .
            //Пример:
            Console.WriteLine(toyota.width);
            Console.WriteLine(toyota.enginePower);
            Console.WriteLine(toyota.engine);
            toyota.Move();
            toyota.DoBeepBeep();

            Triangle triangle = new Triangle();
            triangle.x = 11123;
            triangle.CalculateLenght();
            // triangle.CalculateHalfPerimetr() так  как метод приватный компилятор будет ругаться

            //ДОМАШКА!!! 
            //ДЗ в Дискорде в Google Doc
            //ПРОЧИТАТЬ ПРО КЛАССЫ!!! И ОБЬЕКТЫ ВСЯКУЮ ИНФУ!!!
            //Ознакомиться с этим кодом!!
            //НА ДНЯХ СКИНУ ЕЩЕ ДОМАШКУ И НАВЕРНОЕ ДАЖЕ ЛЕКЦИЮ КРУТУЮ!
            //СОСТАВИТЬ СПИСОК ВОПРОСОВ!!!!!!!
            Rectangle rectangle1 = new Rectangle(new Point2D(0, 3), new Point2D(5, 0));
            Rectangle rectangle2 = new Rectangle(new Point2D(1, 2), new Point2D(4, 1));
            Rectangle rectangle3 = new Rectangle(new Point2D(0, 3), new Point2D(5, 0));
            Rectangle rectangle4 = new Rectangle(new Point2D(6, 3), new Point2D(7, 0));

            bool result = rectangle1.IsInside(rectangle2);
            bool result2 = rectangle1.IsInside(rectangle3);
            bool result3 = rectangle1.IsInside(rectangle4);

            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);

            bool result4 = rectangle1.IsIntersects(rectangle2);
            bool result5 = rectangle1.IsIntersects(rectangle3);
            bool result6 = rectangle1.IsIntersects(rectangle4);

            Console.WriteLine(result4);
            Console.WriteLine(result5);
            Console.WriteLine(result6);
        }
    }


    // Модификаторы доступа. начало
    // private - приватный,  доступ ограничен контекстом(содержащим типом)
    // public - публичный, доступ не ограничен
    // internal - доступ ограничен сборкой
    // protected - доступен для производных типов
    // Модификатор доступа может быть у:
    // Класс, структура, метод, поле, конструктор
    //Пример:
    public class Triangle
    {
        public int x;
        private int y;
        protected int z;
        private Square square;

        private class Square
        {
            public int x;
            private int y;
            protected int z;
            private int v;
        }

        //если не указывать модификатор доступа для полей и методов то они по дефолту private
        //если не указывать модификатор доступа для класса то он по дефолту internal
        public int CalculateLenght()
        {
            return x + y + z;
        }


        //Приватный метод закрыт для доступа вне класса
        private int CalculateHalfPerimetr()
        {
            return (x + y + z) / 2;
        }
    }

    class Car
    {
        //Поля они хранят данные класса
        public string engine;
        public string color;
        public int enginePower;
        public double width;
        public double length;
        public double weight;
        public double engineVolume;
        public long serialnumber;

        //Конструктор. Не обязателен, и обязан называться так же как класс
        public Car(string engine, string color, int enginePower, double width, double length, double weight, double engineVolume)
        {
            this.engine = engine;
            this.color = color;
            this.enginePower = enginePower;
            this.width = width;
            this.length = length;
            this.weight = weight;
            this.engineVolume = engineVolume;
        }

        //конструкторов может быть много
        public Car()
        {
        }

        //Методы класса
        public void Move()
        {
            //Логика движения
            Console.WriteLine("Машина поехала");
        }

        public void DoBeepBeep()
        {
            //Логика сигналки/гудка
            Console.WriteLine("БИ-БИБ");
        }

        public void SlowDown()
        {
            //Логика торможения
            Console.WriteLine("Тормозим!");
        }
    }

    //Класс есть описание(шаблон объекта).
    class Human
    {
        public string hp;
        public string name;
        public string age;
        public string height;

        public Human(string hp, string name, string age, string height)
        {
            this.hp = hp;
            this.name = name;
            this.age = age;
            this.height = height;
        }
    }
}
