using System;
using System.Threading;

namespace TextRPG
{
    internal class Program
    {
        public static Player currentPlayer = new Player();
        public static WizardStory wizard = new WizardStory();

        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Clear();
            chooseName();
            chooseClass();

            if (currentPlayer.classNum == 3)
            {
                wizard.Chapter1();
            }
        }

        private static void chooseName()
        {
            Console.WriteLine("You have selected this game to play. This game is about man vs monster and you are the main character. So what is your epic name?");
            currentPlayer.name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"So, your name is {currentPlayer.name}! Interesting. Before you begin your quest, you must select a class.");
            Thread.Sleep(3000);
        }

        private static void chooseClass()
        {
            Console.Clear();
            Console.WriteLine("To select a class, please type in either 1, 2 or 3.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1 - Warrior: A close-ranged fighter who will generally take damage while fighting. Also has the ability to block attacks which allow the user to heal a small amount of health in between turns.");
            Console.WriteLine();
            Console.WriteLine("2 - Archer: A distanced attacker who will rarely get hit during battle, but at the expense of less health and the need to charge the arrow between turns. Select this class if you want to have a challenge.");
            Console.WriteLine();
            Console.WriteLine("3 - Wizard: A more of a support class that can gain allies throughout the story and helps them attack. This class requires a lot more attention to detail than the other classes but can be rewarding to play as.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("So now it is time to pick a class. Choose carefully as you will not have the ability to change unless you delete the save file.");

            int classSelect = currentPlayer.isInt(Console.ReadLine());

            switch (classSelect)
            {
                case 1:
                    Console.WriteLine("You chose Warrior! Now go embark on your quest hero, " + currentPlayer.name);
                    currentPlayer.classNum = 1;
                    break;

                case 2:
                    Console.WriteLine("You chose Archer! Now go embark on your quest hero, " + currentPlayer.name);
                    currentPlayer.classNum = 2;
                    break;

                case 3:
                    Console.WriteLine("You chose Wizard! Now go embark on your quest hero, " + currentPlayer.name);
                    currentPlayer.classNum = 3;
                    break;

                default:
                    Console.WriteLine("Please enter 1, 2, or 3");
                    chooseClass();
                    break;
            }
        }
    }
}

//Start by making the user select from 3 classes
//Sword, Bow, Magic
//After the class system is setup make a basic enemy and the attack system
//Fight, inventory, make peace, or run

/*    ///

                    Console.WriteLine("You chose Wizard! Now go embark on your quest hero, " + currentPlayer.name);
                else

                    Console.WriteLine("How did you get here?");
                    currentPlayer.classNum = classSelect;

     */
