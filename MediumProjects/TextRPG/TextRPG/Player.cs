using System;
using System.Collections.Generic;

namespace TextRPG
{
    public class Player
    {
        public string name;
        public int coins = 1;
        public int health = 20;
        public int level = 1;
        public int classNum;

        // For classNum, 1 = Warrior, 2 = Archer, 3 = Mage
        public List<string> inventory = new List<string>();

        public int damage;

        public int Prompt()
        {
            Console.WriteLine("\n \n 1. Attack \n 2. Inventory \n 3. Run");
            string choice = Console.ReadLine();

            if (isInt(choice) == 1)
            {
                Console.WriteLine($"You dealt {damage} amount of damage.");
            }
            if (isInt(choice) == 2)
            {
                Console.WriteLine("You currently have " + inventory + "in your bag");
            }
            return 0;
        }

        public int isInt(string str)
        {
            if (int.TryParse(str, out var ret))
            {
                return ret;
            }
            else
            {
                Console.WriteLine("Please enter a number");
                return 0;
            }
        }
    }
}