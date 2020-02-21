using System;
using System.Collections.Generic;
using System.Text;

namespace src_HeroopQuest.GameClasses
{
    enum HeldType { Barbaar, Dwerg, Elf, Tovenaar};
    class Held
    {
        public string Naam { get; set; }
        public string Beschrijving { get; private set; }
        public int MaxIntelligentie { get; private set; }
        public int MaxLichaam { get; private set; }
        public int HuidigIntelligentie { get; set; }
        public int HuidigLichaam { get; set; }
        public HeldType HeldType { get; private set; }
        public int AanvalsDobbelstenen { get; private set; } = 2;
        public int VerdedegingsDobbelstenen { get; private set; } = 2;
        public int LoopDobbelstenen { get; private set; } = 2;

        public Held(HeldType type, string naam)
        {
            Naam = naam;
            HeldType = type;

            switch (type)
            {
                case HeldType.Barbaar:
                    MaxIntelligentie = 2;
                    MaxLichaam = 8;
                    AanvalsDobbelstenen = 3;
                    break;
                case HeldType.Dwerg:
                    MaxIntelligentie = 3;
                    MaxLichaam = 7;
                    break;
                case HeldType.Elf:
                    MaxIntelligentie = 4;
                    MaxLichaam = 6;
                    break;
                case HeldType.Tovenaar:
                    MaxIntelligentie = 6;
                    MaxLichaam = 4;
                    AanvalsDobbelstenen = 1;
                    break;
                default:
                    break;
            }
            HuidigIntelligentie = MaxIntelligentie;
            HuidigLichaam = MaxLichaam;
        }
    }
}
