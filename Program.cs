// Importing the System Namespace, which contains fundamental classes like Console, String, etc.
using System;
using System.Buffers;
using CalculatorApp;
#nullable disable

// Defining a namespace for the calculator app
// A namespace is a way to group related classes together
namespace Calculator
{
    // This is the main class where the program starts
    // The class is called "Program".
    class Program
    {
        // The Main method is the entry point of the program
        // It is automatically called when the program starts
        static void Main(string[] args)
        {
            // Displaying a message to the user
            Console.WriteLine("Simple Calculator App");

            // Prompting the user to enter the first number
            // Console.ReadLine() reads the user's input as a string.
            // Convert.ToDouble() converts the string to a double (a number that can have decimals).
            Console.WriteLine("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            // Prompting the user to enter the operator (+, -, *, /, %)
            // The operator is a string that determines which operation to perform
            Console.WriteLine("Enter the operator (+, -, *, /, %): ");
            string operation = Console.ReadLine();

            // Prompting the user to enter the second number
            // Again, the input is read as a string and converted to a double
            Console.WriteLine("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Variable to store the result of the operation
            double result = 0.0;

            // A switch statement to choose the operation based on the user's input.
            // The switch checks the value of 'operation' and calls the corresponding method from the Operations Class
            switch (operation)
            {
                case "+":
                    // Calling the Add Method from the Operations Class
                    result = Operations.Add(num1, num2);
                    break;

                case "-":
                    // Calling the Subtract Method from the Operations Class
                    result = Operations.Subtract(num1, num2);
                    break;

                case "*":
                    // Calling the Multiply Method from the Operations Class
                    result = Operations.Multiply(num1, num2);
                    break;

                case "/":
                    // Calling the Divide Method from the Operations Class
                    result = Operations.Divide(num1, num2);
                    break;

                case "%":
                    // Calling the Modulo Method from the Operations Class
                    result = Operations.Modulo(num1, num2);
                    break;

                default:
                    // If the user enters an invalid operator, display an error message
                    Console.WriteLine("Invalid operator");
                    break;
            }

            // Displaying the result of the calculation
            // If an invalid operator was entered, result will remain 0
            Console.WriteLine($"Result: {result}");
        }
    }
}
