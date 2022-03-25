using System;
using System.Collections.Generic;
using System.Text;

namespace Ekosystem
{
    class VitHaj:Fisk
    {
        //methods
        public void JagaFisk(Fiskstim instance)
        {
            Random rnd = new Random();

            int successrate = rnd.Next(1, 3);

            if (successrate == 1)
            {
                Console.WriteLine($"{Art} {ID} tog fisken {instance.Medlämmar[0].ID}.");
                instance.Medlämmar.RemoveAt(0);

                Äta();
            }
            else
            {
                Console.WriteLine($"{Art} {ID} jagade fisken {instance.Medlämmar[0].ID} men den kom undan.");
            }
        }
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
                Console.WriteLine($"{Art} {ID} jagade humboltbläckfisken {instance.Medlämmar[0].ID} men den kom undan.");
            }
        }
        public void LuktaBlod()
        {
            Console.WriteLine($"{Art} {ID} säger Sniff sniff, det luktar blod");
        }
        public void Elektroreception()
        {
            Console.WriteLine($"{Art} {ID} säger ni kan inte göma er jag känner era elektriska signaler");
        }
        public void ÄtaNyföddaHajungar()
        {
            Föröka();
            Console.WriteLine($"{Art} {ID} äter sina barn");
        }

        //constructor
        public VitHaj(string aLäte, string aArt, int aÅlder, int aID, string aFärg, string aMönster, string aKön, double aVikt, double aLängd) : base(aLäte, aArt, aÅlder, aID, aFärg, aMönster, aKön, aVikt, aLängd) { }



    }
}
