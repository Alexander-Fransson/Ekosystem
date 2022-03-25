using System;
using System.Collections.Generic;
using System.Text;

namespace Ekosystem
{
    class KaskelotPod: Flockar
    {
        //atributes
        public List<Kaskelot> Medlämmar { get; set; } = new List<Kaskelot>();

        //methods
        public void Margarite()
        {
            string Försvarande = Medlämmar[0].Art + " ";

            for (int i = 0; i < Medlämmar.Count; i++)
            {
                Försvarande += Medlämmar[i].ID + ",";
            }
            Försvarande += " försvarar sig med en margarite";

            Console.WriteLine(Försvarande);
        }

        //constructors
        public KaskelotPod(string aFlocktyp) : base(aFlocktyp) { }

    }
}
