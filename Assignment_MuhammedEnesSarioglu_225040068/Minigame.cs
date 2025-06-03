
using System;
using System.Collections.Generic;

public class Minigame
{
    private Ozellik ozellik;
    private Random rnd = new Random();
    private List<(string soru, int cevap)> sorular;

    public Minigame(Ozellik ozellik)
    {
        this.ozellik = ozellik;
        sorular = new List<(string, int)>
        {
            ("12 + 5 * 3", 27),
            ("20 - 4 * 3", 8),
            ("15 + 9 / 3", 18),
            ("40 / 5 + 6", 14),
            ("25 - 7 + 10", 28),
            ("8 * 3 - 5", 19),
            ("30 / 2 + 4", 19),
            ("5 * 5 + 2", 27),
            ("18 + 6 - 3", 21),
            ("10 * 2 - 5", 15),
            ("6 * 3 + 4", 22),
            ("14 + 7 - 2", 19),
            ("9 * 2 + 5", 23),
            ("50 / 5 + 10", 20),
            ("12 * 2 - 7", 17),
            ("30 - 5 * 4", 10),
            ("16 + 4 / 2", 18),
            ("7 * 3 - 5", 16),
            ("27 - 9 + 6", 24),
            ("45 / 5 + 5", 14)
        };
    }

    public void MinigameGir()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("--> MINIGAMES <--");
            Console.WriteLine("\n1. Guess the Number");
            Console.WriteLine("2. Math Operation");
            Console.WriteLine("3. Exit the Minigames");
            Console.Write("Your choice: ");
            string sec = Console.ReadLine();

            if (sec == "1") SayiyiTahminEt();
            else if (sec == "2") MatematikSorusu();
            else if (sec == "3") break;
            else Console.WriteLine("Wrong entry.");

            Console.ReadKey();
        }
    }

    private void SayiyiTahminEt()
    {
        int rastgeleSayi = rnd.Next(1, 6);
        Console.Write("I picked a number between 1 and 5. Guess.: ");
        if (int.TryParse(Console.ReadLine(), out int tahmin))
        {
            if (tahmin == rastgeleSayi)
            {
                ozellik.Para += 100;
                Console.WriteLine("You guess correctly. You won 100 TL.");
            }
            else
            {
                Console.WriteLine($"Your guess is wrong. My number is {rastgeleSayi}.");
            }
        }
        else Console.WriteLine("Wrong entry.");
    }

    private void MatematikSorusu()
    {
        var soru = sorular[rnd.Next(sorular.Count)];
        Console.Write($"Solve the problem: {soru.soru} = ");
        if (int.TryParse(Console.ReadLine(), out int cevap))
        {
            if (cevap == soru.cevap)
            {
                ozellik.Para += 50;
                Console.WriteLine("Your answer is right. You won 50 TL.");
            }
            else
            {
                Console.WriteLine($"Your answer is wrong. Correct answer is {soru.cevap}.");
            }
        }
        else Console.WriteLine("Wrong entry.");
    }
}
