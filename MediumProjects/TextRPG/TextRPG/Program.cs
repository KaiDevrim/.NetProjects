using System;
using System.Threading;

namespace TextRPG
{
    class Program
    {
        public static Player currentPlayer = new Player();

        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
            Console.Clear();
            chooseName();
            chooseClass();
        }

        static void chooseName()
        {
            Console.WriteLine("You have selected this game to play. This game is about man vs monster and you are the main charcter. So what is your epic name?");
            currentPlayer.name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"So, your name is {currentPlayer.name}! Interesting. Before you begin your quest, you must select a class.");
            Thread.Sleep(3000);


        }

        static void chooseClass()
        {
            Console.Clear();
            Console.WriteLine("To select a class, please type in either 1, 2 or 3.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1 - Warrior: A close-ranged fighter who will generally take damage while fighting. Also has the ability to block attacks which allow the user to heal a small amount of health inbetween turns.");
            Console.WriteLine();
            Console.WriteLine("2 - Archer: A distanced attacker who will rarely get hit during battle, but at the expense of less health and the need to charge the arrow between turns. Select this class if you want to have a challenge.");
            Console.WriteLine();
            Console.WriteLine("3 - Wizard: A more of a support class that can gain allies throughout the story and helps them attack. This class requires a lot more attention to detail than the other classes but can be rewarding to play as.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("So now it is time to pick a class. Choose carefully as you will not have the ability to change unless you delete the save file.");
            string classSelect = Console.ReadLine();

            try
            {
                int idontcare = int.Parse(classSelect); 
                if (idontcare == 1 || idontcare == 2 || idontcare == 3)
                {
                    currentPlayer.classNum = idontcare;

                    if (currentPlayer.classNum == 1)
                    {
                        Console.WriteLine("You chose Warrior! Now go embark on your quest hero, " + currentPlayer.name);
                    }
                    else if (currentPlayer.classNum == 2)
                    {
                        Console.WriteLine("You chose Archer! Now go embark on your quest hero, " + currentPlayer.name);
                    }
                    else if (currentPlayer.classNum == 3)
                    {
                        Console.WriteLine("You chose Wizard! Now go embark on your quest hero, " + currentPlayer.name);
                    }
                    else
                    {
                        Console.WriteLine("how did you get here?");
                    }
                }
                else
                {
                    Console.WriteLine("Please choose 1, 2, or 3");
                }

                currentPlayer.classNum = idontcare;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Please select your class again.");
                chooseClass();
            }
             
        }
    }
}

//Start by making the user select from 3 classes
//Sword, Bow, Magic
//After the class system is setup make a basic enemy and the attack system
//Fight, inventory, make peace, or run