using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppCorvinMoziApp
{
    internal class Terem
    {
        string nev;
        int sorok;
        int szekekSzama;
        int ulesek;
        char nevadokep;

        public string Nev { get => nev; set => nev = value; }
        public int Sorok { get => sorok; set => sorok = value; }
        public int SzekekSzama { get => szekekSzama; set => szekekSzama = value; }
        public int Ulesek { get => ulesek; set => ulesek = value; }
        public char Nevadokep { get => nevadokep; set => nevadokep = value; }

        public Terem(string nev, int sorok, int szekekSzama, int ulesek, char nevadokep)
        {
            this.nev = nev;
            this.sorok = sorok;
            this.szekekSzama = szekekSzama;
            this.ulesek = ulesek;
            this.nevadokep = nevadokep;
        }

    }
}
