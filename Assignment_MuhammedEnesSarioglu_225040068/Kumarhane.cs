
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
            Console.WriteLine("Kumarhane Oyunları:");
            Console.WriteLine("1. Coin Flip");
            Console.WriteLine("2. Zar Atma");
            Console.WriteLine("3. Çıkış");
            Console.Write("Seçim: ");
            string sec = Console.ReadLine();

            if (sec == "1") CoinFlip();
            else if (sec == "2") ZarAtma();
            else if (sec == "3") break;
            else Console.WriteLine("Geçersiz seçim!");

            Console.ReadKey();
        }
    }

    private void CoinFlip()
    {
        Console.Write("Yatırmak istediğiniz miktarı girin: ");
        if (int.TryParse(Console.ReadLine(), out int miktar) && miktar > 0)
        {
            if (ozellik.Para >= miktar)
            {
                Console.Write("1: Yazı veya 2: Tura seçin: ");
                if (int.TryParse(Console.ReadLine(), out int secim) && (secim == 1 || secim == 2))
                {
                    int sonuc = rnd.Next(0, 2); // 0 = Yazı, 1 = Tura
                    string gelen = sonuc == 0 ? "Yazı" : "Tura";
                    Console.WriteLine($"Gelen: {gelen}");
                    if ((secim == 1 && sonuc == 0) || (secim == 2 && sonuc == 1))
                    {
                        ozellik.Para += miktar * 2;
                        Console.WriteLine("Tebrikler, kazandınız!");
                    }
                    else
                    {
                        ozellik.Para -= miktar;
                        Console.WriteLine("Kaybettiniz.");
                    }
                }
                else Console.WriteLine("Geçersiz seçim!");
            }
            else Console.WriteLine("Yetersiz bakiye!");
        }
        else Console.WriteLine("Geçersiz miktar!");
    }

    private void ZarAtma()
    {
        Console.Write("Yatırmak istediğiniz miktarı girin: ");
        if (int.TryParse(Console.ReadLine(), out int miktar) && miktar > 0)
        {
            if (ozellik.Para >= miktar)
            {
                Console.Write("1 ile 6 arasında bir sayı seçin: ");
                if (int.TryParse(Console.ReadLine(), out int sayi) && sayi >= 1 && sayi <= 6)
                {
                    int sonuc = rnd.Next(1, 7);
                    Console.WriteLine($"Gelen sayı: {sonuc}");
                    if (sonuc == sayi)
                    {
                        ozellik.Para += miktar * 4;
                        Console.WriteLine("Tebrikler, kazandınız!");
                    }
                    else
                    {
                        ozellik.Para -= miktar;
                        Console.WriteLine("Kaybettiniz.");
                    }
                }
                else Console.WriteLine("Geçersiz sayı!");
            }
            else Console.WriteLine("Yetersiz bakiye!");
        }
        else Console.WriteLine("Geçersiz miktar!");
    }
}
