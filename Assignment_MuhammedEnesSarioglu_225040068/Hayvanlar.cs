
using Assignment_MuhammedEnesSarioglu_225040068;

public class Hayvan
{
    public string Isim { get; set; }
    public PetType Tur { get; set; }
    public int Hunger { get; set; }
    public int Sleep { get; set; }
    public int Fun { get; set; }
    public int GelirMiktari { get; set; }

    public Hayvan(string isim, PetType tur, int gelir)
    {
        Isim = isim;
        Tur = tur;
        Hunger = 50;
        Sleep = 50;
        Fun = 50;
        GelirMiktari = gelir;
    }

    public bool CanliMi()
    {
        return Hunger > 0 && Sleep > 0 && Fun > 0;
    }

    public void StatAzalt()
    {
        if (Hunger > 0) Hunger--;
        if (Sleep > 0) Sleep--;
        if (Fun > 0) Fun--;
    }

    public void StatArtir(PetStat stat, int miktar)
    {
        if (stat == PetStat.Hunger) Hunger = System.Math.Min(Hunger + miktar, 100);
        if (stat == PetStat.Sleep) Sleep = System.Math.Min(Sleep + miktar, 100);
        if (stat == PetStat.Fun) Fun = System.Math.Min(Fun + miktar, 100);
    }

    public override string ToString()
    {
        return $"{Isim} - Type: {Tur}, Hunger: {Hunger}, Sleep: {Sleep}, Fun: {Fun}";
    }
}
