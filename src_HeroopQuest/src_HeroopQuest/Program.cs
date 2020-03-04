using src_HeroopQuest.GameClasses;
using src_HeroopQuest.Properties;
using System;
using System.Collections.Generic;

namespace src_HeroopQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Resources.barbaarTekst);

            Held held1 = new Held(HeldType.Barbaar, "Conan");
            Held held2 = new Held(HeldType.Tovenaar, "Bart");
            Held held3 = new Held(HeldType.Dwerg, "Gimli");

            held1.ToonFiche();
            held2.ToonFiche();

            List<Held> deHelden = new List<Held>();
            deHelden.Add(held1);
            deHelden.Add(held2);

            deHelden.Insert(0, held3);
            deHelden.RemoveAt(1);
            Console.Clear();


            foreach (var heldje in deHelden)
            {
                heldje.ToonFiche();
            }

            for (int i = 0; i < deHelden.Count; i++)
            {
                deHelden[i].ToonFiche();
            }



            //static
            //heldlijst creeren en als resultaat teruggeven 
        }
    }
}
