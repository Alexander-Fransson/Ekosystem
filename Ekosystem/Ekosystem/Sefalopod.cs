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
            Console.WriteLine($"{Art} {ID} säger Jag kan simma, yay");
        }
        public void Spottabläck(Djur instance)
        {
            Console.WriteLine($"{Art} {ID} spottar bläck på {instance.Art} {instance.ID}");
        }
        public void Gräppa(Djur instance)
        {
            Console.WriteLine($"{Art} {ID} gräppar tag i {instance.Art} {instance.ID}");
        }
        public void Vattenjätt()
        {
            Console.WriteLine($"{Art} {ID} säger {Läte}");
        }
        public void AndasVatten()
        {
            Console.WriteLine($"{Art} {ID} Andas vatten");
        }

        //constructor
        public Seafalopod(double aArmar, string aLäte, string aArt, int aÅlder, int aID, string aFärg, string aMönster, string aKön, double aVikt, double aLängd) : base(aLäte, aArt, aÅlder, aID, aFärg, aMönster, aKön, aVikt, aLängd) 
        {
            this.AntalArmar = aArmar;
        }



    }
}
