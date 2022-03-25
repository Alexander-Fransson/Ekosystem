using System;
using System.Collections.Generic;
using System.Text;

namespace Ekosystem
{
    class Flockar
    {
        //atributes
        public string Flocktyp { get; set; }

        //methods
        public void Resatillsammans()
        {
            Console.WriteLine($"flocken {Flocktyp} reser tillsammans");
        }

        //constructor
        public Flockar(string aFlocktyp)
        {
            this.Flocktyp = aFlocktyp;
        }


    }
}
