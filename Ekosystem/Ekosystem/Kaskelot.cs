using System;
using System.Collections.Generic;
using System.Text;

namespace Ekosystem
{
    class Kaskelot:MarinaDäggdjur
    {
        //methods
        public void JagaBläckfisk(BläckfiskShoal instance)
        {
            Random rnd = new Random();

            int successrate = rnd.Next(1, 3);

            if (successrate == 1)
            {
                Console.WriteLine($"{Art} {ID} tog humboltbläckfisken {instance.Medlämmar[0].ID}.");
                instance.Medlämmar.RemoveAt(0);

                Äta();
            }
            else
            {
                Console.WriteLine($"Späckhuggaren {ID} jagade humboltbläckfisken {instance.Medlämmar[0].ID} men den kom undan.");
            }
        }
        public void Klicka()
        {
            Console.WriteLine($"{Art} {ID} säger KLICK KLICK KLICK i 230db och lysnar på ekot");
        }
        public void BajsaParfym()
        {
            Console.WriteLine($"{Art} {ID} säger leta efter ambegris i din lokala parfymafär");
        }
        public void FödaKaskeloter(List<Kaskelot> KaskPoden, int minID)
        {
            Kaskelot NyKaskelot = new Kaskelot( "KLICK! KLICK! KLICK! i 230 db", "Kaskelot", 0, minID, "MörkGråblå", "Mörkgråblå med vita fläckar runt munnen", "Hona", 500, 15);

            KaskPoden.Add(NyKaskelot);

            Föröka();
        }

        //constructors
        public Kaskelot(string aLäte, string aArt, int aÅlder, int aID, string aFärg, string aMönster, string aKön, double aVikt, double aLängd) : base(aLäte, aArt, aÅlder, aID, aFärg, aMönster, aKön, aVikt, aLängd) { }

    }
}
