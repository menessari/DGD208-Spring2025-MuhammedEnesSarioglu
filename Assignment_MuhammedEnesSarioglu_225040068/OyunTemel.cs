
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

public class OyunTemel
{
    private HayvanYonetme hayvanYonetme = new HayvanYonetme();
    private Statlar statlar;
    private Ozellik ozellik = new Ozellik();
    private Save kayit = new Save();
    private Kumarhane kumarhane;
    private Minigame minigame;

    private int[] fiyatlar = { 150, 1050, 1325, 1525, 2625, 3875 };
    private int[] gelirler = { 10, 15, 22, 25, 45, 100 };

    public async Task YeniOyun()
    {
        await OyunuBaslat();
    }

    public async Task KayitliOyunuYukle()
    {
        var (hayvanlar, para, sure) = kayit.Yukle();
        hayvanYonetme.hayvanlar = hayvanlar;
        ozellik.Para = para;
        ozellik.Baslat(sure);
        await OyunuBaslat();
    }

    private async Task OyunuBaslat()
    {
        statlar = new Statlar(hayvanYonetme, ozellik);
        kumarhane = new Kumarhane(ozellik);
        minigame = new Minigame(ozellik);
        _ = statlar.Baslat();
        ozellik.Baslat();

        while (true)
        {
            Console.Clear();
            Console.WriteLine(ozellik.SureGoster());
            Console.WriteLine("\n--> ANIMAL FORTUNE <--");
            Console.WriteLine("\n1. Buy Animal");
            Console.WriteLine("2. Your Animals");
            Console.WriteLine("3. Market");
            Console.WriteLine("4. Casino");
            Console.WriteLine("5. Minigames");
            Console.WriteLine("6. Save Game");
            Console.WriteLine("7. Return to Main Menu");
            Console.Write("Your choice: ");
            string sec = Console.ReadLine();

            if (sec == "1")
            {
                HayvanSatinAl hayvanSatinAl = new HayvanSatinAl(hayvanYonetme, ozellik, fiyatlar, gelirler);
                hayvanSatinAl.HayvanSatinAlim();
            }
            else if (sec == "2") { Console.Clear(); hayvanYonetme.HayvanlariGoster(); Console.ReadKey(); }
            else if (sec == "3")
            {
                MarketAlis marketAlis = new MarketAlis(hayvanYonetme, ozellik);
                marketAlis.MarketAlisAlim();
            }
            else if (sec == "4") kumarhane.Ac();
            else if (sec == "5") minigame.MinigameGir();
            else if (sec == "6") kayit.Kaydet(hayvanYonetme.hayvanlar, ozellik.Para, ozellik.SureGosterTimeSpan());
            else if (sec == "7") break;
        }

        statlar.Durdur();
    }
}
