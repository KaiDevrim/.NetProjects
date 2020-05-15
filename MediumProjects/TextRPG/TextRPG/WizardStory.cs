using System;
using TextRPG;

public class WizardStory
{
    private static Player currentPlayer = new Player();

    public WizardStory()
    {
        Chapter1();
    }

    public void Chapter1()
    {
        Console.Clear();
        Console.WriteLine("Welcome wizard to the world of Textos. You awaken in your home to a loud sound. You get out of your bed and look around for this source of sound. You see a house being destroyed by a big green man. What do you do?");
        currentPlayer.Prompt();
    }
}