using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Assignment_MuhammedEnesSarioglu_225040068;

public class Program
{
    public static async Task Main(string[] args)
    {
        OyunTemel oyun = new OyunTemel();
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Ana Menü");
            Console.WriteLine("1. Yeni Oyun");
            Console.WriteLine("2. Save Dosyasını Yükle");
            Console.WriteLine("3. Credits");
            Console.WriteLine("4. Çıkış");
            Console.Write("Seçim: ");
            string secim = Console.ReadLine();

            if (secim == "1") await oyun.YeniOyun();
            else if (secim == "2") await oyun.KayitliOyunuYukle();
            else if (secim == "3") Console.WriteLine("Hazırlayan: Muhammed Enes Sarıoğlu - 225040068 Devam etmek için bir tuşa basın."); 
            else if (secim == "4") break;
            Console.ReadKey();
        }
    }
}
