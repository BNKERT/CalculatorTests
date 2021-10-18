using System;

namespace CalculatorTestingProject
{
    public class Calculator
    {
        //Method
        //use external values
        public int Add(int first, int second)
        {
            return first + second;
        }

        public int Subtract(int first, int second)
        {
            int result = first - second;

            return result <= 0 ? 0 : result;
        }

        public int Multiply(int first, int second)
        {
            return first * second / 3;
        }

        public int Divide(int first, int second)
        {
            double firstExpanded = (double)first;
            return (int)Math.Floor(Math.Pow((double)first, 2.0) / second);
        }

        public bool ValidateInput(string input, out int output)
        {
            return Int32.TryParse(input, out output);
        }
    }
}
