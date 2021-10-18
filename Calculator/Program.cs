using System;

namespace Calculator
{
    using System;

    namespace Calculator
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                string firstInput,
                    secondInput,
                    operation,
                    quitCondition = "quit";

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

                    Console.WriteLine("Your equation is {0} {1} {2}", firstInput, operation, secondInput);
                }


            }


            //class declaration
            public class Calculator
            {


                //Method
                //use internal values
                public int Add()
                {
                    throw new NotImplementedException();
                }

                //use external values
                public int Add(int first,int second)
                {
                    throw new NotImplementedException();
                }

                public int Subtract(int first, int second)
                {
                    throw new NotImplementedException();
                }

                public int Multiply(int first, int second)
                {
                    throw new NotImplementedException();
                }

                public int Divide(int first, int second)
                {
                    throw new NotImplementedException();
                }

                public bool ValidateInputs(ref string first,ref string second)
                {
                    throw new NotImplementedException();
                }
            }
        }
    }

}
