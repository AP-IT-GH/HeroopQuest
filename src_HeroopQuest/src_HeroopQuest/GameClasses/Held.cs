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
    }
}
