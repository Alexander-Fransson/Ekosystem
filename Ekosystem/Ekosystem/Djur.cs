using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Ekosystem
{
    class Djur
    {
        //atributes
        public string Läte { get; set; }
        public string Art { get; set; }
        public int Ålder { get; set; }
        public int ID { get; set; }
        public string Färg { get; set; }
        public string Mönster { get; set; }
        public string Kön { get; set; }
        public double Vikt { get; set; }
        public double Längd { get; set; }

        //constructor
        public Djur(string aLäte, string aArt, int aÅlder, int aID, string aFärg, string aMönster, string aKön, double aVikt, double aLängd)
        {
            this.Läte = aLäte;
            this.Art = aArt;
            this.Ålder = aÅlder;
            this.ID = aID;
            this.Färg = aFärg;
            this.Mönster = aMönster;
            this.Kön = aKön;
            this.Vikt = aVikt;
            this.Längd = aLängd;
        }

        //methods
        public void Äta()
        {
            Console.WriteLine( $"{Art} {ID} äter och säger nam nam nam, det är gott");
        }
        public void Sova()
        {
            Console.WriteLine($"{Art} {ID} sover \nZZZZZZZZZzzzzzzzz");
        }
        public void Låta()
        {
            Console.WriteLine($"{Art} {ID} säger {Läte}");
        }
        public void Föröka()
        {
            Console.WriteLine($"{Art} {ID} förökar sig.");
        }
    }
}
