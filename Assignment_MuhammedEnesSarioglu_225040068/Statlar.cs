
using System;
using System.Threading.Tasks;

public class Statlar
{
    private HayvanYonetme hayvanYonetme;
    private Ozellik ozellik;
    private bool calisiyor = false;

    public Statlar(HayvanYonetme yonet, Ozellik ozellik)
    {
        hayvanYonetme = yonet;
        this.ozellik = ozellik;
    }

    public async Task Baslat()
    {
        calisiyor = true;
        while (calisiyor)
        {
            hayvanYonetme.StatlariAzalt();
            ozellik.Para += hayvanYonetme.GelirTopla();
            await Task.Delay(5000);
        }
    }

    public void Durdur()
    {
        calisiyor = false;
    }
}
