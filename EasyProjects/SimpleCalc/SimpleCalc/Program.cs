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

            switch (OperationInput)
            {
                case '+':
                    int ResultAdd = FirstInput + SecondInput; //Add
                    Console.Write($"{correctinput}{ResultAdd}");
                    break;

                case '-':
                    int ResultSubtract = FirstInput - SecondInput; //Add
                    Console.Write($"{correctinput}{ResultSubtract}");
                    break;

                case '*':
                    int ResultMultiply = FirstInput * SecondInput; //Add
                    Console.Write($"{correctinput}{ResultMultiply}");
                    break;

                case '/':
                    int ResultDivide = FirstInput / SecondInput; //Add
                    Console.Write($"{correctinput}{ResultDivide}");
                    break;
            }

            Console.ReadLine(); //Too keep the program running

        }
    }
}