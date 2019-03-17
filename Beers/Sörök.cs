using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beers
{
     class Sörök
    {
        public string Neve { get; private set; }
        public double Alkoholfok { get; private set; }
        public string Íz { get; private set; }
        public string Fajta { get; private set; }
        public string Származás { get; private set; }
        public string Fogyasztás { get; private set; }
        public int Ár { get; private set; }
        public int Minőség { get; private set; }

        public Sörök(string neve, double alkoholfok, string íz, string fajta, string származás, string fogyasztás, int ár, int minőség)
            {
            Neve = neve;
            Alkoholfok = alkoholfok;
            Íz = íz;
            Fajta = fajta;
            Származás = származás;
            Fogyasztás = fogyasztás;
            Ár = ár;
            Minőség = minőség;
            }

        public override string ToString()
        {
            return Neve;
        }

    }
}
