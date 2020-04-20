using System;
namespace Calculator
{
    class Program
    {
        private const string wrong = "Wrong input, type something more explicit.";
        private const string correctinput = "The answer is: ";
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int FirstInput;
            while (!Int32.TryParse(Console.ReadLine(), out FirstInput))
            {
               Console.WriteLine(wrong);
            }
            Console.Write("Enter the operation number: ");
            char OperationInput;
            while (!Char.TryParse(Console.ReadLine(), out OperationInput))
            {
               Console.WriteLine(wrong);
            }
            Console.Write("Enter the second number: ");
            int SecondInput;
            while (!Int32.TryParse(Console.ReadLine(), out SecondInput))
            {
               Console.WriteLine(wrong);
            }
            if (OperationInput == '+')
            {
               int result = FirstInput + SecondInput; //Add
               Console.Write($"{correctinput} + {result}");
            }
            if (OperationInput == '-') //Substract
            {
               int result = FirstInput - SecondInput;
               Console.Write($"{correctinput} + {result}");
            }
            if (OperationInput == '*') //Multiply
            {
               int result = FirstInput * SecondInput;
               Console.Write($"{correctinput} + {result}");
            }
            if (OperationInput == '/') //Divide
            {
               int result = FirstInput / SecondInput;
               Console.Write($"{correctinput} + {result}");
            }
            Console.ReadLine(); //Too keep the program running
        }
    }