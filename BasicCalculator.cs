using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int answer;
            string operation;

            Console.WriteLine("Would you like to add, subtract, multiply or divide? Please input 'add', 'subtract', 'multiply' or 'divide': ");
            operation = Console.ReadLine();
            operation = operation.ToUpper();

            if (operation == "ADD")
            {
                Console.WriteLine("Please input first number for addition: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please input second number for addition: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                answer = num1 + num2;
                Console.WriteLine("The answer is " + answer);
                Console.ReadLine();
            }
            else if (operation == "SUBTRACT")
            {
                Console.WriteLine("Please input first number for subtraction: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please input second number for subtraction: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                answer = num1 - num2;
                Console.WriteLine("The answer is " + answer);
                Console.ReadLine();
            }
            else if (operation == "MULTIPLY")
            {
                Console.WriteLine("Please input first number for multiplication: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please input second number for multiplication: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                answer = num1 * num2;
                Console.WriteLine("The answer is " + answer);
                Console.ReadLine();
            }
            else if (operation == "DIVIDE")
            {
                Console.WriteLine("Please input first number for division: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please input second number for division: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                answer = num1 / num2;
                Console.WriteLine("The answer is " + answer);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid input. Program will now terminate. Please press enter.");
                Console.ReadLine();
            }
        }
    }
}
