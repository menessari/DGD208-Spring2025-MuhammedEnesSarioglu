
using System;

public class Kumarhane
{
    private Ozellik ozellik;
    private Random rnd = new Random();

    public Kumarhane(Ozellik ozellik)
    {
        this.ozellik = ozellik;
    }

    public void Ac()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("$$$ CASINO GAMES $$$");
            Console.WriteLine("\n1. Coin Flip");
            Console.WriteLine("2. Roll the Dice ");
            Console.WriteLine("3. Exit the Casino");
            Console.Write("Your choice: ");
            string sec = Console.ReadLine();

            if (sec == "1") CoinFlip();
            else if (sec == "2") ZarAtma();
            else if (sec == "3") break;
            else Console.WriteLine("Wrong entry.");

            Console.ReadKey();
        }
    }

    private void CoinFlip()
    {
        Console.Write("Enter the amount you want to bet: ");
        if (int.TryParse(Console.ReadLine(), out int miktar) && miktar > 0)
        {
            if (ozellik.Para >= miktar)
            {
                Console.Write("1 -> Heads / 2 -> Tails : ");
                if (int.TryParse(Console.ReadLine(), out int secim) && (secim == 1 || secim == 2))
                {
                    int sonuc = rnd.Next(0, 2); // 0 = Yazı, 1 = Tura
                    string gelen = sonuc == 0 ? "Heads" : "Tails";
                    Console.WriteLine($"Result: {gelen}");
                    if ((secim == 1 && sonuc == 0) || (secim == 2 && sonuc == 1))
                    {
                        ozellik.Para += miktar * 2;
                        Console.WriteLine("You win.");
                    }
                    else
                    {
                        ozellik.Para -= miktar;
                        Console.WriteLine("You lose.");
                    }
                }
                else Console.WriteLine("Wrong entry.");
            }
            else Console.WriteLine("You are poor.");
        }
        else Console.WriteLine("Invlaid amount. Enter a positive integer.");
    }

    private void ZarAtma()
    {
        Console.Write("Enter the amount you want to bet: ");
        if (int.TryParse(Console.ReadLine(), out int miktar) && miktar > 0)
        {
            if (ozellik.Para >= miktar)
            {
                Console.Write("Choose a number between 1 and 6:");
                if (int.TryParse(Console.ReadLine(), out int sayi) && sayi >= 1 && sayi <= 6)
                {
                    int sonuc = rnd.Next(1, 7);
                    Console.WriteLine($"Result: {sonuc}");
                    if (sonuc == sayi)
                    {
                        ozellik.Para += miktar * 4;
                        Console.WriteLine("You win.");
                    }
                    else
                    {
                        ozellik.Para -= miktar;
                        Console.WriteLine("You lose.");
                    }
                }
                else Console.WriteLine("Wrong entry.");
            }
            else Console.WriteLine("You are poor.");
        }
        else Console.WriteLine("Wrong entry. Enter a positive integer.");
    }
}
