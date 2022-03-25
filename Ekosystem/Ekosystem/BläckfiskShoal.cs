using System;
using System.Collections.Generic;
using System.Text;

namespace Ekosystem
{
    class BläckfiskShoal : Flockar
    {
        //arguments
        public List<HumboltBläckfisk> Medlämmar { get; set; } = new List<HumboltBläckfisk>();

        //methods
        public void BlinkaTillsammans()
        {
            if (Medlämmar.Count > 1)
            {
                string Blinkande = Medlämmar[0].Art + " ";

                for (int i = 0; i < Medlämmar.Count; i++)
                {
                    Blinkande += Medlämmar[i].ID + ",";
                }
                Blinkande += " Blinkar tillsammans";

                Console.WriteLine(Blinkande);
            }
            else
            {
                Console.WriteLine($"{Medlämmar[0].Art} {Medlämmar[0].ID} blinkar ensam");
            }
        }

        //constructor
        public BläckfiskShoal(string aFlocktyp) : base(aFlocktyp){}
    }
}
