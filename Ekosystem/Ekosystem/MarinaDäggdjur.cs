using System;
using System.Collections.Generic;
using System.Text;

namespace Ekosystem
{
    class MarinaDäggdjur : Djur
    {
        //methods
        public void Komunicera()
        {
            Console.WriteLine($"{Art} {ID} säger {Läte}! som betyder Hello world");
        }
        public void AndasLuft()
        {
            Console.WriteLine($"{Art} {ID} säger jag andas luft.");
        }
        public void Uppfostra()
        {
            Console.WriteLine($"{Art} {ID} säger mina barn är väluppfostrade");
        }

        //constructor

        public MarinaDäggdjur(string aLäte, string aArt, int aÅlder, int aID, string aFärg, string aMönster, string aKön, double aVikt, double aLängd):base(aLäte, aArt, aÅlder, aID, aFärg, aMönster, aKön, aVikt, aLängd) { }

    }
}
