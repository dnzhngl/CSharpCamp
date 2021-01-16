using System;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithmeticOperation ao = new ArithmeticOperation();
            ao.Sum(3, 4, 5);
            ao.Sum(-3, -10, 20);
            ao.Sum(-3, -10, 20.5);

            ao.Subtract(40, 50, 2);
            ao.Multiplication(2,3,-1-4);
        }
    }
}
