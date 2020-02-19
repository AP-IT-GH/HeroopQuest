using src_HeroopQuest.Properties;
using System;
using System.Collections.Generic;
using System.Text;

namespace src_HeroopQuest.GameClasses
{
    
    enum HeldType { Barbaar, Dwerg, Elf, Tovenaar}
    class Held
    {
        public Held(HeldType typein, string naamin)
        {
            Naam = naamin;
            switch (typein)
            {
                case HeldType.Barbaar:
                    Beschrijving = Resources.barbaarBeschrijving;
                    AanvalsDobbelstenen = 3;
                    MaxIntelligentie = 2;
                    MaxLichaamspunten = 8;
                    break;
                case HeldType.Dwerg:
                    Beschrijving = Resources.dwergBeschrijving;
                    MaxIntelligentie = 3;
                    MaxLichaamspunten = 7;
                    break;
                case HeldType.Elf:
                    Beschrijving = Resources.elfBeschrijving;
                    MaxIntelligentie = 4;
                    MaxLichaamspunten = 6;
                    break;
                case HeldType.Tovenaar:
                    Beschrijving = Resources.tovenaarBeschrijving;
                    AanvalsDobbelstenen = 1;
                    MaxIntelligentie = 6;
                    MaxLichaamspunten = 4;
                    break;
                default:
                    break;
            }

            HuidigeIntelligentie = MaxIntelligentie;
            HuidigeLichaamsPunten = MaxLichaamspunten;
        }

        internal void ToonFiche()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\t\t~~~~{Naam} de {Type}~~~~");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(Beschrijving);

            Console.WriteLine($"\tLichaamspunten: \t{HuidigeLichaamsPunten}/{MaxLichaamspunten}" );
            Console.WriteLine($"\tIntelligentie: \t\t{HuidigeIntelligentie}/{MaxIntelligentie}");
            Console.ResetColor();
         
        }

        public HeldType Type { get; set; }
        public string Naam { get; private set; }
        public string Beschrijving { get; set; }
        public int MaxIntelligentie { get; private set; }
        public int MaxLichaamspunten { get; private set; }
        public int HuidigeIntelligentie { get; set; }
        public int HuidigeLichaamsPunten { get; set; }

        public int AanvalsDobbelstenen { get; private set; } = 2;
        public int VerdedigingsDobbelstenen { get; private set; } = 2;
        public int LoopDobbelstenen { get; private set; } = 2;

        

    }
}
