using src_HeroopQuest.GameClasses;
using System;

namespace src_HeroopQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            Held held1 = new Held(HeldType.Barbaar, "Conan");
            Held held2 = new Held(HeldType.Tovenaar, "Bart");

            Console.WriteLine(held1.AanvalsDobbelstenen);
            Console.WriteLine(held2.HeldType);
        }
    }
}
