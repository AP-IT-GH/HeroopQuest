using src_HeroopQuest.Properties;
using System;
using System.Collections.Generic;
using System.Text;

namespace src_HeroopQuest.GameClasses
{
    enum HeldType {Barbaar, Dwerg, Elf, Tovenaar }
    class Held
    {
        public Held(HeldType type, string naam)
        {
            Naam = naam;
            HeldType = type;
            switch (type)
            {
                case HeldType.Barbaar:
                    Beschrijving = Resources.barbaarTekst;
                    AanvalsDobbelstenen = 3;
                    MaxIntelligentie = 2;
                    MaxLichaam = 8;
                    break;
                case HeldType.Dwerg:
                    Beschrijving = Resources.dwergTekst;
                    MaxIntelligentie = 3;
                    MaxLichaam = 7;
                    break;
                case HeldType.Elf:
                    Beschrijving = Resources.elfTekst;
                    MaxIntelligentie = 4;
                    MaxLichaam = 6;
                    break;
                case HeldType.Tovenaar:
                    Beschrijving = Resources.tovenaarTekst;
                    AanvalsDobbelstenen = 1;
                    MaxIntelligentie = 6;
                    MaxLichaam = 4;
                    break;
                default:
                    break;
            }
            HuidigIntelligentie = MaxIntelligentie;
            HuidigLichaam = MaxLichaam;
        }

        public string Naam { get; set; }
        public string Beschrijving { get; private set; }
        public int MaxIntelligentie { get;private set; }
        public int MaxLichaam { get;private set; }
        public int HuidigIntelligentie { get; set; }
        public int HuidigLichaam { get; set; }
        public HeldType HeldType { get; private set; }

        public int AanvalsDobbelstenen { get; private set; } = 2;
        public int VerdigingsDobbelstenen { get; private set; } = 2;
        public int LoopDobbelstenen { get; private set; } = 2;

        public void ToonFiche()
        {
          
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\t\t~~~~{Naam} de {HeldType}~~~~");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Beschrijving);

            Console.WriteLine($"\tLichaamspunten: \t{HuidigLichaam}/{MaxLichaam}");
            Console.WriteLine($"\tIntelligentie: \t\t{HuidigIntelligentie}/{MaxIntelligentie}");
            Console.ResetColor();

        }
    }
}
