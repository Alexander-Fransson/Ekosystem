using System;
using System.Collections.Generic;
using System.Text;

namespace Ekosystem
{
    class HumboltBläckfisk: Seafalopod
    { 
        //methods
        public void JagaFisk(Fiskstim instance)
        {
            Random rnd = new Random();

            int successrate = rnd.Next(1, 3);

            if (successrate == 1)
            {
                Gräppa(instance.Medlämmar[0]);

                Console.WriteLine($"{Art} {ID} tog fisken {instance.Medlämmar[0].ID}.");
                instance.Medlämmar.RemoveAt(0);

                Äta();
            }
            else
            {
                Console.WriteLine($"{Art} {ID} jagade fisken {instance.Medlämmar[0].ID} men den kom undan.");
            }
        }
        public void ÄndraFärg()
        {
            Random rnd = new Random();

            int alternativ = rnd.Next(1, 3);

            if(this.Färg == "Röd")
            {
                switch (alternativ)
                {
                    case 1:
                        this.Färg = "Svart";
                        break;
                    default:
                        this.Färg = "Vit";
                        break;
                }
            }
            else if(this.Färg == "Svart")
            {
                switch (alternativ)
                {
                    case 1:
                        this.Färg = "Röd";
                        break;
                    default:
                        this.Färg = "Vit";
                        break;
                }
            }
            else
            {
                switch (alternativ)
                {
                    case 1:
                        this.Färg = "Svart";
                        break;
                    default:
                        this.Färg = "Röd";
                        break;
                }
            }

            Console.WriteLine($"{Art} {ID} ändrar sin hudfärg till {Färg}");
        }
        public void Kanibalism(BläckfiskShoal instance)
        {
            Console.WriteLine($"{Art} {ID} Gräppar tag");

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
        public void LäggaHumboltÄgg(List<HumboltBläckfisk> Shoalet, int minID)
        {
            HumboltBläckfisk nyBläckfisk = new HumboltBläckfisk(10,"plop plop", "Humboltbläckfisk",0,minID,"Röd","enfärgad","Hona",50,2);

            Shoalet.Add(nyBläckfisk);

            Föröka();
        }

        //constructor
        public HumboltBläckfisk(double aArmar, string aLäte, string aArt, int aÅlder, int aID, string aFärg, string aMönster, string aKön, double aVikt, double aLängd) : base(aArmar, aLäte, aArt, aÅlder, aID, aFärg, aMönster, aKön, aVikt, aLängd){}

    }
}

