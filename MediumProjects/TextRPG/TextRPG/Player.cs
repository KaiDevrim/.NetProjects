using System.Collections.Generic;
using System;

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
        
        public int Prompt()
        {
            Console.WriteLine("\n \n 1. Attack \n 2. Inventory \n 3. Run");
            string choice = Console.ReadLine();

            if (MakeInt(choice) == 1)
            {
                Console.WriteLine($"You dealt x amount of damage.");
            }
            return 0;
        }

        public static int MakeInt(string notInt)
        {
            int convertedInt;
            try
            {
                 convertedInt = int.Parse(notInt);
                 return convertedInt;
                
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Please enter a valid number.");
                return 0;
            }
            
        }
    }
}