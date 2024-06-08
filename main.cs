using System;
using System.IO;

namespace ExceptionHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            string input1 = Console.ReadLine();

            Console.WriteLine("Enter the second number:");
            string input2 = Console.ReadLine();

            try
            {
                int num1 = Convert.ToInt32(input1);
                int num2 = Convert.ToInt32(input2);

                int result = Divide(num1, num2);

                Console.WriteLine($"The result of dividing {num1} by {num2} is: {result}");
            }
            catch (FormatException ex)
            {
                LogError("FormatException", ex);
                Console.WriteLine("Error: One or both of the inputs are not valid integers.");
            }
            catch (DivideByZeroException ex)
            {
                LogError("DivideByZeroException", ex);
                Console.WriteLine("Error: Cannot divide by zero.");
            }
            catch (OverflowException ex)
            {
                LogError("OverflowException", ex);
                Console.WriteLine("Error: One or both of the inputs are too large or too small for an Int32.");
            }
            catch (Exception ex)
            {
                LogError("Exception", ex);
                Console.WriteLine("An unexpected error occurred.");
            }
        }

        static int Divide(int numerator, int denominator)
        {
            return numerator / denominator;
        }

        static void LogError(string exceptionType, Exception ex)
        {
            string logFilePath = "error_log.txt";
            string logMessage = $"[{DateTime.Now}] {exceptionType}: {ex.Message}\nStack Trace:\n{ex.StackTrace}\n";

            // Print log message to the console (optional)
            Console.WriteLine(logMessage);

            // Append the log message to the log file
            File.AppendAllText(logFilePath, logMessage);
        }
    }
}
