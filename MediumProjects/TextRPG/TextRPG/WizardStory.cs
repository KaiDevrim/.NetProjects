using System;
using TextRPG;

public class WizardStory
{
	static Player currentPlayer = new Player();

	public WizardStory()
	{
	}

	public void Chapter1()
	{
		Console.Clear();
		Console.WriteLine("Welcome wizard to the world of Textos. You awaken in your home to a loud sound. You get out of your bed and look around for this source of sound. You see a house being destroyed by a big fat green man. What do you do?");
		currentPlayer.Prompt();
	}
}
