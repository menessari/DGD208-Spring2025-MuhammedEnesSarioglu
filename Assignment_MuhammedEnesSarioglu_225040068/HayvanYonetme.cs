
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Assignment_MuhammedEnesSarioglu_225040068;

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
            Console.WriteLine("Hiç hayvanınız yok.");
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
                Console.WriteLine($"{h.Isim} hayatını kaybetti. Allah rahmet eylesin.");
                hayvanlar.Remove(h);
            }
        }
    }
}
