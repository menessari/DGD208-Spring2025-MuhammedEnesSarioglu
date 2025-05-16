using System;
using System.Threading.Tasks;

public class Program
{
    private bool _isRunning;

    public static async Task Main(string[] args)
    {
        // Program sınıfından bir örnek oluşturup GameLoop'u çalıştırıyoruz
        Program program = new Program();
        await program.GameLoop();
    }

    public async Task GameLoop()
    {
        // Initialize the game
        Initialize();

        // Main game loop
        _isRunning = true;
        while (_isRunning)
        {
            // Display menu and get player input
            string userChoice = GetUserInput();

            // Process the player's choice
            await ProcessUserChoice(userChoice);
        }

        Console.WriteLine("Thanks for playing!");
    }

    private void Initialize()
    {
        // Use this to initialize the game
        Console.WriteLine("Welcome to the Pet Simulator!");
    }

    private string GetUserInput()
    {
        // Display a simple menu and get user input
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Credits");
        Console.WriteLine("2. Exit the game");
        Console.Write("Enter your choice: ");
        return Console.ReadLine();
    }

    private async Task ProcessUserChoice(string choice)
    {
        switch (choice)
        {
            case "1":
                Console.WriteLine("Created by: Muhammed Enes Sarıoğlu, Student No: 225040068");
                break;
            case "2":
                Console.WriteLine("Exiting the game...");
                _isRunning = false;
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }

        // Simulate a short delay (e.g., for item usage later)
        await Task.Delay(500);
    }
}
