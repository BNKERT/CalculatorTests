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

                //Calculator myCalculator = new Caluculator();
                //int i;firstNumber = Console.ReadLine();
                ////count to 10 with for loop
                ////benefits: you know when its going to end
                //for(i = 0;i < 10; i++)
                //{
                //    Console.WriteLine(i);
                //}
                ////While evaluates condition first and then runs loop
                //while(i < 9)
                //{
                //    Console.WriteLine("Don't show me");
                //}
                ////runs once and then evaluates regardless of condition
                //do
                //{
                //    Console.WriteLine("Will show me once");
                //}
                //while (i < 9);
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
                    ////string composite formatting
                    //Console.WriteLine("Your first input is {0}, this is a test {1}", firstNumber, 1);

                    ////string concatenation
                    //Console.WriteLine("Your second input is " + secondNumber);
                }

                ////string interpolation
                //Console.WriteLine($"Your second input {secondNumber}");

            }

            //Function
            //private void TestFunc()
            //{

            //}

            //class declaration
            public class Calculator
            {
                private string _firstInput { get; set; }
                private string _secondInput { get; set; }


                //constructor
                public Calculator(string firstInput,string secondInput)
                {
                    _firstInput = firstInput;
                    _secondInput = secondInput;
                }

                public Calculator(string firstInput)
                {
                    _firstInput = firstInput;
                    _secondInput = string.Empty;
                }

                public Calculator(string firstInput, int secondValue)
                {
                    _firstInput = firstInput;
                    _secondInput = secondValue.ToString();
                }

                //Method
                //use internal values
                public int Add()
                {
                    throw new NotImplementedException();
                }

                //use external values
                public int Add(string first,string second)
                {
                    throw new NotImplementedException();
                }

                public int Subtract()
                {
                    throw new NotImplementedException();
                }

                public int Multiply()
                {
                    throw new NotImplementedException();
                }

                public int Divide()
                {
                    throw new NotImplementedException();
                }

                //
                public bool ValidateInputs()
                {
                    //_firstInput is valid ? true : false
                    throw new NotImplementedException();
                }
            }
        }
    }

}
