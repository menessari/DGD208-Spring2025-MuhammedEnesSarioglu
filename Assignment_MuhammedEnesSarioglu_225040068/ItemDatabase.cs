using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_MuhammedEnesSarioglu_225040068
{
    public static class ItemDatabase
    {
        public static List<Item> AllItems = new List<Item>
    {
        // Tavuk ve Kaz
        new Item {
            Name = "Mısır",
            Type = ItemType.Food,
            CompatibleWith = new List<PetType> { PetType.Tavuk, PetType.Kaz },
            AffectedStat = PetStat.Hunger,
            EffectAmount = 10,
            Duration = 1.0f,
            Price = 25
        },
        new Item {
            Name = "Arpa ve Tahıllı Özel Yem",
            Type = ItemType.Food,
            CompatibleWith = new List<PetType> { PetType.Tavuk, PetType.Kaz },
            AffectedStat = PetStat.Hunger,
            EffectAmount = 25,
            Duration = 1.0f,
            Price = 55
        },
        new Item {
            Name = "Top",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetType> { PetType.Tavuk, PetType.Kaz },
            AffectedStat = PetStat.Fun,
            EffectAmount = 10,
            Duration = 1.0f,
            Price = 25
        },
        new Item {
            Name = "Sesli Oyuncak Civciv",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetType> { PetType.Tavuk, PetType.Kaz },
            AffectedStat = PetStat.Fun,
            EffectAmount = 25,
            Duration = 1.0f,
            Price = 55
        },
        new Item {
            Name = "Tahta Kümes",
            Type = ItemType.Energy,
            CompatibleWith = new List<PetType> { PetType.Tavuk, PetType.Kaz },
            AffectedStat = PetStat.Sleep,
            EffectAmount = 10,
            Duration = 2.0f,
            Price = 25
        },
        new Item {
            Name = "Tüylü Kümes",
            Type = ItemType.Energy,
            CompatibleWith = new List<PetType> { PetType.Tavuk, PetType.Kaz },
            AffectedStat = PetStat.Sleep,
            EffectAmount = 25,
            Duration = 2.0f,
            Price = 55
        },

        // Koyun ve İnek
        new Item {
            Name = "Ot",
            Type = ItemType.Food,
            CompatibleWith = new List<PetType> { PetType.Koyun, PetType.Inek },
            AffectedStat = PetStat.Hunger,
            EffectAmount = 10,
            Duration = 1.0f,
            Price = 40
        },
        new Item {
            Name = "Premium Saman",
            Type = ItemType.Food,
            CompatibleWith = new List<PetType> { PetType.Koyun, PetType.Inek },
            AffectedStat = PetStat.Hunger,
            EffectAmount = 25,
            Duration = 1.0f,
            Price = 95
        },
        new Item {
            Name = "Çarkıfelek",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetType> { PetType.Koyun, PetType.Inek },
            AffectedStat = PetStat.Fun,
            EffectAmount = 10,
            Duration = 1.0f,
            Price = 40
        },
        new Item {
            Name = "Çit Süsü",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetType> { PetType.Koyun, PetType.Inek },
            AffectedStat = PetStat.Fun,
            EffectAmount = 25,
            Duration = 1.0f,
            Price = 95
        },
        new Item {
            Name = "Ağaç Altı Uyku",
            Type = ItemType.Energy,
            CompatibleWith = new List<PetType> { PetType.Koyun, PetType.Inek },
            AffectedStat = PetStat.Sleep,
            EffectAmount = 10,
            Duration = 2.0f,
            Price = 40
        },
        new Item {
            Name = "Premium Hizmetli Çiftlik",
            Type = ItemType.Energy,
            CompatibleWith = new List<PetType> { PetType.Koyun, PetType.Inek },
            AffectedStat = PetStat.Sleep,
            EffectAmount = 25,
            Duration = 2.0f,
            Price = 95
        },

        // Arı
        new Item {
            Name = "Mezarlık Çiçeği",
            Type = ItemType.Food,
            CompatibleWith = new List<PetType> { PetType.Ari },
            AffectedStat = PetStat.Hunger,
            EffectAmount = 10,
            Duration = 1.0f,
            Price = 100
        },
        new Item {
            Name = "Villa Bahçesi",
            Type = ItemType.Food,
            CompatibleWith = new List<PetType> { PetType.Ari },
            AffectedStat = PetStat.Hunger,
            EffectAmount = 25,
            Duration = 1.0f,
            Price = 225
        },
        new Item {
            Name = "Saklambaç",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetType> { PetType.Ari },
            AffectedStat = PetStat.Fun,
            EffectAmount = 10,
            Duration = 1.0f,
            Price = 100
        },
        new Item {
            Name = "Bal Havuzu",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetType> { PetType.Ari },
            AffectedStat = PetStat.Fun,
            EffectAmount = 25,
            Duration = 1.0f,
            Price = 225
        },
        new Item {
            Name = "Tek Kişilik Oda",
            Type = ItemType.Energy,
            CompatibleWith = new List<PetType> { PetType.Ari },
            AffectedStat = PetStat.Sleep,
            EffectAmount = 10,
            Duration = 2.0f,
            Price = 100
        },
        new Item {
            Name = "Ballarla Süslenmiş Balayı Odası",
            Type = ItemType.Energy,
            CompatibleWith = new List<PetType> { PetType.Ari },
            AffectedStat = PetStat.Sleep,
            EffectAmount = 25,
            Duration = 2.0f,
            Price = 225
        },

        // Deve Kuşu
        new Item {
            Name = "Böcek",
            Type = ItemType.Food,
            CompatibleWith = new List<PetType> { PetType.DeveKusu },
            AffectedStat = PetStat.Hunger,
            EffectAmount = 10,
            Duration = 1.0f,
            Price = 200
        },
        new Item {
            Name = "Güçlendirilmiş Besin Paketi",
            Type = ItemType.Food,
            CompatibleWith = new List<PetType> { PetType.DeveKusu },
            AffectedStat = PetStat.Hunger,
            EffectAmount = 25,
            Duration = 1.0f,
            Price = 475
        },
        new Item {
            Name = "Devasa Top",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetType> { PetType.DeveKusu },
            AffectedStat = PetStat.Fun,
            EffectAmount = 10,
            Duration = 1.0f,
            Price = 200
        },
        new Item {
            Name = "Kayış",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetType> { PetType.DeveKusu },
            AffectedStat = PetStat.Fun,
            EffectAmount = 25,
            Duration = 1.0f,
            Price = 475
        },
        new Item {
            Name = "Kum",
            Type = ItemType.Energy,
            CompatibleWith = new List<PetType> { PetType.DeveKusu },
            AffectedStat = PetStat.Sleep,
            EffectAmount = 10,
            Duration = 2.0f,
            Price = 200
        },
        new Item {
            Name = "Diamond Elite Platinum Plus Oda",
            Type = ItemType.Energy,
            CompatibleWith = new List<PetType> { PetType.DeveKusu },
            AffectedStat = PetStat.Sleep,
            EffectAmount = 25,
            Duration = 2.0f,
            Price = 475
        }
    };
    }
}
