//Defining the namespace to match the one in Program.cs
// This makes sure the classes can work together
namespace CalculatorApp
{
    // This is a static class called "Operations"
    // A static class means we don't need to create an instance (or an object) of it to use its methods.
    public static class Operations
    {
        // This method adds two numbers
        // It takes two double parameters (num1 and num2) and returns their sum.
        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        // Method to subtract two numbers.
        // It takes two double parameters and return sthe result of subtracting num2 from num1.
        public static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        // Method to multiply two numbers
        // It returns the result of multiplying num1 by num2
        public static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        // Method to divide two numbers
        // If num2 is 0, we cannot divide by 0 so we return 0 and print and error message.
        public static double Divide(double num1, double num2)
        {
            if (num2 == 0)
            {
                // Showing an error message because division by zero is not allowed.
                Console.WriteLine("Error: Division by zero is not allowed.");
                return 0; // Return 0 to avoid crashing the program.
            }

            return num1 / num2; // Otherwise return the result of the division
        }

        // Method to calculate the remainder of division (modulo)
        // It returns the remainder when num1 is divided by num2
        public static double Modulo(double num1, double num2)
        {
            if (num2 == 0)
            {
                // Showing an error message because division by zero is not allowed.
                Console.WriteLine("Error: Division by zero is not allowed.");
                return 0; // Return 0 to avoid crashing the program.
            }
            return num1 % num2;
        }
    }
}
