using System;

namespace GUI.Objects
{
    internal class Adresa
    {
        int Id { get; set; }
        String Mesto { get; set; }
        String Ulice { get; set; }
        String CisloPopisne { get; set; }
        int Psc { get; set; }

        public Adresa(int id, string mesto, string ulice, string cisloPopisne, int psc)
        {
            Id = id;
            Mesto = mesto;
            Ulice = ulice;
            CisloPopisne = cisloPopisne;
            Psc = psc;
        }
    }
}
