using System;
using System.Collections.Generic;
using System.Text;

namespace Math
{
    class ArithmeticOperation
    {
        public void Sum(params double[] numbers)
        {
            double result = 0;
            foreach(var number in numbers)
            {
                result += number;
            }
            Console.WriteLine("Sum : "+ result);
        }
        public void Subtract(params double[] numbers)
        {
            double result = 0;
            foreach(var number in numbers)
            {
                result -= number;
            }
            Console.WriteLine("Subtract : "+ result);
        }
        public void Multiplication(params double[] numbers)
        {
            double result = 1;
            foreach(var number in numbers)
            {
                result *= number;
            }
            Console.WriteLine("Multiplication : " + result);
        }

    }
}
