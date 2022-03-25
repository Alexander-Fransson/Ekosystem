using System;
using System.Collections.Generic;
using System.Text;

namespace Ekosystem
{
    class SpäckhuggarPod: Flockar
    {
        //atributes
        public List<Späckhuggare> Medlämmar { get; set; } = new List<Späckhuggare>();

        //methods
        public void Leka()
        {
            if (Medlämmar.Count > 1)
            {
                string Lekande = Medlämmar[0].Art + " ";

                for (int i = 0; i < Medlämmar.Count; i++)
                {
                    Lekande += Medlämmar[i].ID + ",";
                }
                Lekande += " Leker tillsammans";

                Console.WriteLine(Lekande);
            }
            else
            {
                Console.WriteLine($"{Medlämmar[0].Art} {Medlämmar[0].ID} Leker med sig själv");
            }
        }

        //constructor
        public SpäckhuggarPod(string aFlocktyp) : base(aFlocktyp) { }

    }
}
