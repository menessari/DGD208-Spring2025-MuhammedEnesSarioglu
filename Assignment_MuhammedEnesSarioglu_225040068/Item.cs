﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_MuhammedEnesSarioglu_225040068
{
    public class Item
    {
        // Name of the item, to be displayed in the game
        public string Name { get; set; }

        // Item type, determines which situations it can be used in
        public ItemType Type { get; set; }

        // Which pets it can be used in
        public List<PetType> CompatibleWith { get; set; }

        // Which stat of the pet the item affects
        public PetStat AffectedStat { get; set; }

        // How much it affects
        public int EffectAmount { get; set; }

        // How long it takes for the item to be used
        public float Duration { get; set; }

        // Para birimi
        public int Price { get; set; }

        public Item() { }
    }
}
