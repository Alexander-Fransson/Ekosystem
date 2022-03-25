using System;
using System.Collections.Generic;
using System.Text;

namespace Ekosystem
{
    class Torsk:Fisk
    {
        //methods
        public void Plaska()
        {
            Console.WriteLine($"{Art} {ID} plaskar, Plask Plask");
        }
        public void LäggaTorskÄgg(List<Torsk> FiskStimmet, int minID)
        {
            Torsk NyaTorsken = new Torsk("Blub", "Torsk",0,minID, "Grönish", "Grön med bruna prickar","Hane",0.5,1);

            FiskStimmet.Add(NyaTorsken);

            Föröka();

        }

        //constructor
        public Torsk(string aLäte, string aArt, int aÅlder, int aID, string aFärg, string aMönster, string aKön, double aVikt, double aLängd) : base(aLäte, aArt, aÅlder, aID, aFärg, aMönster, aKön, aVikt, aLängd) { }


    }
}
