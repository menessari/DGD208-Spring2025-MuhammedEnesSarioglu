
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Assignment_MuhammedEnesSarioglu_225040068;

public class Statlar
{
    private HayvanYonetme hayvanYonetme;
    private bool calisiyor = false;

    public Statlar(HayvanYonetme yonet)
    {
        hayvanYonetme = yonet;
    }

    public async Task Baslat()
    {
        calisiyor = true;
        while (calisiyor)
        {
            hayvanYonetme.StatlariAzalt();
            await Task.Delay(5000);
        }
    }

    public void Durdur()
    {
        calisiyor = false;
    }
}
