
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Assignment_MuhammedEnesSarioglu_225040068;

public class OyunTemel
{
    private HayvanYonetme hayvanYonetme = new HayvanYonetme();
    private Statlar statlar;
    private Ozellik ozellik = new Ozellik();
    private Save kayit = new Save();
    private Kumarhane kumarhane;

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
        ozellik.Baslat();
        await OyunuBaslat();
    }

    private async Task OyunuBaslat()
    {
        statlar = new Statlar(hayvanYonetme, ozellik);
        kumarhane = new Kumarhane(ozellik);
        _ = statlar.Baslat();
        ozellik.Baslat();

        while (true)
        {
            Console.Clear();
            Console.WriteLine(ozellik.SureGoster());
            Console.WriteLine("1. Hayvan Satın Al");
            Console.WriteLine("2. Hayvanları Gör");
            Console.WriteLine("3. Market");
            Console.WriteLine("4. Kumarhane");
            Console.WriteLine("5. Oyunu Kaydet");
            Console.WriteLine("6. Ana Menüye Dön");
            Console.Write("Seçim: ");
            string sec = Console.ReadLine();

            if (sec == "1") HayvanSatinal();
            else if (sec == "2") { Console.Clear(); hayvanYonetme.HayvanlariGoster(); Console.ReadKey(); }
            else if (sec == "3") Market();
            else if (sec == "4") kumarhane.Ac();
            else if (sec == "5") kayit.Kaydet(hayvanYonetme.hayvanlar, ozellik.Para, TimeSpan.FromSeconds(0));
            else if (sec == "6") break;
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
                int gelir = gelirler[secim - 1];
                hayvanYonetme.HayvanEkle(new Hayvan(isim, (PetType)(secim - 1), gelir));
                ozellik.Para -= fiyat;
                Console.WriteLine("Satın alındı!");
            }
            else Console.WriteLine("Yetersiz bakiye!");
        }
        else Console.WriteLine("Geçersiz seçim!");
        Console.ReadKey();
    }

    private void Market()
    {
        Console.Clear();
        var hayvanlar = hayvanYonetme.hayvanlar;
        if (hayvanlar.Count == 0)
        {
            Console.WriteLine("Hiç hayvanınız yok.");
            Console.ReadKey();
            return;
        }

        Console.WriteLine("Hayvanlarınız:");
        for (int i = 0; i < hayvanlar.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {hayvanlar[i].ToString()}");
        }

        Console.Write("Bir hayvan seçin: ");
        if (int.TryParse(Console.ReadLine(), out int secim) && secim >= 1 && secim <= hayvanlar.Count)
        {
            var secilenHayvan = hayvanlar[secim - 1];
            var uyumluItemlar = ItemDatabase.AllItems.Where(x => x.CompatibleWith.Contains(secilenHayvan.Tur)).ToList();

            Console.Clear();
            Console.WriteLine("Kullanılabilir itemlar:");
            for (int i = 0; i < uyumluItemlar.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {uyumluItemlar[i].Name} - {uyumluItemlar[i].Price} TL - +{uyumluItemlar[i].EffectAmount} {uyumluItemlar[i].AffectedStat}");
            }

            Console.Write("Bir item seçin: ");
            if (int.TryParse(Console.ReadLine(), out int itemSecimi) && itemSecimi >= 1 && itemSecimi <= uyumluItemlar.Count)
            {
                var item = uyumluItemlar[itemSecimi - 1];
                if (ozellik.Para >= item.Price)
                {
                    secilenHayvan.StatArtir(item.AffectedStat, item.EffectAmount);
                    ozellik.Para -= item.Price;
                    Console.WriteLine("Item başarıyla kullanıldı!");
                }
                else Console.WriteLine("Yetersiz bakiye!");
            }
            else Console.WriteLine("Geçersiz seçim!");
        }
        else Console.WriteLine("Geçersiz seçim!");

        Console.ReadKey();
    }
}
