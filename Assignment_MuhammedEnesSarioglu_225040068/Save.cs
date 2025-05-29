using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

using Assignment_MuhammedEnesSarioglu_225040068;


public class Save
{
    private const string dosya = "gameSave.json";

    public void Kaydet(List<Hayvan> hayvanlar, int para, TimeSpan gecenSure)
    {
        var veri = new SaveData
        {
            Hayvanlar = hayvanlar,
            Para = para,
            Sure = gecenSure
        };
        var json = JsonConvert.SerializeObject(veri, Formatting.Indented);
        File.WriteAllText(dosya, json);
    }

    public (List<Hayvan>, int, TimeSpan) Yukle()
    {
        if (!File.Exists(dosya)) return (new List<Hayvan>(), 150, TimeSpan.Zero);
        var json = File.ReadAllText(dosya);
        var veri = JsonConvert.DeserializeObject<SaveData>(json);
        return (veri.Hayvanlar, veri.Para, veri.Sure);
    }

    private class SaveData
    {
        public List<Hayvan> Hayvanlar { get; set; }
        public int Para { get; set; }
        public TimeSpan Sure { get; set; }
    }
}
