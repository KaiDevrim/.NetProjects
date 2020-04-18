using System;
using System.Collections.Generic;

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
            string upperString = Console.ReadLine().ToUpper();
            char[] splitInput = upperString.ToCharArray();

            getRomanValue(upperString);

            int getRomanValue (string Decimal)
            {
                foreach (char r in upperString)
                {
                    switch (r)
                    {
                        case 'I':
                            count += 1;
                            break;
                        case 'V':
                            count += 5;
                            break;
                        case 'X':
                            count += 10;
                            break;
                        case 'L':
                            count += 50;
                            break;
                        case 'C':
                            count += 100;
                            break;
                        case 'D':
                            count += 500;
                            break;
                        case 'M':
                            count += 1000;
                            break;
                    }
                }
                return count;
            }
            Console.WriteLine(count.ToString());
        }
    }
}