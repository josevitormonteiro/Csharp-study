namespace Calculator
{
    using System;

    internal class Program
    {
        internal static void Main(string[] args)
        {
            // Declare variables as zero
            int num1 = 0; int num2 = 0;

            // Display the title
            Console.WriteLine("Console calculator C#\r");
            Console.WriteLine("----------------------\n");

            // Ask the user for the first number
            Console.WriteLine("Type a number, and then press Enter");
            num1 = Convert.ToInt32(Console.ReadLine());


            // Ask the user for the second number
            Console.WriteLine("Type another number, and then press Enter");
            num2 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to choose the option
            Console.WriteLine("Choose an option from the following list");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.WriteLine("Your option? ");

            // Use the switch statement to do the math
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;

            }

            // Wait for the user to close the app
            Console.WriteLine("Press any key to close the app");
            Console.ReadKey();
        }
    }
}
