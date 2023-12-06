using System;

namespace GUI.Objects
{
    internal class Pozice
    {
        int Id { get; set; }
        public String nazev { get; set; }

        public Pozice(int id, string nazev)
        {
            Id = id;
            this.nazev = nazev;
        }
        public Pozice(string nazev)
        {
            this.nazev = nazev;
        }

        public override string ToString()
        {
            return nazev;
        }
    }
}
