using System;
using System.Collections.Generic;
using System.Text;

namespace Ekosystem
{
    class Späckhuggare : MarinaDäggdjur
    {
        //atributes
        public double Fenlängd { get; set; }

        //methods
        public void JagaKaskelot(KaskelotPod instance)
        {
            Random rnd = new Random();

            int successrate = rnd.Next(1, 3);

            if (successrate == 1)
            {
                Console.WriteLine($"{Art} {ID} tog kaskelotten {instance.Medlämmar[0].ID}.");
                instance.Medlämmar.RemoveAt(0);

                Äta();
            }
            else
            {
                Console.WriteLine($"{Art} {ID} jagade kaskelotten {instance.Medlämmar[0].ID} men den kom undan.");
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
        public void mobba(VitHaj mobbadhaj)
        {
            Console.WriteLine($"{Art} {ID} mobbar Hajen {mobbadhaj.ID}");
        }
        public void Simma()
        {
            Console.WriteLine($"{Art} {ID} säger Jag kan simma, yay");
        }
        public void FödaSpäckhuggare(List<Späckhuggare> SpäckPoden, int minID)
        {
            Späckhuggare NySpäckhuggare = new Späckhuggare(2, "psssshht haaleow", "Späckhuggare",0,minID,"svartvit", "Svart med vit undersida och vita fläckar bakom ögonen och bakom ryggfenan","Hane",200,10);

            SpäckPoden.Add(NySpäckhuggare);

            Föröka();

        }

        //constructor
        public Späckhuggare(double afena, string aLäte, string aArt, int aÅlder, int aID, string aFärg, string aMönster, string aKön, double aVikt, double aLängd) : base(aLäte, aArt, aÅlder, aID, aFärg, aMönster, aKön, aVikt, aLängd) 
        {
            this.Fenlängd = afena;
        }

    }
}
