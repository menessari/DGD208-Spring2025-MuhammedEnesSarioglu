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
        // Chicken ve Goose
        new Item {
            Name = "Corn",
            Type = ItemType.Food,
            CompatibleWith = new List<PetType> { PetType.Chicken, PetType.Goose },
            AffectedStat = PetStat.Hunger,
            EffectAmount = 10,
            Duration = 1.0f,
            Price = 25
        },
        new Item {
            Name = "Special Feed with Barley and Grains",
            Type = ItemType.Food,
            CompatibleWith = new List<PetType> { PetType.Chicken, PetType.Goose },
            AffectedStat = PetStat.Hunger,
            EffectAmount = 25,
            Duration = 1.0f,
            Price = 55
        },
        new Item {
            Name = "Ball",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetType> { PetType.Chicken, PetType.Goose },
            AffectedStat = PetStat.Fun,
            EffectAmount = 10,
            Duration = 1.0f,
            Price = 25
        },
        new Item {
            Name = "Sound Toy Chick",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetType> { PetType.Chicken, PetType.Goose },
            AffectedStat = PetStat.Fun,
            EffectAmount = 25,
            Duration = 1.0f,
            Price = 55
        },
        new Item {
            Name = "Wooden Coop",
            Type = ItemType.Energy,
            CompatibleWith = new List<PetType> { PetType.Chicken, PetType.Goose },
            AffectedStat = PetStat.Sleep,
            EffectAmount = 10,
            Duration = 2.0f,
            Price = 25
        },
        new Item {
            Name = "Feathered Fowl",
            Type = ItemType.Energy,
            CompatibleWith = new List<PetType> { PetType.Chicken, PetType.Goose },
            AffectedStat = PetStat.Sleep,
            EffectAmount = 25,
            Duration = 2.0f,
            Price = 55
        },

        // Sheep ve İnek
        new Item {
            Name = "Grass",
            Type = ItemType.Food,
            CompatibleWith = new List<PetType> { PetType.Sheep, PetType.Cow },
            AffectedStat = PetStat.Hunger,
            EffectAmount = 10,
            Duration = 1.0f,
            Price = 40
        },
        new Item {
            Name = "Premium Straw",
            Type = ItemType.Food,
            CompatibleWith = new List<PetType> { PetType.Sheep, PetType.Cow },
            AffectedStat = PetStat.Hunger,
            EffectAmount = 25,
            Duration = 1.0f,
            Price = 95
        },
        new Item {
            Name = "Wheel of Fortune",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetType> { PetType.Sheep, PetType.Cow },
            AffectedStat = PetStat.Fun,
            EffectAmount = 10,
            Duration = 1.0f,
            Price = 40
        },
        new Item {
            Name = "Hedge Ornament",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetType> { PetType.Sheep, PetType.Cow },
            AffectedStat = PetStat.Fun,
            EffectAmount = 25,
            Duration = 1.0f,
            Price = 95
        },
        new Item {
            Name = "Sleeping Under the Tree",
            Type = ItemType.Energy,
            CompatibleWith = new List<PetType> { PetType.Sheep, PetType.Cow },
            AffectedStat = PetStat.Sleep,
            EffectAmount = 10,
            Duration = 2.0f,
            Price = 40
        },
        new Item {
            Name = "Premium Serviced Farm",
            Type = ItemType.Energy,
            CompatibleWith = new List<PetType> { PetType.Sheep, PetType.Cow },
            AffectedStat = PetStat.Sleep,
            EffectAmount = 25,
            Duration = 2.0f,
            Price = 95
        },

        // Arı
        new Item {
            Name = "Graveyard Flower",
            Type = ItemType.Food,
            CompatibleWith = new List<PetType> { PetType.Bee },
            AffectedStat = PetStat.Hunger,
            EffectAmount = 10,
            Duration = 1.0f,
            Price = 100
        },
        new Item {
            Name = "Villa Garden",
            Type = ItemType.Food,
            CompatibleWith = new List<PetType> { PetType.Bee },
            AffectedStat = PetStat.Hunger,
            EffectAmount = 25,
            Duration = 1.0f,
            Price = 225
        },
        new Item {
            Name = "Hide and Seek",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetType> { PetType.Bee },
            AffectedStat = PetStat.Fun,
            EffectAmount = 10,
            Duration = 1.0f,
            Price = 100
        },
        new Item {
            Name = "Honey Pool",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetType> { PetType.Bee },
            AffectedStat = PetStat.Fun,
            EffectAmount = 25,
            Duration = 1.0f,
            Price = 225
        },
        new Item {
            Name = "Room",
            Type = ItemType.Energy,
            CompatibleWith = new List<PetType> { PetType.Bee },
            AffectedStat = PetStat.Sleep,
            EffectAmount = 10,
            Duration = 2.0f,
            Price = 100
        },
        new Item {
            Name = "Honeymoon Room Decorated with Honey",
            Type = ItemType.Energy,
            CompatibleWith = new List<PetType> { PetType.Bee },
            AffectedStat = PetStat.Sleep,
            EffectAmount = 25,
            Duration = 2.0f,
            Price = 225
        },

        // Deve Kuşu
        new Item {
            Name = "Bug",
            Type = ItemType.Food,
            CompatibleWith = new List<PetType> { PetType.Ostrich },
            AffectedStat = PetStat.Hunger,
            EffectAmount = 10,
            Duration = 1.0f,
            Price = 200
        },
        new Item {
            Name = "Fortified Nutrition Pack",
            Type = ItemType.Food,
            CompatibleWith = new List<PetType> { PetType.Ostrich },
            AffectedStat = PetStat.Hunger,
            EffectAmount = 25,
            Duration = 1.0f,
            Price = 475
        },
        new Item {
            Name = "Big Ball",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetType> { PetType.Ostrich },
            AffectedStat = PetStat.Fun,
            EffectAmount = 10,
            Duration = 1.0f,
            Price = 200
        },
        new Item {
            Name = "Strap",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetType> { PetType.Ostrich },
            AffectedStat = PetStat.Fun,
            EffectAmount = 25,
            Duration = 1.0f,
            Price = 475
        },
        new Item {
            Name = "Sand",
            Type = ItemType.Energy,
            CompatibleWith = new List<PetType> { PetType.Ostrich },
            AffectedStat = PetStat.Sleep,
            EffectAmount = 10,
            Duration = 2.0f,
            Price = 200
        },
        new Item {
            Name = "Diamond Elite Platinum Plus Room",
            Type = ItemType.Energy,
            CompatibleWith = new List<PetType> { PetType.Ostrich },
            AffectedStat = PetStat.Sleep,
            EffectAmount = 25,
            Duration = 2.0f,
            Price = 475
        }
    };
    }
}
