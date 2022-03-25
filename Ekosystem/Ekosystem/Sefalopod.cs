using System;
using System.Collections.Generic;
using System.Text;

namespace Ekosystem
{
    class Seafalopod : Djur
    {
        //attributes
        public double AntalArmar { get; set; }

        //methods
        public void Simma()
        {
            Console.WriteLine($"{Art} {ID} s�ger Jag kan simma, yay");
        }
        public void Spottabl�ck(Djur instance)
        {
            Console.WriteLine($"{Art} {ID} spottar bl�ck p� {instance.Art} {instance.ID}");
        }
        public void Gr�ppa(Djur instance)
        {
            Console.WriteLine($"{Art} {ID} gr�ppar tag i {instance.Art} {instance.ID}");
        }
        public void Vattenj�tt()
        {
            Console.WriteLine($"{Art} {ID} s�ger {L�te}");
        }
        public void AndasVatten()
        {
            Console.WriteLine($"{Art} {ID} Andas vatten");
        }

        //constructor
        public Seafalopod(double aArmar, string aL�te, string aArt, int a�lder, int aID, string aF�rg, string aM�nster, string aK�n, double aVikt, double aL�ngd) : base(aL�te, aArt, a�lder, aID, aF�rg, aM�nster, aK�n, aVikt, aL�ngd) 
        {
            this.AntalArmar = aArmar;
        }



    }
}
