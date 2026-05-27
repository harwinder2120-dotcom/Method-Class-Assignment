using System;

// This class performs a math operation on one integer
// and displays another integer to the console.
public class MathOperations
{
    // This method takes two integers as parameters.
    // It multiplies the first integer by 5 and prints both results.
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

