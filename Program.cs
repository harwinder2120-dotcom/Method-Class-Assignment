using System;

namespace CallingMethodsAssignment
{
    // This class contains a method that performs a math operation on one integer
    // and displays another integer to the console.
    class MathOperations
    {
        // This method takes two integers as parameters.
        // It multiplies the first integer by 5 and displays the second integer.
        public void PerformOperation(int firstNumber, int secondNumber)
        {
            // Perform a math operation on the first integer.
            int result = firstNumber * 5;

            // Display the result of the operation.
            Console.WriteLine("Result of operation on first number: " + result);

            // Display the second integer to the screen.
            Console.WriteLine("Second number is: " + secondNumber);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class.
            MathOperations mathOps = new MathOperations();

            // Call the method using positional parameters.
            mathOps.PerformOperation(4, 10);

            // Call the method using named parameters.
            mathOps.PerformOperation(firstNumber: 7, secondNumber: 20);

            // Keep the console window open until the user presses a key.
            Console.ReadLine();
        }
    }
}
