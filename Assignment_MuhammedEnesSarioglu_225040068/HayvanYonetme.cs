﻿
using System;
using System.Collections.Generic;
using System.Linq;

public class HayvanYonetme
{
    public List<Hayvan> hayvanlar = new List<Hayvan>();

    public void HayvanEkle(Hayvan h)
    {
        hayvanlar.Add(h);
    }

    public void HayvanlariGoster()
    {
        if (hayvanlar.Count == 0)
        {
            Console.WriteLine("You don't have any animals.");
            return;
        }

        foreach (var h in hayvanlar)
        {
            Console.WriteLine(h.ToString());
        }
    }

    public void StatlariAzalt()
    {
        foreach (var h in hayvanlar.ToList())
        {
            h.StatAzalt();
            if (!h.CanliMi())
            {
                Console.WriteLine($"{h.Isim} passed away. God rest his soul.");
                hayvanlar.Remove(h);
            }
        }
    }

    public int GelirTopla()
    {
        int toplam = 0;
        foreach (var h in hayvanlar)
        {
            if (h.CanliMi()) toplam += h.GelirMiktari;
        }
        return toplam;
    }
}
