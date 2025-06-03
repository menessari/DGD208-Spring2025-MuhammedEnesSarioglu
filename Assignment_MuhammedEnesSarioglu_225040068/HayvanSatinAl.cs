
using System;
using System.Collections.Generic;
using Assignment_MuhammedEnesSarioglu_225040068;

public class HayvanSatinAl
{
    private HayvanYonetme hayvanYonetme;
    private Ozellik ozellik;
    private int[] fiyatlar;
    private int[] gelirler;

    public HayvanSatinAl(HayvanYonetme yonet, Ozellik ozellik, int[] fiyatlar, int[] gelirler)
    {
        hayvanYonetme = yonet;
        this.ozellik = ozellik;
        this.fiyatlar = fiyatlar;
        this.gelirler = gelirler;
    }

    public void HayvanSatinAlim()
    {
        Console.Clear();
        Console.WriteLine("Animals for purchase:");
        for (int i = 0; i < fiyatlar.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {((PetType)i)} ({fiyatlar[i]} TL)");
        }
        Console.Write("Your choice: ");
        if (int.TryParse(Console.ReadLine(), out int secim) && secim >= 1 && secim <= fiyatlar.Length)
        {
            int fiyat = fiyatlar[secim - 1];
            if (ozellik.Para >= fiyat)
            {
                Console.Write("What should the animal's name be?: ");
                string isim = Console.ReadLine();
                int gelir = gelirler[secim - 1];
                hayvanYonetme.HayvanEkle(new Hayvan(isim, (PetType)(secim - 1), gelir));
                ozellik.Para -= fiyat;
                Console.WriteLine("Purchase succesful.");
            }
            else Console.WriteLine("You are poor.");
        }
        else Console.WriteLine("Wrong entry.");
        Console.ReadKey();
    }
}
