
using System;
using System.Linq;
using System.Collections.Generic;
using Assignment_MuhammedEnesSarioglu_225040068;

public class MarketAlis
{
    private HayvanYonetme hayvanYonetme;
    private Ozellik ozellik;

    public MarketAlis(HayvanYonetme yonet, Ozellik ozellik)
    {
        hayvanYonetme = yonet;
        this.ozellik = ozellik;
    }

    public void MarketAlisAlim()
    {
        Console.Clear();
        var hayvanlar = hayvanYonetme.hayvanlar;
        if (hayvanlar.Count == 0)
        {
            Console.WriteLine("You don't have any animal.");
            Console.ReadKey();
            return;
        }

        Console.WriteLine("Your animals:");
        for (int i = 0; i < hayvanlar.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {hayvanlar[i].ToString()}");
        }

        Console.Write("Choose a animal: ");
        if (int.TryParse(Console.ReadLine(), out int secim) && secim >= 1 && secim <= hayvanlar.Count)
        {
            var secilenHayvan = hayvanlar[secim - 1];
            var uyumluItemlar = ItemDatabase.AllItems.Where(x => x.CompatibleWith.Contains(secilenHayvan.Tur)).ToList();

            Console.Clear();
            Console.WriteLine("Products Available for Purchase:");
            for (int i = 0; i < uyumluItemlar.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {uyumluItemlar[i].Name} - {uyumluItemlar[i].Price} TL - +{uyumluItemlar[i].EffectAmount} {uyumluItemlar[i].AffectedStat}");
            }

            Console.Write("Choose a product: ");
            if (int.TryParse(Console.ReadLine(), out int itemSecimi) && itemSecimi >= 1 && itemSecimi <= uyumluItemlar.Count)
            {
                var item = uyumluItemlar[itemSecimi - 1];
                if (ozellik.Para >= item.Price)
                {
                    secilenHayvan.StatArtir(item.AffectedStat, item.EffectAmount);
                    ozellik.Para -= item.Price;
                    Console.WriteLine("Sale was successful and the product was used.");
                }
                else Console.WriteLine("You are poor.");
            }
            else Console.WriteLine("Wrong entry.");
        }
        else Console.WriteLine("Wrong entry. Enter a positive integer.");

        Console.ReadKey();
    }
}
