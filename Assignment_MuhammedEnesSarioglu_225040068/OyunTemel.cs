using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Assignment_MuhammedEnesSarioglu_225040068;

public class OyunTemel
{
    private HayvanYonetme hayvanYonetme = new HayvanYonetme();
    private Statlar statlar;
    private Ozellik ozellik = new Ozellik();
    private Save kayit = new Save();

    public async Task YeniOyun()
    {
        await OyunuBaslat();
    }

    public async Task KayitliOyunuYukle()
    {
        var (hayvanlar, para, sure) = kayit.Yukle();
        hayvanYonetme.hayvanlar = hayvanlar;
        ozellik.Para = para;
        ozellik.Baslat();
        ozellik.Baslat();
        ozellik.Baslat();
        await OyunuBaslat();
    }

    private async Task OyunuBaslat()
    {
        statlar = new Statlar(hayvanYonetme);
        _ = statlar.Baslat();
        ozellik.Baslat();

        while (true)
        {
            Console.Clear();
            Console.WriteLine(ozellik.SureGoster());
            Console.WriteLine("1. Hayvan Satın Al");
            Console.WriteLine("2. Hayvanları Gör");
            Console.WriteLine("3. Oyunu Kaydet");
            Console.WriteLine("4. Ana Menüye Dön");
            Console.Write("Seçim: ");
            string sec = Console.ReadLine();

            if (sec == "1") HayvanSatinal();
            else if (sec == "2") { Console.Clear(); hayvanYonetme.HayvanlariGoster(); Console.ReadKey(); }
            else if (sec == "3") kayit.Kaydet(hayvanYonetme.hayvanlar, ozellik.Para, TimeSpan.FromSeconds(0));
            else if (sec == "4") break;
        }

        statlar.Durdur();
    }

    private void HayvanSatinal()
    {
        Console.Clear();
        Console.WriteLine("Satın alınabilecek hayvanlar:");
        for (int i = 0; i < fiyatlar.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {((PetType)i)} ({fiyatlar[i]} TL)");
        }
        Console.Write("Seçim: ");
        if (int.TryParse(Console.ReadLine(), out int secim) && secim >= 1 && secim <= fiyatlar.Length)
        {
            int fiyat = fiyatlar[secim - 1];
            if (ozellik.Para >= fiyat)
            {
                Console.Write("Hayvana isim verin: ");
                string isim = Console.ReadLine();
                hayvanYonetme.HayvanEkle(new Hayvan(isim, (PetType)(secim - 1)));
                ozellik.Para -= fiyat;
                Console.WriteLine("Satın alım başarılı.");
            }
            else Console.WriteLine("Yetersiz bakiye.");
        }
        else Console.WriteLine("Geçersiz seçim, geçerli bir seçim girin.");
        Console.ReadKey();
    }

    private int[] fiyatlar = { 150, 1050, 1325, 1525, 2625, 3875 };
}
