using System;

namespace RomanNumeral2Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = "I";
            string four = "IV";
            string five = "V";
            string nine = "IX";
            string ten = "X";
            string fifty = "L";
            string hundred = "C";

            int count = 0;
            

            Console.WriteLine("Please input a Roman Numeral");
            string userInput = Console.ReadLine();
            string upperString = userInput.ToUpper();
            char[] splitInput = upperString.ToCharArray();
            Console.WriteLine(splitInput);

            
            Console.WriteLine(count);
        }
    }
}
