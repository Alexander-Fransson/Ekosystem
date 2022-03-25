using System;
using System.Collections.Generic;
using System.Text;

namespace Ekosystem
{
    class Fiskstim: Flockar
    {
        //atributes
        public List<Torsk> Medlämmar { get; set; } = new List<Torsk>();

        //methods
        public void Synkarörelser()
        {
            string Fiskar = Medlämmar[0].Art+" ";

            for (int i = 0; i < Medlämmar.Count; i++)
            {
                Fiskar += Medlämmar[i].ID + ",";
            }
            Fiskar += " synkar sina rörelser";

            Console.WriteLine(Fiskar);
        }

        //constructor
        public Fiskstim(string aFlocktyp) : base(aFlocktyp) { }

    }
}
