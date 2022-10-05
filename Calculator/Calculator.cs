using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    //Простейший калькулятор
    internal class Calculator
    {
        //сложение
        public double Sum(double firstTerm, double secondTerm)
        {
            return firstTerm + secondTerm;
        }

        //вычитание
        public double Substract(double firstTerm, double secondTerm)
        {
            return firstTerm - secondTerm;
        }

        public double Multiply(double firstTerm, double secondTerm)
        {
            return secondTerm * firstTerm;
        }

        public double Devide(double firstTerm, double secondTerm)
        {
            if(secondTerm == 0)
                throw new DivideByZeroException();

            return firstTerm / secondTerm;
        }
    }
}
