using src_HeroopQuest.GameClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace src_HeroopQuest
{
    class HeroQuest
    {
        public static void Play()
        {
            Held held1 = new Held(HeldType.Barbaar, "Conan");
            Held held2 = new Held(HeldType.Tovenaar, "Smith");

            held1.ToonFiche();
            Console.ReadLine();
            held2.ToonFiche();
        }
    }
}
