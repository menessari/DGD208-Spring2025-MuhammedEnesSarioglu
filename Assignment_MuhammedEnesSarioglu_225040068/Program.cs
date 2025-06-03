using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Assignment_MuhammedEnesSarioglu_225040068;

public class Program
{
    public static async Task Main(string[] args)
    {
        OyunTemel oyun = new OyunTemel();
        while (true)
        {
            Console.Clear();
            Console.WriteLine("--> MAIN MENU <--");
            Console.WriteLine("\n1. New Game");
            Console.WriteLine("2. Load Game");
            Console.WriteLine("3. Credits");
            Console.WriteLine("4. Exit the Game");
            Console.Write("Your choice: ");
            string secim = Console.ReadLine();

            if (secim == "1") await oyun.YeniOyun();
            else if (secim == "2") await oyun.KayitliOyunuYukle();
            else if (secim == "3")
            {
                Console.WriteLine("Project Owner: Muhammed Enes Sarıoğlu - 225040068");

                Console.WriteLine("Thanks to Onur Hoca, my friends and ChatGPT for their help.");


            }
            else if (secim == "4") break;
            Console.ReadKey();
        }
    }
}
