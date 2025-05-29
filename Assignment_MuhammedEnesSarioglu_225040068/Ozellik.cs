using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

using Assignment_MuhammedEnesSarioglu_225040068;

public class Ozellik
{
    private Stopwatch kronometre = new Stopwatch();
    public int Para { get; set; } = 150;

    public void Baslat()
    {
        kronometre.Start();
    }

    public string SureGoster()
    {
        var ts = kronometre.Elapsed;
        return $"Geçen Süre: {ts.Minutes:D2}:{ts.Seconds:D2} | Bakiye: {Para} TL";
    }
}
