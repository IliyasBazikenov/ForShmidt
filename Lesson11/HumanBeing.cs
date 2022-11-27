using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson11
{
    //Тупой пример наследования
    internal class HumanBeing
    {
        protected readonly string _type;
        public int HP { get; set; }
        public string Name { get; set; }

        public HumanBeing(int hP, string name, string type)
        {
            HP = hP;
            Name = name;
            _type = type;
        }

        public void Move()
        {
            Console.WriteLine($"{_type} пошел");
        }

        public virtual void Atack()// virtual ключевое слово для того чтобы метод можно было переопределить в наследнике
        {
            Console.WriteLine($"{_type} атакует!!!!");
        }
    }


    internal class Warrior: HumanBeing
    {
        public string Rank { get; set; }
        public Warrior(int hP, string name, string type, string rank) 
            : base(hP, name, type)
        {
            Rank = rank;
        }

        public void AtackWithShield()
        {
            Console.WriteLine($"{_type} атакует щитом!!!");
        }

        public override void Atack()
        {
            Console.WriteLine($"{_type} достает меч");
            base.Atack();
        }
    }
}
