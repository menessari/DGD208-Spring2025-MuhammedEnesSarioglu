
using System;

public class EndGame
{
    private Ozellik ozellik;

    public EndGame(Ozellik ozellik)
    {
        this.ozellik = ozellik;
    }

    public void ShowEndGame()
    {
        Console.Clear();
        Console.WriteLine("At last, you have achieved the success you aimed for and improved your farm far beyond its previous state.");
        Console.WriteLine("Despite your enemies, you've restored your prosperity and achieved everything you ever wanted.");
        Console.WriteLine("You can now live a happy and prosperous life with your family.");
        Console.WriteLine($"\nYour current balance: {ozellik.Para} TL");
        Console.WriteLine($"Time played: {ozellik.SureGoster()}");
        Console.WriteLine("\n1. Continue playing");
        Console.WriteLine("2. End the game");
        Console.Write("Your choice: ");
        string choice = Console.ReadLine();
        if (choice == "1")
        {
            Console.WriteLine("Returning to game...");
            Console.ReadKey();
        }
        else if (choice == "2")
        {
            Console.WriteLine("Thank you for playing Animal Fortune!");
            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadKey();
        }
    }
}
