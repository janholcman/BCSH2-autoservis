using System;

namespace GUI.Objects
{
    public class Adresa
    {
        int Id { get; set; }
        public String Mesto { get; set; }
        public String Ulice { get; set; }
        public String CisloPopisne { get; set; }
        public String Psc { get; set; }

        public Adresa(int id, string mesto, string ulice, string cisloPopisne, String psc)
        {
            Id = id;
            Mesto = mesto;
            Ulice = ulice;
            CisloPopisne = cisloPopisne;
            Psc = psc;
        }

        public Adresa(string mesto, string ulice, string cisloPopisne, String psc)
        {
            Mesto = mesto;
            Ulice = ulice;
            CisloPopisne = cisloPopisne;
            Psc = psc;
        }

        public override string ToString()
        {
            return this.Mesto + ", " + this.Ulice + " " + this.CisloPopisne + ", " + this.Psc;
        }
    }
}
