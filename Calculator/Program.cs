using System;

namespace CalculatorTestingProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string firstInput,
                secondInput,
                operation,
                quitCondition = "quit";

            Calculator calculator = new Calculator();

            while (true)
            {
                Console.WriteLine("Please enter the first value or type quit to exit");
                firstInput = Console.ReadLine();
                //compare first input to quit, if true, stop
                if (String.Equals(firstInput, quitCondition, StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                Console.WriteLine("Please enter the second value or type quit to exit");
                secondInput = Console.ReadLine();
                //compare second input to quit, if true, stop
                if (String.Equals(secondInput, quitCondition, StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                Console.WriteLine("Please enter the operation you want or type quit to exit");
                operation = Console.ReadLine();
                if (String.Equals(operation, quitCondition, StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }


                   
            }


        }
    }
}
