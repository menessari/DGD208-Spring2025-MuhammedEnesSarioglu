
using System;
using System.Diagnostics;

public class Ozellik
{
    private Stopwatch kronometre = new Stopwatch();
    public int Para { get; set; } = 150;
    private TimeSpan gecenSure = TimeSpan.Zero;

    public void Baslat()
    {
        kronometre.Start();
    }

    public void Baslat(TimeSpan kayitliSure)
    {
        gecenSure = kayitliSure;
        kronometre.Start();
    }

    public string SureGoster()
    {
        var ts = gecenSure + kronometre.Elapsed;
        return $"Elapsed Time: {ts.Minutes:D2}:{ts.Seconds:D2} | Money: {Para} TL";
    }

    public TimeSpan SureGosterTimeSpan()
    {
        return gecenSure + kronometre.Elapsed;
    }
}
