using System;

namespace Lesson11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Наследование/Inheritance - база просто чтобы показать базовый функционал
            //Домашка прочитать про наследование (подготовить вопросы!!!!!!)

            HumanBeing humanBeing = new HumanBeing(100, "Kapitoshka", "Человек");
            Warrior warrior = new Warrior(200, "Rocky Balboa", "Машина", "Генералисимус");

            humanBeing.Atack();
            humanBeing.Move();

            warrior.Move();
            warrior.Atack();
            warrior.AtackWithShield();
        }
    }
}
