using System;
using System.Data; // Required for using DataTable.Compute for expression evaluation.

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is the REPL (Read-Eval-Print Loop)
            while (true)
            {
                Console.Clear(); // Clears the console for a fresh start each loop.
                Console.WriteLine("Type an expression (or 'exit' to quit):");

                string expression = ""; // To store the user's input.
                double ghostResult = 0; // The live result shown underneath the input line.

                // Read user input character by character for the ghost result.
                ConsoleKeyInfo key;
                do
                {
                    key = Console.ReadKey(intercept: true); // Read a key without printing it (intercept = true).

                    // Handle if the user presses Enter to evaluate the expression.
                    if (key.Key == ConsoleKey.Enter)
                    {
                        Console.WriteLine(); // Move to the next line after Enter.
                        break; // Exit the do-while loop to evaluate the expression.
                    }

                    // Handle if the user presses Backspace to remove characters from the expression.
                    if (key.Key == ConsoleKey.Backspace && expression.Length > 0)
                    {
                        expression = expression.Substring(0, expression.Length - 1); // Remove last character.
                        Console.Write("\b \b"); // Visually erase last character on console.
                    }
                    // Ignore any control keys that are not relevant for the input (like Arrow keys, etc.).
                    else if (!char.IsControl(key.KeyChar))
                    {
                        expression += key.KeyChar; // Add the typed character to the expression.
                        Console.Write(key.KeyChar); // Print the character to the console.
                    }

                    // Try to calculate the ghost result every time the user types something.
                    ghostResult = TryEvaluateExpression(expression);

                    // Show the ghost result in real-time underneath the expression.
                    Console.SetCursorPosition(0, Console.CursorTop + 1); // Move cursor to the next line.
                    Console.Write($"Ghost result: {ghostResult}");

                    // Move cursor back to the input line.
                    Console.SetCursorPosition(expression.Length, Console.CursorTop - 1);
                } while (true);

                // When the user presses Enter, evaluate the final expression and print the result.
                if (expression.ToLower() == "exit")
                {
                    // Exit the REPL loop if the user types "exit".
                    break;
                }

                // Calculate the final result of the entered expression.
                double finalResult = TryEvaluateExpression(expression);
                Console.WriteLine($"\nFinal result: {finalResult}");

                // Pause before restarting the loop.
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }

        // This method attempts to evaluate the expression using DataTable.Compute.
        public static double TryEvaluateExpression(string expression)
        {
            try
            {
                // Using DataTable to compute the expression.
                DataTable table = new DataTable();
                var result = table.Compute(expression, ""); // Evaluate the expression.
                return Convert.ToDouble(result); // Convert the result to a double and return it.
            }
            catch
            {
                // If an error occurs (like invalid input), return 0 as a default ghost result.
                return 0;
            }
        }
    }
}
