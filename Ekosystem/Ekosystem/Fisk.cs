using System;
using System.Collections.Generic;
using System.Text;

namespace Ekosystem
{
    class Fisk : Djur
    {
        //methods
        public void Simma()
        {
            Console.WriteLine($"{Art} {ID} säger Jag kan simma");
        }
        public void Sidolinjeorgan()
        {
            Console.WriteLine($"{Art} {ID} säger Jag kan känna små tryckskilnader i vattnet");
        }
        public void AndasVatten()
        {
            Console.WriteLine($"{Art} {ID} säger Jag kan andas vatten");
        }

        //constructor
        public Fisk(string aLäte, string aArt, int aÅlder, int aID, string aFärg, string aMönster, string aKön, double aVikt, double aLängd) : base(aLäte,  aArt,  aÅlder,  aID,  aFärg,  aMönster,  aKön,  aVikt,  aLängd){}
    }
}
